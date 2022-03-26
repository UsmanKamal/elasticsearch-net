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
namespace Elastic.Clients.Elasticsearch.IndexManagement.UpdateAliases
{
	public partial class AddAction : IActionVariant
	{
		[JsonIgnore]
		string IndexManagement.UpdateAliases.IActionVariant.ActionVariantName => "add";
		[JsonInclude]
		[JsonPropertyName("alias")]
		public Elastic.Clients.Elasticsearch.IndexAlias? Alias { get; set; }

		[JsonInclude]
		[JsonPropertyName("aliases")]
		public IEnumerable<Elastic.Clients.Elasticsearch.IndexAlias>? Aliases { get; set; }

		[JsonInclude]
		[JsonPropertyName("filter")]
		public Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? Filter { get; set; }

		[JsonInclude]
		[JsonPropertyName("index")]
		public Elastic.Clients.Elasticsearch.IndexName? Index { get; set; }

		[JsonInclude]
		[JsonPropertyName("index_routing")]
		public Elastic.Clients.Elasticsearch.Routing? IndexRouting { get; set; }

		[JsonInclude]
		[JsonPropertyName("indices")]
		public Elastic.Clients.Elasticsearch.Indices? Indices { get; set; }

		[JsonInclude]
		[JsonPropertyName("is_hidden")]
		public bool? IsHidden { get; set; }

		[JsonInclude]
		[JsonPropertyName("is_write_index")]
		public bool? IsWriteIndex { get; set; }

		[JsonInclude]
		[JsonPropertyName("must_exist")]
		public bool? MustExist { get; set; }

		[JsonInclude]
		[JsonPropertyName("routing")]
		public Elastic.Clients.Elasticsearch.Routing? Routing { get; set; }

		[JsonInclude]
		[JsonPropertyName("search_routing")]
		public Elastic.Clients.Elasticsearch.Routing? SearchRouting { get; set; }
	}

	public sealed partial class AddActionDescriptor<TDocument> : DescriptorBase<AddActionDescriptor<TDocument>>
	{
		internal AddActionDescriptor(Action<AddActionDescriptor<TDocument>> configure) => configure.Invoke(this);
		public AddActionDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? FilterValue { get; set; }

		private QueryDsl.QueryContainerDescriptor<TDocument> FilterDescriptor { get; set; }

		private Action<QueryDsl.QueryContainerDescriptor<TDocument>> FilterDescriptorAction { get; set; }

		private Elastic.Clients.Elasticsearch.IndexAlias? AliasValue { get; set; }

		private IEnumerable<Elastic.Clients.Elasticsearch.IndexAlias>? AliasesValue { get; set; }

		private Elastic.Clients.Elasticsearch.IndexName? IndexValue { get; set; }

		private Elastic.Clients.Elasticsearch.Routing? IndexRoutingValue { get; set; }

		private Elastic.Clients.Elasticsearch.Indices? IndicesValue { get; set; }

		private bool? IsHiddenValue { get; set; }

		private bool? IsWriteIndexValue { get; set; }

		private bool? MustExistValue { get; set; }

		private Elastic.Clients.Elasticsearch.Routing? RoutingValue { get; set; }

		private Elastic.Clients.Elasticsearch.Routing? SearchRoutingValue { get; set; }

		public AddActionDescriptor<TDocument> Filter(Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? filter)
		{
			FilterDescriptor = null;
			FilterDescriptorAction = null;
			FilterValue = filter;
			return Self;
		}

		public AddActionDescriptor<TDocument> Filter(QueryDsl.QueryContainerDescriptor<TDocument> descriptor)
		{
			FilterValue = null;
			FilterDescriptorAction = null;
			FilterDescriptor = descriptor;
			return Self;
		}

		public AddActionDescriptor<TDocument> Filter(Action<QueryDsl.QueryContainerDescriptor<TDocument>> configure)
		{
			FilterValue = null;
			FilterDescriptorAction = null;
			FilterDescriptorAction = configure;
			return Self;
		}

		public AddActionDescriptor<TDocument> Alias(Elastic.Clients.Elasticsearch.IndexAlias? alias)
		{
			AliasValue = alias;
			return Self;
		}

		public AddActionDescriptor<TDocument> Aliases(IEnumerable<Elastic.Clients.Elasticsearch.IndexAlias>? aliases)
		{
			AliasesValue = aliases;
			return Self;
		}

		public AddActionDescriptor<TDocument> Index(Elastic.Clients.Elasticsearch.IndexName? index)
		{
			IndexValue = index;
			return Self;
		}

