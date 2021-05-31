extern alias BetaLib;
using System;
using System.Text.Json;
using Microsoft.Graph;

namespace BetaV1Deserialization
{
    static class Program
    {
        static void Main()
        {
            // This is an actual payload sent by the service that failed in my application
            string payload = @"{
    ""value"": [
        {
            ""subscriptionId"": ""5c748643-b830-4b11-a165-cc4b59c9820c"",
            ""subscriptionExpirationDateTime"": ""2021-05-15T09:06:46.5737745-07:00"",
            ""changeType"": ""created"",
            ""resource"": ""Users/1023ccca-b008-40f6-950a-aa1951a1f0d4/Messages/AAMkADY0ZjM2ZWJlLTEwOGUtNGNiOS04MTFiLWE3Y2UwNjRiZDNiMQBGAAAAAACWRvY6Vjb0SabVPshsbtVRBwAtISQkTseOQLhQ9a0koD2UAAAAAAEMAAAtISQkTseOQLhQ9a0koD2UAAB9Mb9SAAA="",
            ""resourceData"": {
                ""@odata.type"": ""#Microsoft.Graph.Message"",
                ""@odata.id"": ""Users/1023ccca-b008-40f6-950a-aa1951a1f0d4/Messages/AAMkADY0ZjM2ZWJlLTEwOGUtNGNiOS04MTFiLWE3Y2UwNjRiZDNiMQBGAAAAAACWRvY6Vjb0SabVPshsbtVRBwAtISQkTseOQLhQ9a0koD2UAAAAAAEMAAAtISQkTseOQLhQ9a0koD2UAAB9Mb9SAAA="",
                ""@odata.etag"": ""W/\""CQAAABYAAAAtISQkTseOQLhQ9a0koD2UAAB9GwlV\"""",
                ""id"": ""AAMkADY0ZjM2ZWJlLTEwOGUtNGNiOS04MTFiLWE3Y2UwNjRiZDNiMQBGAAAAAACWRvY6Vjb0SabVPshsbtVRBwAtISQkTseOQLhQ9a0koD2UAAAAAAEMAAAtISQkTseOQLhQ9a0koD2UAAB9Mb9SAAA=""
            },
            ""clientState"": ""GraphTutorialState"",
            ""tenantId"": ""dfa81919-e5d3-4357-82ae-6b1e672fde09""
        }
    ]
}";

            var jsonOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };

            // Deserialize the JSON payload into a list of ChangeNotification
            // objects
            try
            {
                var notifications = JsonSerializer.Deserialize<ChangeNotificationCollection>(payload, jsonOptions);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
