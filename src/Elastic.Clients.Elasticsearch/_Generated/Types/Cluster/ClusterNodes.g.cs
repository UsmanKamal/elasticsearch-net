// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.
//
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// ------------------------------------------------
//
// This file is automatically generated.
// Please do not edit these files manually.
//
// ------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Cluster
{
	public partial class ClusterNodes
	{
		[JsonInclude]
		[JsonPropertyName("count")]
		public Elastic.Clients.Elasticsearch.Cluster.ClusterNodeCount Count { get; init; }

		[JsonInclude]
		[JsonPropertyName("discovery_types")]
		public Dictionary<string, int> DiscoveryTypes { get; init; }

		[JsonInclude]
		[JsonPropertyName("fs")]
		public Elastic.Clients.Elasticsearch.Cluster.ClusterFileSystem Fs { get; init; }

		[JsonInclude]
		[JsonPropertyName("indexing_pressure")]
		public Elastic.Clients.Elasticsearch.Cluster.IndexingPressure IndexingPressure { get; init; }

		[JsonInclude]
		[JsonPropertyName("ingest")]
		public Elastic.Clients.Elasticsearch.Cluster.ClusterIngest Ingest { get; init; }

		[JsonInclude]
		[JsonPropertyName("jvm")]
		public Elastic.Clients.Elasticsearch.Cluster.ClusterJvm Jvm { get; init; }

		[JsonInclude]
		[JsonPropertyName("network_types")]
		public Elastic.Clients.Elasticsearch.Cluster.ClusterNetworkTypes NetworkTypes { get; init; }

		[JsonInclude]
		[JsonPropertyName("os")]
		public Elastic.Clients.Elasticsearch.Cluster.ClusterOperatingSystem Os { get; init; }

		[JsonInclude]
		[JsonPropertyName("packaging_types")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Cluster.NodePackagingType> PackagingTypes { get; init; }

		[JsonInclude]
		[JsonPropertyName("plugins")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.PluginStats> Plugins { get; init; }

		[JsonInclude]
		[JsonPropertyName("process")]
		public Elastic.Clients.Elasticsearch.Cluster.ClusterProcess Process { get; init; }

		[JsonInclude]
		[JsonPropertyName("versions")]
		public IReadOnlyCollection<string> Versions { get; init; }
	}
}