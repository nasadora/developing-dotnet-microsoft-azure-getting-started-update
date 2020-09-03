#r "Newtonsoft.Json"

using System;
using Newtonsoft.Json.Linq;
using Microsoft.Extensions.Logging;

public static void Run(string myQueueItem, out object locationDocument, ILogger log)
{

    log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");

    dynamic location = JObject.Parse(myQueueItem);

    locationDocument = new {
        id = System.Guid.NewGuid().ToString(),
        country = location.country,
        Name = location.Name,
        Address = location.Address,
        Telephone = location.Telephone
    };
}
