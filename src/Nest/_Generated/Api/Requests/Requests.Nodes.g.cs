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
// Run the following in the root of the repository:
//
// ------------------------------------------------

using System;
using System.Text.Json.Serialization;
using Elastic.Transport;

#nullable restore
namespace Nest
{
	[JsonInterfaceConverter(typeof(InterfaceConverter<INodesHotThreadsRequest, NodesHotThreadsRequest>))]
	public interface INodesHotThreadsRequest : IRequest<NodesHotThreadsRequestParameters>
	{
	}

	public class NodesHotThreadsRequest : PlainRequestBase<NodesHotThreadsRequestParameters>, INodesHotThreadsRequest
	{
		protected INodesHotThreadsRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NodesHotThreads;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;
		///<summary>/_nodes/hot_threads</summary>
        public NodesHotThreadsRequest() : base()
		{
		}

		///<summary>/_nodes/{node_id}/hot_threads</summary>
        public NodesHotThreadsRequest(NodeIds nodeId) : base(r => r.Optional("node_id", nodeId))
		{
		}

		[JsonIgnore]
		public bool? IgnoreIdleThreads { get => Q<bool?>("ignore_idle_threads"); set => Q("ignore_idle_threads", value); }

		[JsonIgnore]
		public Time? Interval { get => Q<Time?>("interval"); set => Q("interval", value); }

		[JsonIgnore]
		public long? Snapshots { get => Q<long?>("snapshots"); set => Q("snapshots", value); }

		[JsonIgnore]
		public long? Threads { get => Q<long?>("threads"); set => Q("threads", value); }

		[JsonIgnore]
		public ThreadType? ThreadType { get => Q<ThreadType?>("thread_type"); set => Q("thread_type", value); }

		[JsonIgnore]
		public Time? Timeout { get => Q<Time?>("timeout"); set => Q("timeout", value); }
	}

	[JsonInterfaceConverter(typeof(InterfaceConverter<INodesInfoRequest, NodesInfoRequest>))]
	public interface INodesInfoRequest : IRequest<NodesInfoRequestParameters>
	{
	}

	public class NodesInfoRequest : PlainRequestBase<NodesInfoRequestParameters>, INodesInfoRequest
	{
		protected INodesInfoRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NodesInfo;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;
		///<summary>/_nodes</summary>
        public NodesInfoRequest() : base()
		{
		}

		///<summary>/_nodes/{node_id}</summary>
        public NodesInfoRequest(NodeIds nodeId) : base(r => r.Optional("node_id", nodeId))
		{
		}

		///<summary>/_nodes/{metric}</summary>
        public NodesInfoRequest(Metrics metric) : base(r => r.Optional("metric", metric))
		{
		}

		///<summary>/_nodes/{node_id}/{metric}</summary>
        public NodesInfoRequest(NodeIds nodeId, Metrics metric) : base(r => r.Optional("node_id", nodeId).Optional("metric", metric))
		{
		}

		[JsonIgnore]
		public bool? FlatSettings { get => Q<bool?>("flat_settings"); set => Q("flat_settings", value); }

		[JsonIgnore]
		public Time? Timeout { get => Q<Time?>("timeout"); set => Q("timeout", value); }
	}

	[JsonInterfaceConverter(typeof(InterfaceConverter<IReloadSecureSettingsRequest, ReloadSecureSettingsRequest>))]
	public interface IReloadSecureSettingsRequest : IRequest<ReloadSecureSettingsRequestParameters>
	{
	}

	public class ReloadSecureSettingsRequest : PlainRequestBase<ReloadSecureSettingsRequestParameters>, IReloadSecureSettingsRequest
	{
		protected IReloadSecureSettingsRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NodesReloadSecureSettings;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => SecureSettingsPassword is null;
		///<summary>/_nodes/reload_secure_settings</summary>
        public ReloadSecureSettingsRequest() : base()
		{
		}

		///<summary>/_nodes/{node_id}/reload_secure_settings</summary>
        public ReloadSecureSettingsRequest(NodeIds nodeId) : base(r => r.Optional("node_id", nodeId))
		{
		}

