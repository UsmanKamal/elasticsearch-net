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
namespace Elastic.Clients.Elasticsearch.Xpack
{
	public partial class MlInferenceTrainedModelsCount
	{
		[JsonInclude]
		[JsonPropertyName("classification")]
		public long? Classification { get; init; }

		[JsonInclude]
		[JsonPropertyName("ner")]
		public long? Ner { get; init; }

		[JsonInclude]
		[JsonPropertyName("other")]
		public long Other { get; init; }

		[JsonInclude]
		[JsonPropertyName("prepackaged")]
		public long Prepackaged { get; init; }

		[JsonInclude]
		[JsonPropertyName("regression")]
		public long? Regression { get; init; }

		[JsonInclude]
		[JsonPropertyName("total")]
		public long Total { get; init; }
	}
}