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
namespace Elastic.Clients.Elasticsearch.Aggregations
{
	public abstract partial class BucketPathAggregationBase : AggregationBase
	{
		protected BucketPathAggregationBase(string name) : base(name)
		{
		}

		[JsonInclude]
		[JsonPropertyName("buckets_path")]
		public Elastic.Clients.Elasticsearch.Aggregations.BucketsPath? BucketsPath { get; set; }
	}

	public sealed partial class BucketPathAggregationBaseDescriptor : SerializableDescriptorBase<BucketPathAggregationBaseDescriptor>
	{
		internal BucketPathAggregationBaseDescriptor(Action<BucketPathAggregationBaseDescriptor> configure) => configure.Invoke(this);
		public BucketPathAggregationBaseDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.Aggregations.BucketsPath? BucketsPathValue { get; set; }

		private Dictionary<string, object>? MetaValue { get; set; }

		private string? NameValue { get; set; }

		public BucketPathAggregationBaseDescriptor BucketsPath(Elastic.Clients.Elasticsearch.Aggregations.BucketsPath? bucketsPath)
		{
			BucketsPathValue = bucketsPath;
			return Self;
		}

		public BucketPathAggregationBaseDescriptor Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
		{
			MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
			return Self;
		}

		public BucketPathAggregationBaseDescriptor Name(string? name)
		{
			NameValue = name;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (BucketsPathValue is not null)
			{
				writer.WritePropertyName("buckets_path");
				JsonSerializer.Serialize(writer, BucketsPathValue, options);
			}

			if (MetaValue is not null)
			{
				writer.WritePropertyName("meta");
				JsonSerializer.Serialize(writer, MetaValue, options);
			}

			if (!string.IsNullOrEmpty(NameValue))
			{
				writer.WritePropertyName("name");
				writer.WriteStringValue(NameValue);
			}

			writer.WriteEndObject();
		}
	}
}