		public AddActionDescriptor<TDocument> IndexRouting(Elastic.Clients.Elasticsearch.Routing? indexRouting)
		{
			IndexRoutingValue = indexRouting;
			return Self;
		}

		public AddActionDescriptor<TDocument> Indices(Elastic.Clients.Elasticsearch.Indices? indices)
		{
			IndicesValue = indices;
			return Self;
		}

		public AddActionDescriptor<TDocument> IsHidden(bool? isHidden = true)
		{
			IsHiddenValue = isHidden;
			return Self;
		}

		public AddActionDescriptor<TDocument> IsWriteIndex(bool? isWriteIndex = true)
		{
			IsWriteIndexValue = isWriteIndex;
			return Self;
		}

		public AddActionDescriptor<TDocument> MustExist(bool? mustExist = true)
		{
			MustExistValue = mustExist;
			return Self;
		}

		public AddActionDescriptor<TDocument> Routing(Elastic.Clients.Elasticsearch.Routing? routing)
		{
			RoutingValue = routing;
			return Self;
		}

		public AddActionDescriptor<TDocument> SearchRouting(Elastic.Clients.Elasticsearch.Routing? searchRouting)
		{
			SearchRoutingValue = searchRouting;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (FilterDescriptor is not null)
			{
				writer.WritePropertyName("filter");
				JsonSerializer.Serialize(writer, FilterDescriptor, options);
			}
			else if (FilterDescriptorAction is not null)
			{
				writer.WritePropertyName("filter");
				JsonSerializer.Serialize(writer, new QueryDsl.QueryContainerDescriptor<TDocument>(FilterDescriptorAction), options);
			}
			else if (FilterValue is not null)
			{
				writer.WritePropertyName("filter");
				JsonSerializer.Serialize(writer, FilterValue, options);
			}

			if (AliasValue is not null)
			{
				writer.WritePropertyName("alias");
				JsonSerializer.Serialize(writer, AliasValue, options);
			}

			if (AliasesValue is not null)
			{
				writer.WritePropertyName("aliases");
				JsonSerializer.Serialize(writer, AliasesValue, options);
			}

			if (IndexValue is not null)
			{
				writer.WritePropertyName("index");
				JsonSerializer.Serialize(writer, IndexValue, options);
			}

			if (IndexRoutingValue is not null)
			{
				writer.WritePropertyName("index_routing");
				JsonSerializer.Serialize(writer, IndexRoutingValue, options);
			}

			if (IndicesValue is not null)
			{
				writer.WritePropertyName("indices");
				JsonSerializer.Serialize(writer, IndicesValue, options);
			}

			if (IsHiddenValue.HasValue)
			{
				writer.WritePropertyName("is_hidden");
				writer.WriteBooleanValue(IsHiddenValue.Value);
			}

			if (IsWriteIndexValue.HasValue)
			{
				writer.WritePropertyName("is_write_index");
				writer.WriteBooleanValue(IsWriteIndexValue.Value);
			}

			if (MustExistValue.HasValue)
			{
				writer.WritePropertyName("must_exist");
				writer.WriteBooleanValue(MustExistValue.Value);
			}

			if (RoutingValue is not null)
			{
				writer.WritePropertyName("routing");
				JsonSerializer.Serialize(writer, RoutingValue, options);
			}

			if (SearchRoutingValue is not null)
			{
				writer.WritePropertyName("search_routing");
				JsonSerializer.Serialize(writer, SearchRoutingValue, options);
			}

			writer.WriteEndObject();
		}
	}

	public sealed partial class AddActionDescriptor : DescriptorBase<AddActionDescriptor>
	{
		internal AddActionDescriptor(Action<AddActionDescriptor> configure) => configure.Invoke(this);
		public AddActionDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? FilterValue { get; set; }

		private QueryDsl.QueryContainerDescriptor FilterDescriptor { get; set; }

		private Action<QueryDsl.QueryContainerDescriptor> FilterDescriptorAction { get; set; }

		private Elastic.Clients.Elasticsearch.IndexAlias? AliasValue { get; set; }

		private IEnumerable<Elastic.Clients.Elasticsearch.IndexAlias>? AliasesValue { get; set; }

		private Elastic.Clients.Elasticsearch.IndexName? IndexValue { get; set; }

		private Elastic.Clients.Elasticsearch.Routing? IndexRoutingValue { get; set; }

		private Elastic.Clients.Elasticsearch.Indices? IndicesValue { get; set; }

		private bool? IsHiddenValue { get; set; }

		private bool? IsWriteIndexValue { get; set; }

		private bool? MustExistValue { get; set; }

		private Elastic.Clients.Elasticsearch.Routing? RoutingValue { get; set; }

