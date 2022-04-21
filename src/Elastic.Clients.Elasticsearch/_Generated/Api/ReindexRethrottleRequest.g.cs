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

using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch
{
	public sealed class ReindexRethrottleRequestParameters : RequestParameters<ReindexRethrottleRequestParameters>
	{
		[JsonIgnore]
		public long? RequestsPerSecond { get => Q<long?>("requests_per_second"); set => Q("requests_per_second", value); }
	}

	public partial class ReindexRethrottleRequest : PlainRequestBase<ReindexRethrottleRequestParameters>
	{
		public ReindexRethrottleRequest(Elastic.Clients.Elasticsearch.Id task_id) : base(r => r.Required("task_id", task_id))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceReindexRethrottle;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		[JsonIgnore]
		public long? RequestsPerSecond { get => Q<long?>("requests_per_second"); set => Q("requests_per_second", value); }
	}

	public sealed partial class ReindexRethrottleRequestDescriptor : RequestDescriptorBase<ReindexRethrottleRequestDescriptor, ReindexRethrottleRequestParameters>
	{
		internal ReindexRethrottleRequestDescriptor(Action<ReindexRethrottleRequestDescriptor> configure) => configure.Invoke(this);
		public ReindexRethrottleRequestDescriptor(Elastic.Clients.Elasticsearch.Id task_id) : base(r => r.Required("task_id", task_id))
		{
		}

		internal ReindexRethrottleRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceReindexRethrottle;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		public ReindexRethrottleRequestDescriptor RequestsPerSecond(long? requestsPerSecond) => Qs("requests_per_second", requestsPerSecond);
		public ReindexRethrottleRequestDescriptor TaskId(Elastic.Clients.Elasticsearch.Id task_id)
		{
			RouteValues.Required("task_id", task_id);
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
		}
	}
}