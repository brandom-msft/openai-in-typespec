﻿namespace OpenAI.Assistants;

public class TextAnnotationUpdate
{
    /// <summary>
    /// The index of the content item that this annotation applies to.
    /// </summary>
    public virtual int ContentIndex => _fileSearchCitation?.Index ?? _codeCitation?.Index ?? -1;

    /// <summary>
    /// The index in the message content at which the citation begins.
    /// </summary>
    public virtual int? StartIndex => _fileSearchCitation?.StartIndex ?? _codeCitation?.StartIndex;

    /// <summary>
    /// The index in the message content at which the citation ends.
    /// </summary>
    public virtual int? EndIndex => _fileSearchCitation?.EndIndex ?? _codeCitation?.EndIndex;

    /// <summary>
    /// The text in the message content that should be replaced.
    /// </summary>
    public virtual string TextToReplace => _fileSearchCitation?.Text ?? _codeCitation?.Text;

    /// <summary>
    /// The ID of the file cited by the <c>file_search</c> tool for this annotation.
    /// </summary>
    public virtual string InputFileId => _fileSearchCitation?.FileCitation?.FileId;

    /// <summary>
    /// The ID of the file that was generated by the <c>code_interpreter</c> tool for this citation.
    /// </summary>
    public virtual string OutputFileId => _codeCitation?.FilePath?.FileId;

    internal readonly MessageDeltaTextContentAnnotation _internalAnnotation;
    private readonly MessageDeltaContentTextAnnotationsFileCitationObject _fileSearchCitation;
    private readonly MessageDeltaContentTextAnnotationsFilePathObject _codeCitation;

    internal TextAnnotationUpdate(MessageDeltaTextContentAnnotation internalAnnotation)
    {
        _internalAnnotation = internalAnnotation;
        _fileSearchCitation = internalAnnotation as MessageDeltaContentTextAnnotationsFileCitationObject;
        _codeCitation = internalAnnotation as MessageDeltaContentTextAnnotationsFilePathObject;
    }
}