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

using Elastic.Clients.Elasticsearch.Cluster;
using Elastic.Clients.Elasticsearch.IndexManagement;
using Elastic.Clients.Elasticsearch.Ingest;
using System;
using System.Threading;
using System.Threading.Tasks;

#nullable restore
namespace Elastic.Clients.Elasticsearch
{
	public partial interface IElasticClient
	{
		ClusterNamespace Cluster { get; }

		IndexManagementNamespace IndexManagement { get; }

		IngestNamespace Ingest { get; }

		PingResponse Ping(PingRequest request);
		Task<PingResponse> PingAsync(PingRequest request, CancellationToken cancellationToken = default);
		PingResponse Ping(Action<PingRequestDescriptor> configureRequest = null);
		Task<PingResponse> PingAsync(Action<PingRequestDescriptor> configureRequest = null, CancellationToken cancellationToken = default);
		SearchResponse<TDocument> Search<TDocument>(SearchRequest request);
		Task<SearchResponse<TDocument>> SearchAsync<TDocument>(SearchRequest request, CancellationToken cancellationToken = default);
		SearchResponse<TDocument> Search<TDocument>(Action<SearchRequestDescriptor> configureRequest = null);
		Task<SearchResponse<TDocument>> SearchAsync<TDocument>(Action<SearchRequestDescriptor> configureRequest = null, CancellationToken cancellationToken = default);
	}
}