		[JsonIgnore]
		public Time? Timeout { get => Q<Time?>("timeout"); set => Q("timeout", value); }

		[JsonPropertyName("secure_settings_password")]
		public string? SecureSettingsPassword
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}
	}

	[JsonInterfaceConverter(typeof(InterfaceConverter<INodesStatsRequest, NodesStatsRequest>))]
	public interface INodesStatsRequest : IRequest<NodesStatsRequestParameters>
	{
	}

	public class NodesStatsRequest : PlainRequestBase<NodesStatsRequestParameters>, INodesStatsRequest
	{
		protected INodesStatsRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NodesStats;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;
		///<summary>/_nodes/stats</summary>
        public NodesStatsRequest() : base()
		{
		}

		///<summary>/_nodes/{node_id}/stats</summary>
        public NodesStatsRequest(NodeIds nodeId) : base(r => r.Optional("node_id", nodeId))
		{
		}

		///<summary>/_nodes/stats/{metric}</summary>
        public NodesStatsRequest(Metrics metric) : base(r => r.Optional("metric", metric))
		{
		}

		///<summary>/_nodes/{node_id}/stats/{metric}</summary>
        public NodesStatsRequest(NodeIds nodeId, Metrics metric) : base(r => r.Optional("node_id", nodeId).Optional("metric", metric))
		{
		}

		///<summary>/_nodes/stats/{metric}/{index_metric}</summary>
        public NodesStatsRequest(Metrics metric, Metrics indexMetric) : base(r => r.Optional("metric", metric).Optional("index_metric", indexMetric))
		{
		}

		///<summary>/_nodes/{node_id}/stats/{metric}/{index_metric}</summary>
        public NodesStatsRequest(NodeIds nodeId, Metrics metric, Metrics indexMetric) : base(r => r.Optional("node_id", nodeId).Optional("metric", metric).Optional("index_metric", indexMetric))
		{
		}

		[JsonIgnore]
		public Fields? CompletionFields { get => Q<Fields?>("completion_fields"); set => Q("completion_fields", value); }

		[JsonIgnore]
		public Fields? FielddataFields { get => Q<Fields?>("fielddata_fields"); set => Q("fielddata_fields", value); }

		[JsonIgnore]
		public Fields? Fields { get => Q<Fields?>("fields"); set => Q("fields", value); }

		[JsonIgnore]
		public bool? Groups { get => Q<bool?>("groups"); set => Q("groups", value); }

		[JsonIgnore]
		public bool? IncludeSegmentFileSizes { get => Q<bool?>("include_segment_file_sizes"); set => Q("include_segment_file_sizes", value); }

		[JsonIgnore]
		public Level? Level { get => Q<Level?>("level"); set => Q("level", value); }

		[JsonIgnore]
		public Time? Timeout { get => Q<Time?>("timeout"); set => Q("timeout", value); }
	}

	[JsonInterfaceConverter(typeof(InterfaceConverter<INodesUsageRequest, NodesUsageRequest>))]
	public interface INodesUsageRequest : IRequest<NodesUsageRequestParameters>
	{
	}

	public class NodesUsageRequest : PlainRequestBase<NodesUsageRequestParameters>, INodesUsageRequest
	{
		protected INodesUsageRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NodesUsage;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;
		///<summary>/_nodes/usage</summary>
        public NodesUsageRequest() : base()
		{
		}

		///<summary>/_nodes/{node_id}/usage</summary>
        public NodesUsageRequest(NodeIds nodeId) : base(r => r.Optional("node_id", nodeId))
		{
		}

		///<summary>/_nodes/usage/{metric}</summary>
        public NodesUsageRequest(Metrics metric) : base(r => r.Optional("metric", metric))
		{
		}

		///<summary>/_nodes/{node_id}/usage/{metric}</summary>
        public NodesUsageRequest(NodeIds nodeId, Metrics metric) : base(r => r.Optional("node_id", nodeId).Optional("metric", metric))
		{
		}

		[JsonIgnore]
		public Time? Timeout { get => Q<Time?>("timeout"); set => Q("timeout", value); }
	}
}