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
	public partial class MlDataFrameAnalyticsJobs
	{
		[JsonInclude]
		[JsonPropertyName("_all")]
		public Elastic.Clients.Elasticsearch.Xpack.MlDataFrameAnalyticsJobsCount All { get; init; }

		[JsonInclude]
		[JsonPropertyName("analysis_counts")]
		public Elastic.Clients.Elasticsearch.Xpack.MlDataFrameAnalyticsJobsAnalysis? AnalysisCounts { get; init; }

		[JsonInclude]
		[JsonPropertyName("memory_usage")]
		public Elastic.Clients.Elasticsearch.Xpack.MlDataFrameAnalyticsJobsMemory? MemoryUsage { get; init; }

		[JsonInclude]
		[JsonPropertyName("stopped")]
		public Elastic.Clients.Elasticsearch.Xpack.MlDataFrameAnalyticsJobsCount? Stopped { get; init; }
	}
}