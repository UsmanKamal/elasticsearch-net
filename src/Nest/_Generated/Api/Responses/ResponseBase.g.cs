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

#nullable restore
namespace Nest
{
	public abstract class AcknowledgedResponseBase : ResponseBase
	{
		[JsonPropertyName("acknowledged")]
		public bool Acknowledged
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public abstract class DictionaryResponseBase : ResponseBase
	{
	}

	public abstract class IndicesResponseBase : AcknowledgedResponseBase
	{
		[JsonPropertyName("_shards")]
		public ShardStatistics? Shards
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public abstract class NodesResponseBase : ResponseBase
	{
		[JsonPropertyName("_nodes")]
		public NodeStatistics node_stats
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public abstract class ShardsOperationResponseBase : ResponseBase
	{
		[JsonPropertyName("_shards")]
		public ShardStatistics Shards
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public abstract class WriteResponseBase : ResponseBase
	{
		[JsonPropertyName("_id")]
		public Id Id
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_index")]
		public IndexName Index
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_primary_term")]
		public long PrimaryTerm
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("result")]
		public Result Result
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_seq_no")]
		public SequenceNumber SeqNo
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_shards")]
		public ShardStatistics Shards
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_type")]
		public DocType? Type
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_version")]
		public VersionNumber Version
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("forced_refresh")]
		public bool? ForcedRefresh
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}
}