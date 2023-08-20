﻿using GuardNet;
using Newtonsoft.Json.Linq;
using Promitor.Core.Contracts;
using Promitor.Core.Contracts.ResourceTypes;

namespace Promitor.Agents.ResourceDiscovery.Graph.ResourceTypes
{
	public class PowerBiEmbeddedDiscoveryQuery : ResourceDiscoveryQuery
	{
            public override string[] ResourceTypes => new[] { "microsoft.powerbidedicated/capacities" };
            public override string[] ProjectedFieldNames => new[] { "subscriptionId", "resourceGroup", "name", "id" };

        public override AzureResourceDefinition ParseResults(JToken resultRowEntry)
        {
            var resource = new PowerBiEmbeddedResourceDefinition(resultRowEntry[0]?.ToString(), resultRowEntry[1]?.ToString(), resultRowEntry[3]?.ToString());
            return resource;
        }
    }
}
