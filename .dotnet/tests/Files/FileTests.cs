﻿using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework;
using OpenAI.Files;
using OpenAI.Tests.Utility;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using static OpenAI.Tests.TestHelpers;

namespace OpenAI.Tests.Files;

[TestFixture(true)]
[TestFixture(false)]
[Parallelizable(ParallelScope.Fixtures)]
public partial class FileTests : SyncAsyncTestBase
{
    public FileTests(bool isAsync) 
        : base(isAsync)
    {
    }

    [Test]
    public async Task ListFiles()
    {
        FileClient client = GetTestClient();

        OpenAIFileInfoCollection allFiles = IsAsync
            ? await client.GetFilesAsync()
            : client.GetFiles();
        Assert.That(allFiles.Count, Is.GreaterThan(0));
        Console.WriteLine($"Total files count: {allFiles.Count}");

        OpenAIFileInfoCollection assistantsFiles = IsAsync
            ? await client.GetFilesAsync(OpenAIFilePurpose.Assistants)
            : client.GetFiles(OpenAIFilePurpose.Assistants);
        Assert.That(assistantsFiles.Count, Is.GreaterThan(0).And.LessThan(allFiles.Count));
        Console.WriteLine($"Assistant files count: {assistantsFiles.Count}");
    }

    [Test]
    public async Task UploadAndRetrieve()
    {
        FileClient client = GetTestClient();
        string fileContent = "Hello! This is a test text file. Please delete me.";
        using Stream file = BinaryData.FromString(fileContent).ToStream();
        string filename = "test-file-delete-me.txt";

        // Upload file.
        OpenAIFileInfo uploadedFile = IsAsync
            ? await client.UploadFileAsync(file, filename, FileUploadPurpose.Assistants)
            : client.UploadFile(file, filename, FileUploadPurpose.Assistants);
        Assert.That(uploadedFile, Is.Not.Null);

        try
        {
            Assert.That(uploadedFile.Filename, Is.EqualTo(filename));
            Assert.That(uploadedFile.Purpose, Is.EqualTo(OpenAIFilePurpose.Assistants));

            // Retrieve file.
            OpenAIFileInfo retrievedFile = IsAsync
                ? await client.GetFileAsync(uploadedFile.Id)
                : client.GetFile(uploadedFile.Id);
            Assert.That(retrievedFile.Id, Is.EqualTo(uploadedFile.Id));
            Assert.That(retrievedFile.Filename, Is.EqualTo(uploadedFile.Filename));
        }
        finally
        {
            // Delete file.
            bool deleted = IsAsync
                ? await client.DeleteFileAsync(uploadedFile.Id)
                : client.DeleteFile(uploadedFile.Id);
            Assert.That(deleted, Is.True);
        }
    }

    [Test]
    public async Task UploadAndDownloadContent()
    {
        FileClient client = GetTestClient();
        string imagePath = Path.Combine("Assets", "images_dog_and_cat.png");

        // Upload file.
        OpenAIFileInfo uploadedFile = IsAsync
            ? await client.UploadFileAsync(imagePath, FileUploadPurpose.Vision)
            : client.UploadFile(imagePath, FileUploadPurpose.Vision);
        Assert.That(uploadedFile, Is.Not.Null);

        try
        {
            Assert.That(uploadedFile.Filename, Is.EqualTo(imagePath));
            Assert.That(uploadedFile.Purpose, Is.EqualTo(OpenAIFilePurpose.Vision));

            // Download file content.
            BinaryData downloadedContent = IsAsync
                ? await client.DownloadFileAsync(uploadedFile.Id)
                : client.DownloadFile(uploadedFile.Id);
            Assert.That(downloadedContent, Is.Not.Null);
        }
        finally
        {
            // Delete file.
            bool deleted = IsAsync
                ? await client.DeleteFileAsync(uploadedFile.Id)
                : client.DeleteFile(uploadedFile.Id);
            Assert.That(deleted, Is.True);
        }
    }

    [Test]
    public void SerializeFileCollection()
    {
        // TODO: Add this test.
    }

    [Test]
    public async Task NonAsciiFilename()
    {
        FileClient client = GetTestClient();
        string filename = "你好.txt";
        BinaryData fileContent = BinaryData.FromString("世界您好！这是个测试。");
        OpenAIFileInfo uploadedFile = IsAsync
            ? await client.UploadFileAsync(fileContent, filename, FileUploadPurpose.Assistants)
            : client.UploadFile(fileContent, filename, FileUploadPurpose.Assistants);
        Assert.That(uploadedFile?.Filename, Is.EqualTo(filename));
    }

    [Test]
    public async Task UploadJobWorks()
    {
        FileClient client = GetTestClient();

        byte[][] parts =
        [
            "Hello "u8.ToArray(),
            "World "u8.ToArray(),
            "this is a test"u8.ToArray(),
        ];
        int totalSize = parts.Sum(part => part.Length);
        Stream[] partStreams = parts.Select(part => new MemoryStream(part)).ToArray();

        UploadJob uploadJob = IsAsync
            ? await client.CreateUploadJobAsync("test-file.txt", totalSize, UploadJobCreationPurpose.Assistants, "text/plain")
            : client.CreateUploadJob("test-file.txt", totalSize, UploadJobCreationPurpose.Assistants, "text/plain");
        Assert.That(uploadJob, Is.Not.Null);
        Assert.That(uploadJob.Status, Is.EqualTo(UploadJobStatus.Pending));

        Task[] uploadTasks = new Task[parts.Length];
        UploadJobDataPart[] uploadParts = new UploadJobDataPart[parts.Length];
        for (int i = 0; i < parts.Length; i++)
        {
            int partIndex = i;
            uploadTasks[partIndex] = Task.Run(async () =>
            {
                uploadParts[partIndex] = IsAsync
                    ? await client.AddDataPartToUploadJobAsync(uploadJob.Id, partStreams[partIndex])
                    : client.AddDataPartToUploadJob(uploadJob.Id, partStreams[partIndex]);
            });
        }

        await Task.WhenAll(uploadTasks);
        Assert.That(uploadTasks.All(task => task.IsCompletedSuccessfully));
        Assert.That(uploadParts.All(uploadPart =>
            uploadPart is not null
            && uploadPart.UploadId == uploadJob.Id
            && !string.IsNullOrEmpty(uploadPart.Id)));

        IEnumerable<string> orderedPartIds = uploadParts.Select(part => part.Id);
        uploadJob = IsAsync
            ? await client.CompleteUploadJobAsync(uploadJob.Id, orderedPartIds)
            : client.CompleteUploadJob(uploadJob.Id, orderedPartIds);
        Assert.That(uploadJob.Status, Is.EqualTo(UploadJobStatus.Completed));
        Assert.That(uploadJob.File.Id, Is.Not.Null.And.Not.Empty);
        Assert.That(uploadJob.File.SizeInBytes, Is.EqualTo(totalSize));
    }

    private static FileClient GetTestClient() => GetTestClient<FileClient>(TestScenario.Files);
}