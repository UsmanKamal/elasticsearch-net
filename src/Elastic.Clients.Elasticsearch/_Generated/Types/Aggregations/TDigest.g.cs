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
	public partial class TDigest
	{
		[JsonInclude]
		[JsonPropertyName("compression")]
		public int? Compression { get; set; }
	}

	public sealed partial class TDigestDescriptor : DescriptorBase<TDigestDescriptor>
	{
		public TDigestDescriptor()
		{
		}

		internal TDigestDescriptor(Action<TDigestDescriptor> configure) => configure.Invoke(this);
		internal int? CompressionValue { get; private set; }

		public TDigestDescriptor Compression(int? compression) => Assign(compression, (a, v) => a.CompressionValue = v);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (CompressionValue.HasValue)
			{
				writer.WritePropertyName("compression");
				writer.WriteNumberValue(CompressionValue.Value);
			}

			writer.WriteEndObject();
		}
	}
}