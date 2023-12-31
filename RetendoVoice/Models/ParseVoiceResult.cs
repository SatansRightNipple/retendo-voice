﻿using ScriptRunner.OpenAi.Models.Completion;

namespace RetendoVoice.Models
{
    public class ParseVoiceResult
    {
        public RetendoFunctionCall? FunctionCall { get; set; }
        public string RawText { get; set; }

        public ParseVoiceResult(FunctionCall? functionCall, string rawText)
        {
            if (functionCall != null)
                FunctionCall = new RetendoFunctionCall(functionCall);

            RawText = rawText;
        }
    }
}
