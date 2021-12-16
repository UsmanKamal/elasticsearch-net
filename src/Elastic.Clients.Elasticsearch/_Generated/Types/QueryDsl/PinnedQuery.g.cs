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
	public interface IPinnedQueryVariant
	{
		string PinnedQueryVariantName { get; }
	}

	[JsonConverter(typeof(PinnedQueryConverter))]
	public partial class PinnedQuery : QueryDsl.QueryBase, IContainer, IQueryContainerVariant
	{
		public PinnedQuery(IPinnedQueryVariant variant) => Variant = variant ?? throw new ArgumentNullException(nameof(variant));
		internal IPinnedQueryVariant Variant { get; }

		[JsonIgnore]
		string QueryDsl.IQueryContainerVariant.QueryContainerVariantName => "pinned";
		[JsonInclude]
		[JsonPropertyName("organic")]
		public Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer Organic { get; set; }
	}

	internal sealed class PinnedQueryConverter : JsonConverter<PinnedQuery>
	{
		public override PinnedQuery Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var readerCopy = reader;
			readerCopy.Read();
			if (readerCopy.TokenType != JsonTokenType.PropertyName)
			{
				throw new JsonException();
			}

			var propertyName = readerCopy.GetString();
			throw new JsonException();
		}

		public override void Write(Utf8JsonWriter writer, PinnedQuery value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			writer.WritePropertyName(value.Variant.PinnedQueryVariantName);
			writer.WriteEndObject();
		}
	}

	public sealed partial class PinnedQueryDescriptor<T> : DescriptorBase<PinnedQueryDescriptor<T>>
	{
		public PinnedQueryDescriptor()
		{
		}

		internal PinnedQueryDescriptor(Action<PinnedQueryDescriptor<T>> configure) => configure.Invoke(this);
		internal bool ContainsVariant { get; private set; }

		internal string ContainedVariantName { get; private set; }

		internal PinnedQuery Container { get; private set; }

		internal object ContainerVariantDescriptorAction { get; private set; }

		private void Set(object descriptorAction, string variantName)
		{
			if (ContainsVariant)
				throw new Exception("TODO");
			ContainerVariantDescriptorAction = descriptorAction;
			ContainedVariantName = variantName;
			ContainsVariant = true;
		}

		private void Set(IPinnedQueryVariant variant, string variantName)
		{
			if (ContainsVariant)
				throw new Exception("TODO");
			Container = new PinnedQuery(variant);
			ContainedVariantName = variantName;
			ContainsVariant = true;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			if (!ContainsVariant)
			{
				writer.WriteNullValue();
				return;
			}

			if (Container is not null)
			{
				JsonSerializer.Serialize(writer, Container, options);
				return;
			}

			writer.WriteStartObject();
			writer.WritePropertyName(ContainedVariantName);
			writer.WriteStartObject();
			writer.WriteEndObject();
			writer.WriteEndObject();
		}
	}
}