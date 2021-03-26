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
	[JsonInterfaceConverter(typeof(InterfaceConverter<IAcknowledgeWatchRequest, AcknowledgeWatchRequest>))]
	public interface IAcknowledgeWatchRequest : IRequest<AcknowledgeWatchRequestParameters>
	{
	}

	public class AcknowledgeWatchRequest : PlainRequestBase<AcknowledgeWatchRequestParameters>, IAcknowledgeWatchRequest
	{
		protected IAcknowledgeWatchRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.WatcherAckWatch;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;
		///<summary>/_watcher/watch/{watch_id}/_ack</summary>
        public AcknowledgeWatchRequest(Name watchId) : base(r => r.Required("watch_id", watchId))
		{
		}

		///<summary>/_watcher/watch/{watch_id}/_ack/{action_id}</summary>
        public AcknowledgeWatchRequest(Name watchId, Names actionId) : base(r => r.Required("watch_id", watchId).Optional("action_id", actionId))
		{
		}
	}

	[JsonInterfaceConverter(typeof(InterfaceConverter<IActivateWatchRequest, ActivateWatchRequest>))]
	public interface IActivateWatchRequest : IRequest<ActivateWatchRequestParameters>
	{
	}

	public class ActivateWatchRequest : PlainRequestBase<ActivateWatchRequestParameters>, IActivateWatchRequest
	{
		protected IActivateWatchRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.WatcherActivateWatch;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;
		///<summary>/_watcher/watch/{watch_id}/_activate</summary>
        public ActivateWatchRequest(Name watchId) : base(r => r.Required("watch_id", watchId))
		{
		}
	}

	[JsonInterfaceConverter(typeof(InterfaceConverter<IDeactivateWatchRequest, DeactivateWatchRequest>))]
	public interface IDeactivateWatchRequest : IRequest<DeactivateWatchRequestParameters>
	{
	}

	public class DeactivateWatchRequest : PlainRequestBase<DeactivateWatchRequestParameters>, IDeactivateWatchRequest
	{
		protected IDeactivateWatchRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.WatcherDeactivateWatch;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;
		///<summary>/_watcher/watch/{watch_id}/_deactivate</summary>
        public DeactivateWatchRequest(Name watchId) : base(r => r.Required("watch_id", watchId))
		{
		}
	}

	[JsonInterfaceConverter(typeof(InterfaceConverter<IDeleteWatchRequest, DeleteWatchRequest>))]
	public interface IDeleteWatchRequest : IRequest<DeleteWatchRequestParameters>
	{
	}

	public class DeleteWatchRequest : PlainRequestBase<DeleteWatchRequestParameters>, IDeleteWatchRequest
	{
		protected IDeleteWatchRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.WatcherDeleteWatch;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;
		///<summary>/_watcher/watch/{id}</summary>
        public DeleteWatchRequest(Name id) : base(r => r.Required("id", id))
		{
		}
	}

	[JsonInterfaceConverter(typeof(InterfaceConverter<IExecuteWatchRequest, ExecuteWatchRequest>))]
	public interface IExecuteWatchRequest : IRequest<ExecuteWatchRequestParameters>
	{
	}

	public class ExecuteWatchRequest : PlainRequestBase<ExecuteWatchRequestParameters>, IExecuteWatchRequest
	{
		protected IExecuteWatchRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.WatcherExecuteWatch;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => true;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => IgnoreCondition is null && RecordExecution is null;
		///<summary>/_watcher/watch/{id}/_execute</summary>
        public ExecuteWatchRequest(Name id) : base(r => r.Optional("id", id))
		{
		}

		///<summary>/_watcher/watch/_execute</summary>
        public ExecuteWatchRequest() : base()
		{
		}

		[JsonIgnore]
		public bool? Debug { get => Q<bool?>("debug"); set => Q("debug", value); }

		[JsonPropertyName("ignore_condition")]
		public bool? IgnoreCondition
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("record_execution")]
		public bool? RecordExecution
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}
	}

	[JsonInterfaceConverter(typeof(InterfaceConverter<IGetWatchRequest, GetWatchRequest>))]
	public interface IGetWatchRequest : IRequest<GetWatchRequestParameters>
	{
	}

	public class GetWatchRequest : PlainRequestBase<GetWatchRequestParameters>, IGetWatchRequest
	{
		protected IGetWatchRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.WatcherGetWatch;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;
		///<summary>/_watcher/watch/{id}</summary>
        public GetWatchRequest(Name id) : base(r => r.Required("id", id))
		{
		}
	}

	[JsonInterfaceConverter(typeof(InterfaceConverter<IPutWatchRequest, PutWatchRequest>))]
	public interface IPutWatchRequest : IRequest<PutWatchRequestParameters>
	{
	}

	public class PutWatchRequest : PlainRequestBase<PutWatchRequestParameters>, IPutWatchRequest
	{
		protected IPutWatchRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.WatcherPutWatch;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => true;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => ThrottlePeriod is null;
		///<summary>/_watcher/watch/{id}</summary>
        public PutWatchRequest(Name id) : base(r => r.Required("id", id))
		{
		}

		[JsonIgnore]
		public bool? Active { get => Q<bool?>("active"); set => Q("active", value); }

		[JsonIgnore]
		public long? IfPrimaryTerm { get => Q<long?>("if_primary_term"); set => Q("if_primary_term", value); }

		[JsonIgnore]
		public long? IfSequenceNumber { get => Q<long?>("if_sequence_number"); set => Q("if_sequence_number", value); }

		[JsonIgnore]
		public long? Version { get => Q<long?>("version"); set => Q("version", value); }

		[JsonPropertyName("throttle_period")]
		public string? ThrottlePeriod
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}
	}

	[JsonInterfaceConverter(typeof(InterfaceConverter<IQueryWatchesRequest, QueryWatchesRequest>))]
	public interface IQueryWatchesRequest : IRequest<QueryWatchesRequestParameters>
	{
	}

	public class QueryWatchesRequest : PlainRequestBase<QueryWatchesRequestParameters>, IQueryWatchesRequest
	{
		protected IQueryWatchesRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.WatcherQueryWatches;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		protected override bool CanBeEmpty => false;
		protected override bool IsEmpty => false;
		///<summary>/_watcher/_query/watches</summary>
        public QueryWatchesRequest() : base()
		{
		}

		[JsonIgnore]
		public string StubB { get => Q<string>("stub_b"); set => Q("stub_b", value); }

		[JsonPropertyName("stub_c")]
		public string StubC
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}
	}

	[JsonInterfaceConverter(typeof(InterfaceConverter<IStartWatcherRequest, StartWatcherRequest>))]
	public interface IStartWatcherRequest : IRequest<StartWatcherRequestParameters>
	{
	}

	public class StartWatcherRequest : PlainRequestBase<StartWatcherRequestParameters>, IStartWatcherRequest
	{
		protected IStartWatcherRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.WatcherStart;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;
		///<summary>/_watcher/_start</summary>
        public StartWatcherRequest() : base()
		{
		}
	}

	[JsonInterfaceConverter(typeof(InterfaceConverter<IWatcherStatsRequest, WatcherStatsRequest>))]
	public interface IWatcherStatsRequest : IRequest<WatcherStatsRequestParameters>
	{
	}

	public class WatcherStatsRequest : PlainRequestBase<WatcherStatsRequestParameters>, IWatcherStatsRequest
	{
		protected IWatcherStatsRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.WatcherStats;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;
		///<summary>/_watcher/stats</summary>
        public WatcherStatsRequest() : base()
		{
		}

		///<summary>/_watcher/stats/{metric}</summary>
        public WatcherStatsRequest(Metrics metric) : base(r => r.Optional("metric", metric))
		{
		}

		[JsonIgnore]
		public bool? EmitStacktraces { get => Q<bool?>("emit_stacktraces"); set => Q("emit_stacktraces", value); }
	}

	[JsonInterfaceConverter(typeof(InterfaceConverter<IStopWatcherRequest, StopWatcherRequest>))]
	public interface IStopWatcherRequest : IRequest<StopWatcherRequestParameters>
	{
	}

	public class StopWatcherRequest : PlainRequestBase<StopWatcherRequestParameters>, IStopWatcherRequest
	{
		protected IStopWatcherRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.WatcherStop;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;
		///<summary>/_watcher/_stop</summary>
        public StopWatcherRequest() : base()
		{
		}
	}
}