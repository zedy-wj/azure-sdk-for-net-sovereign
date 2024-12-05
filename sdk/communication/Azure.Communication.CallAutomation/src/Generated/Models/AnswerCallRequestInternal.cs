// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Communication.CallAutomation
{
    /// <summary> The request payload for answering the call. </summary>
    internal partial class AnswerCallRequestInternal
    {
        /// <summary> Initializes a new instance of <see cref="AnswerCallRequestInternal"/>. </summary>
        /// <param name="incomingCallContext"> The context associated with the call. </param>
        /// <param name="callbackUri"> The callback uri. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="incomingCallContext"/> or <paramref name="callbackUri"/> is null. </exception>
        public AnswerCallRequestInternal(string incomingCallContext, string callbackUri)
        {
            Argument.AssertNotNull(incomingCallContext, nameof(incomingCallContext));
            Argument.AssertNotNull(callbackUri, nameof(callbackUri));

            IncomingCallContext = incomingCallContext;
            CallbackUri = callbackUri;
        }

        /// <summary> Initializes a new instance of <see cref="AnswerCallRequestInternal"/>. </summary>
        /// <param name="incomingCallContext"> The context associated with the call. </param>
        /// <param name="callbackUri"> The callback uri. </param>
        /// <param name="customCallingContext"> Used by customer to send custom calling context to targets when answering On-Behalf-Of call. </param>
        /// <param name="operationContext"> A customer set value used to track the answering of a call. </param>
        /// <param name="callIntelligenceOptions"> AI options for the call. </param>
        /// <param name="answeredBy"> The identifier of the call automation entity which answers the call. </param>
        /// <param name="mediaStreamingOptions"> Media Streaming Options. </param>
        /// <param name="transcriptionOptions"> Transcription Options. </param>
        internal AnswerCallRequestInternal(string incomingCallContext, string callbackUri, CustomCallingContextInternal customCallingContext, string operationContext, CallIntelligenceOptionsInternal callIntelligenceOptions, CommunicationUserIdentifierModel answeredBy, MediaStreamingOptionsInternal mediaStreamingOptions, TranscriptionOptionsInternal transcriptionOptions)
        {
            IncomingCallContext = incomingCallContext;
            CallbackUri = callbackUri;
            CustomCallingContext = customCallingContext;
            OperationContext = operationContext;
            CallIntelligenceOptions = callIntelligenceOptions;
            AnsweredBy = answeredBy;
            MediaStreamingOptions = mediaStreamingOptions;
            TranscriptionOptions = transcriptionOptions;
        }

        /// <summary> The context associated with the call. </summary>
        public string IncomingCallContext { get; }
        /// <summary> The callback uri. </summary>
        public string CallbackUri { get; }
        /// <summary> Used by customer to send custom calling context to targets when answering On-Behalf-Of call. </summary>
        public CustomCallingContextInternal CustomCallingContext { get; set; }
        /// <summary> A customer set value used to track the answering of a call. </summary>
        public string OperationContext { get; set; }
        /// <summary> AI options for the call. </summary>
        public CallIntelligenceOptionsInternal CallIntelligenceOptions { get; set; }
        /// <summary> The identifier of the call automation entity which answers the call. </summary>
        public CommunicationUserIdentifierModel AnsweredBy { get; set; }
        /// <summary> Media Streaming Options. </summary>
        public MediaStreamingOptionsInternal MediaStreamingOptions { get; set; }
        /// <summary> Transcription Options. </summary>
        public TranscriptionOptionsInternal TranscriptionOptions { get; set; }
    }
}