		private Elastic.Clients.Elasticsearch.Routing? SearchRoutingValue { get; set; }

		public AddActionDescriptor Filter(Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? filter)
		{
			FilterDescriptor = null;
			FilterDescriptorAction = null;
			FilterValue = filter;
			return Self;
		}

		public AddActionDescriptor Filter(QueryDsl.QueryContainerDescriptor descriptor)
		{
			FilterValue = null;
			FilterDescriptorAction = null;
			FilterDescriptor = descriptor;
			return Self;
		}

		public AddActionDescriptor Filter(Action<QueryDsl.QueryContainerDescriptor> configure)
		{
			FilterValue = null;
			FilterDescriptorAction = null;
			FilterDescriptorAction = configure;
			return Self;
		}

		public AddActionDescriptor Alias(Elastic.Clients.Elasticsearch.IndexAlias? alias)
		{
			AliasValue = alias;
			return Self;
		}

		public AddActionDescriptor Aliases(IEnumerable<Elastic.Clients.Elasticsearch.IndexAlias>? aliases)
		{
			AliasesValue = aliases;
			return Self;
		}

		public AddActionDescriptor Index(Elastic.Clients.Elasticsearch.IndexName? index)
		{
			IndexValue = index;
			return Self;
		}

		public AddActionDescriptor IndexRouting(Elastic.Clients.Elasticsearch.Routing? indexRouting)
		{
			IndexRoutingValue = indexRouting;
			return Self;
		}

		public AddActionDescriptor Indices(Elastic.Clients.Elasticsearch.Indices? indices)
		{
			IndicesValue = indices;
			return Self;
		}

		public AddActionDescriptor IsHidden(bool? isHidden = true)
		{
			IsHiddenValue = isHidden;
			return Self;
		}

		public AddActionDescriptor IsWriteIndex(bool? isWriteIndex = true)
		{
			IsWriteIndexValue = isWriteIndex;
			return Self;
		}

		public AddActionDescriptor MustExist(bool? mustExist = true)
		{
			MustExistValue = mustExist;
			return Self;
		}

		public AddActionDescriptor Routing(Elastic.Clients.Elasticsearch.Routing? routing)
		{
			RoutingValue = routing;
			return Self;
		}

		public AddActionDescriptor SearchRouting(Elastic.Clients.Elasticsearch.Routing? searchRouting)
		{
			SearchRoutingValue = searchRouting;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (FilterDescriptor is not null)
			{
				writer.WritePropertyName("filter");
				JsonSerializer.Serialize(writer, FilterDescriptor, options);
			}
			else if (FilterDescriptorAction is not null)
			{
				writer.WritePropertyName("filter");
				JsonSerializer.Serialize(writer, new QueryDsl.QueryContainerDescriptor(FilterDescriptorAction), options);
			}
			else if (FilterValue is not null)
			{
				writer.WritePropertyName("filter");
				JsonSerializer.Serialize(writer, FilterValue, options);
			}

			if (AliasValue is not null)
			{
				writer.WritePropertyName("alias");
				JsonSerializer.Serialize(writer, AliasValue, options);
			}

			if (AliasesValue is not null)
			{
				writer.WritePropertyName("aliases");
				JsonSerializer.Serialize(writer, AliasesValue, options);
			}

			if (IndexValue is not null)
			{
				writer.WritePropertyName("index");
				JsonSerializer.Serialize(writer, IndexValue, options);
			}

			if (IndexRoutingValue is not null)
			{
				writer.WritePropertyName("index_routing");
				JsonSerializer.Serialize(writer, IndexRoutingValue, options);
			}

			if (IndicesValue is not null)
			{
				writer.WritePropertyName("indices");
				JsonSerializer.Serialize(writer, IndicesValue, options);
			}

			if (IsHiddenValue.HasValue)
			{
				writer.WritePropertyName("is_hidden");
				writer.WriteBooleanValue(IsHiddenValue.Value);
			}

			if (IsWriteIndexValue.HasValue)
			{
				writer.WritePropertyName("is_write_index");
				writer.WriteBooleanValue(IsWriteIndexValue.Value);
			}

			if (MustExistValue.HasValue)
			{
				writer.WritePropertyName("must_exist");
				writer.WriteBooleanValue(MustExistValue.Value);
			}

			if (RoutingValue is not null)
			{
				writer.WritePropertyName("routing");
				JsonSerializer.Serialize(writer, RoutingValue, options);
			}

			if (SearchRoutingValue is not null)
			{
				writer.WritePropertyName("search_routing");
				JsonSerializer.Serialize(writer, SearchRoutingValue, options);
			}

			writer.WriteEndObject();
		}
	}
}