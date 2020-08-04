using System;
using System.Collections.Generic;

namespace Multivocal.Parser.ActionsOnGoogle
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Parameters    {
    }

    public class OutputContext    {
        public string name { get; set; } 
    }

    public class Intent    {
        public string name { get; set; } 
        public string displayName { get; set; } 
    }

    public class DiagnosticInfo    {
    }

    public class QueryResult    {
        public string QueryText { get; set; } 
        public string Action { get; set; } 
        public Parameters Parameters { get; set; } 
        public bool AllRequiredParamsPresent { get; set; } 
        public string FulfillmentText { get; set; } 
        public List<object> FulfillmentMessages { get; set; } 
        public List<OutputContext> OutputContexts { get; set; } 
        public Intent Intent { get; set; } 
        public int IntentDetectionConfidence { get; set; } 
        public DiagnosticInfo DiagnosticInfo { get; set; } 
        public string LanguageCode { get; set; } 
    }

    public class Capability    {
        public string Name { get; set; } 
    }

    public class Surface    {
        public List<Capability> Capabilities { get; set; } 
    }

    public class RawInput    {
        public string Query { get; set; } 
        public string InputType { get; set; } 
    }

    public class Input    {
        public List<RawInput> RawInputs { get; set; } 
        public string Intent { get; set; } 
    }

    public class User    {
        public DateTime LastSeen { get; set; } 
        public List<string> Permissions { get; set; } 
        public string Locale { get; set; } 
        public string UserId { get; set; } 
    }

    public class Conversation    {
        public string ConversationId { get; set; } 
        public string Type { get; set; } 
    }

    public class Capability2    {
        public string Name { get; set; } 
    }

    public class AvailableSurface    {
        public List<Capability2> Capabilities { get; set; } 
    }

    public class Payload    {
        public bool IsInSandbox { get; set; } 
        public Surface Surface { get; set; } 
        public List<Input> Inputs { get; set; } 
        public User User { get; set; } 
        public Conversation Conversation { get; set; } 
        public List<AvailableSurface> AvailableSurfaces { get; set; } 
    }

    public class OriginalDetectIntentRequest    {
        public string Source { get; set; } 
        public string Version { get; set; } 
        public Payload Payload { get; set; } 
    }

    public class ActionsOnGoogleFulfillmentWebhookRequest    {
        public string ResponseId { get; set; } 
        public QueryResult QueryResult { get; set; } 
        public OriginalDetectIntentRequest OriginalDetectIntentRequest { get; set; } 
        public string Session { get; set; } 
    }

}