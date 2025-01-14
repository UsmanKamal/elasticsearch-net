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
namespace Elastic.Clients.Elasticsearch.QueryDsl
{
	public partial class GeoBoundingBoxQuery : QueryBase, IQueryContainerVariant
	{
		[JsonIgnore]
		string IQueryContainerVariant.QueryContainerVariantName => "geo_bounding_box";
		[JsonInclude]
		[JsonPropertyName("ignore_unmapped")]
		public bool? IgnoreUnmapped { get; set; }

		[JsonInclude]
		[JsonPropertyName("validation_method")]
		public Elastic.Clients.Elasticsearch.QueryDsl.GeoValidationMethod? ValidationMethod { get; set; }
	}

	public sealed partial class GeoBoundingBoxQueryDescriptor : SerializableDescriptorBase<GeoBoundingBoxQueryDescriptor>
	{
		internal GeoBoundingBoxQueryDescriptor(Action<GeoBoundingBoxQueryDescriptor> configure) => configure.Invoke(this);
		public GeoBoundingBoxQueryDescriptor() : base()
		{
		}

		private string? QueryNameValue { get; set; }

		private float? BoostValue { get; set; }

		private bool? IgnoreUnmappedValue { get; set; }

		private Elastic.Clients.Elasticsearch.QueryDsl.GeoValidationMethod? ValidationMethodValue { get; set; }

		public GeoBoundingBoxQueryDescriptor QueryName(string? queryName)
		{
			QueryNameValue = queryName;
			return Self;
		}

		public GeoBoundingBoxQueryDescriptor Boost(float? boost)
		{
			BoostValue = boost;
			return Self;
		}

		public GeoBoundingBoxQueryDescriptor IgnoreUnmapped(bool? ignoreUnmapped = true)
		{
			IgnoreUnmappedValue = ignoreUnmapped;
			return Self;
		}

		public GeoBoundingBoxQueryDescriptor ValidationMethod(Elastic.Clients.Elasticsearch.QueryDsl.GeoValidationMethod? validationMethod)
		{
			ValidationMethodValue = validationMethod;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (!string.IsNullOrEmpty(QueryNameValue))
			{
				writer.WritePropertyName("_name");
				writer.WriteStringValue(QueryNameValue);
			}

			if (BoostValue.HasValue)
			{
				writer.WritePropertyName("boost");
				writer.WriteNumberValue(BoostValue.Value);
			}

			if (IgnoreUnmappedValue.HasValue)
			{
				writer.WritePropertyName("ignore_unmapped");
				writer.WriteBooleanValue(IgnoreUnmappedValue.Value);
			}

			if (ValidationMethodValue is not null)
			{
				writer.WritePropertyName("validation_method");
				JsonSerializer.Serialize(writer, ValidationMethodValue, options);
			}

			writer.WriteEndObject();
		}
	}
}