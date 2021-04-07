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

using Elastic.Transport;

#nullable restore
namespace Nest
{
	public class DeleteIndexDescriptor : RequestDescriptorBase<DeleteIndexDescriptor, DeleteIndexRequestParameters, IDeleteIndexRequest>, IDeleteIndexRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndicesDelete;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
	}

	public class IndexTemplateExistsDescriptor : RequestDescriptorBase<IndexTemplateExistsDescriptor, IndexTemplateExistsRequestParameters, IIndexTemplateExistsRequest>, IIndexTemplateExistsRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndicesExistsTemplate;
		protected override HttpMethod HttpMethod => HttpMethod.HEAD;
		protected override bool SupportsBody => false;
	}
}