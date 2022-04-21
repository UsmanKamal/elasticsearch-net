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
namespace Elastic.Clients.Elasticsearch.IndexManagement
{
	public sealed class StatsRequestParameters : RequestParameters<StatsRequestParameters>
	{
		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Fields? CompletionFields { get => Q<Elastic.Clients.Elasticsearch.Fields?>("completion_fields"); set => Q("completion_fields", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.ExpandWildcards? ExpandWildcards { get => Q<Elastic.Clients.Elasticsearch.ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Fields? FielddataFields { get => Q<Elastic.Clients.Elasticsearch.Fields?>("fielddata_fields"); set => Q("fielddata_fields", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Fields? Fields { get => Q<Elastic.Clients.Elasticsearch.Fields?>("fields"); set => Q("fields", value); }

		[JsonIgnore]
		public bool? ForbidClosedIndices { get => Q<bool?>("forbid_closed_indices"); set => Q("forbid_closed_indices", value); }

		[JsonIgnore]
		public IEnumerable<string>? Groups { get => Q<IEnumerable<string>?>("groups"); set => Q("groups", value); }

		[JsonIgnore]
		public bool? IncludeSegmentFileSizes { get => Q<bool?>("include_segment_file_sizes"); set => Q("include_segment_file_sizes", value); }

		[JsonIgnore]
		public bool? IncludeUnloadedSegments { get => Q<bool?>("include_unloaded_segments"); set => Q("include_unloaded_segments", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Level? Level { get => Q<Elastic.Clients.Elasticsearch.Level?>("level"); set => Q("level", value); }
	}

	public partial class StatsRequest : PlainRequestBase<StatsRequestParameters>
	{
		public StatsRequest()
		{
		}

		public StatsRequest(Elastic.Clients.Elasticsearch.Metrics? metric) : base(r => r.Optional("metric", metric))
		{
		}

		public StatsRequest(Elastic.Clients.Elasticsearch.Indices? indices) : base(r => r.Optional("index", indices))
		{
		}

		public StatsRequest(Elastic.Clients.Elasticsearch.Indices? indices, Elastic.Clients.Elasticsearch.Metrics? metric) : base(r => r.Optional("index", indices).Optional("metric", metric))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementStats;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Fields? CompletionFields { get => Q<Elastic.Clients.Elasticsearch.Fields?>("completion_fields"); set => Q("completion_fields", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.ExpandWildcards? ExpandWildcards { get => Q<Elastic.Clients.Elasticsearch.ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Fields? FielddataFields { get => Q<Elastic.Clients.Elasticsearch.Fields?>("fielddata_fields"); set => Q("fielddata_fields", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Fields? Fields { get => Q<Elastic.Clients.Elasticsearch.Fields?>("fields"); set => Q("fields", value); }

		[JsonIgnore]
		public bool? ForbidClosedIndices { get => Q<bool?>("forbid_closed_indices"); set => Q("forbid_closed_indices", value); }

		[JsonIgnore]
		public IEnumerable<string>? Groups { get => Q<IEnumerable<string>?>("groups"); set => Q("groups", value); }

		[JsonIgnore]
		public bool? IncludeSegmentFileSizes { get => Q<bool?>("include_segment_file_sizes"); set => Q("include_segment_file_sizes", value); }

		[JsonIgnore]
		public bool? IncludeUnloadedSegments { get => Q<bool?>("include_unloaded_segments"); set => Q("include_unloaded_segments", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Level? Level { get => Q<Elastic.Clients.Elasticsearch.Level?>("level"); set => Q("level", value); }
	}

	public sealed partial class StatsRequestDescriptor<TDocument> : RequestDescriptorBase<StatsRequestDescriptor<TDocument>, StatsRequestParameters>
	{
		internal StatsRequestDescriptor(Action<StatsRequestDescriptor<TDocument>> configure) => configure.Invoke(this);
		public StatsRequestDescriptor()
		{
		}

		public StatsRequestDescriptor(Elastic.Clients.Elasticsearch.Indices? indices) : base(r => r.Optional("index", indices))
		{
		}

		public StatsRequestDescriptor(Elastic.Clients.Elasticsearch.Indices? indices, Elastic.Clients.Elasticsearch.Metrics? metric) : base(r => r.Optional("index", indices).Optional("metric", metric))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementStats;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		public StatsRequestDescriptor<TDocument> CompletionFields(Elastic.Clients.Elasticsearch.Fields? completionFields) => Qs("completion_fields", completionFields);
		public StatsRequestDescriptor<TDocument> ExpandWildcards(Elastic.Clients.Elasticsearch.ExpandWildcards? expandWildcards) => Qs("expand_wildcards", expandWildcards);
		public StatsRequestDescriptor<TDocument> FielddataFields(Elastic.Clients.Elasticsearch.Fields? fielddataFields) => Qs("fielddata_fields", fielddataFields);
		public StatsRequestDescriptor<TDocument> Fields(Elastic.Clients.Elasticsearch.Fields? fields) => Qs("fields", fields);
		public StatsRequestDescriptor<TDocument> ForbidClosedIndices(bool? forbidClosedIndices = true) => Qs("forbid_closed_indices", forbidClosedIndices);
		public StatsRequestDescriptor<TDocument> Groups(IEnumerable<string>? groups) => Qs("groups", groups);
		public StatsRequestDescriptor<TDocument> IncludeSegmentFileSizes(bool? includeSegmentFileSizes = true) => Qs("include_segment_file_sizes", includeSegmentFileSizes);
		public StatsRequestDescriptor<TDocument> IncludeUnloadedSegments(bool? includeUnloadedSegments = true) => Qs("include_unloaded_segments", includeUnloadedSegments);
		public StatsRequestDescriptor<TDocument> Level(Elastic.Clients.Elasticsearch.Level? level) => Qs("level", level);
		public StatsRequestDescriptor<TDocument> Metric(Elastic.Clients.Elasticsearch.Metrics? metric)
		{
			RouteValues.Optional("metric", metric);
			return Self;
		}

		public StatsRequestDescriptor<TDocument> Indices(Elastic.Clients.Elasticsearch.Indices? indices)
		{
			RouteValues.Optional("index", indices);
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
		}
	}

	public sealed partial class StatsRequestDescriptor : RequestDescriptorBase<StatsRequestDescriptor, StatsRequestParameters>
	{
		internal StatsRequestDescriptor(Action<StatsRequestDescriptor> configure) => configure.Invoke(this);
		public StatsRequestDescriptor()
		{
		}

		public StatsRequestDescriptor(Elastic.Clients.Elasticsearch.Indices? indices) : base(r => r.Optional("index", indices))
		{
		}

		public StatsRequestDescriptor(Elastic.Clients.Elasticsearch.Indices? indices, Elastic.Clients.Elasticsearch.Metrics? metric) : base(r => r.Optional("index", indices).Optional("metric", metric))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementStats;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		public StatsRequestDescriptor CompletionFields(Elastic.Clients.Elasticsearch.Fields? completionFields) => Qs("completion_fields", completionFields);
		public StatsRequestDescriptor ExpandWildcards(Elastic.Clients.Elasticsearch.ExpandWildcards? expandWildcards) => Qs("expand_wildcards", expandWildcards);
		public StatsRequestDescriptor FielddataFields(Elastic.Clients.Elasticsearch.Fields? fielddataFields) => Qs("fielddata_fields", fielddataFields);
		public StatsRequestDescriptor Fields(Elastic.Clients.Elasticsearch.Fields? fields) => Qs("fields", fields);
		public StatsRequestDescriptor ForbidClosedIndices(bool? forbidClosedIndices = true) => Qs("forbid_closed_indices", forbidClosedIndices);
		public StatsRequestDescriptor Groups(IEnumerable<string>? groups) => Qs("groups", groups);
		public StatsRequestDescriptor IncludeSegmentFileSizes(bool? includeSegmentFileSizes = true) => Qs("include_segment_file_sizes", includeSegmentFileSizes);
		public StatsRequestDescriptor IncludeUnloadedSegments(bool? includeUnloadedSegments = true) => Qs("include_unloaded_segments", includeUnloadedSegments);
		public StatsRequestDescriptor Level(Elastic.Clients.Elasticsearch.Level? level) => Qs("level", level);
		public StatsRequestDescriptor Metric(Elastic.Clients.Elasticsearch.Metrics? metric)
		{
			RouteValues.Optional("metric", metric);
			return Self;
		}

		public StatsRequestDescriptor Indices(Elastic.Clients.Elasticsearch.Indices? indices)
		{
			RouteValues.Optional("index", indices);
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
		}
	}
}