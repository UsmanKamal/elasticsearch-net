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
using System.Threading;
using System.Threading.Tasks;

#nullable restore
namespace Nest.License
{
	public class LicenseNamespace : NamespacedClientProxy
	{
		internal LicenseNamespace(ElasticClient client) : base(client)
		{
		}

		public DeleteResponse Delete(IDeleteRequest request)
		{
			return DoRequest<IDeleteRequest, DeleteResponse>(request, request.RequestParameters);
		}

		public Task<DeleteResponse> DeleteAsync(IDeleteRequest request, CancellationToken cancellationToken = default)
		{
			return DoRequestAsync<IDeleteRequest, DeleteResponse>(request, request.RequestParameters, cancellationToken);
		}

		public DeleteResponse Delete(Func<DeleteDescriptor, IDeleteRequest> selector = null)
		{
			return Delete(selector.InvokeOrDefault(new DeleteDescriptor()));
		}

		public Task<DeleteResponse> DeleteAsync(Func<DeleteDescriptor, IDeleteRequest> selector = null, CancellationToken cancellationToken = default)
		{
			return DeleteAsync(selector.InvokeOrDefault(new DeleteDescriptor()), cancellationToken);
		}

		public GetResponse Get(IGetRequest request)
		{
			return DoRequest<IGetRequest, GetResponse>(request, request.RequestParameters);
		}

		public Task<GetResponse> GetAsync(IGetRequest request, CancellationToken cancellationToken = default)
		{
			return DoRequestAsync<IGetRequest, GetResponse>(request, request.RequestParameters, cancellationToken);
		}

		public GetResponse Get(Func<GetDescriptor, IGetRequest> selector = null)
		{
			return Get(selector.InvokeOrDefault(new GetDescriptor()));
		}

		public Task<GetResponse> GetAsync(Func<GetDescriptor, IGetRequest> selector = null, CancellationToken cancellationToken = default)
		{
			return GetAsync(selector.InvokeOrDefault(new GetDescriptor()), cancellationToken);
		}

		public GetBasicStatusResponse GetBasicStatus(IGetBasicStatusRequest request)
		{
			return DoRequest<IGetBasicStatusRequest, GetBasicStatusResponse>(request, request.RequestParameters);
		}

		public Task<GetBasicStatusResponse> GetBasicStatusAsync(IGetBasicStatusRequest request, CancellationToken cancellationToken = default)
		{
			return DoRequestAsync<IGetBasicStatusRequest, GetBasicStatusResponse>(request, request.RequestParameters, cancellationToken);
		}

		public GetBasicStatusResponse GetBasicStatus(Func<GetBasicStatusDescriptor, IGetBasicStatusRequest> selector = null)
		{
			return GetBasicStatus(selector.InvokeOrDefault(new GetBasicStatusDescriptor()));
		}

		public Task<GetBasicStatusResponse> GetBasicStatusAsync(Func<GetBasicStatusDescriptor, IGetBasicStatusRequest> selector = null, CancellationToken cancellationToken = default)
		{
			return GetBasicStatusAsync(selector.InvokeOrDefault(new GetBasicStatusDescriptor()), cancellationToken);
		}

		public GetTrialStatusResponse GetTrialStatus(IGetTrialStatusRequest request)
		{
			return DoRequest<IGetTrialStatusRequest, GetTrialStatusResponse>(request, request.RequestParameters);
		}

		public Task<GetTrialStatusResponse> GetTrialStatusAsync(IGetTrialStatusRequest request, CancellationToken cancellationToken = default)
		{
			return DoRequestAsync<IGetTrialStatusRequest, GetTrialStatusResponse>(request, request.RequestParameters, cancellationToken);
		}

		public GetTrialStatusResponse GetTrialStatus(Func<GetTrialStatusDescriptor, IGetTrialStatusRequest> selector = null)
		{
			return GetTrialStatus(selector.InvokeOrDefault(new GetTrialStatusDescriptor()));
		}

		public Task<GetTrialStatusResponse> GetTrialStatusAsync(Func<GetTrialStatusDescriptor, IGetTrialStatusRequest> selector = null, CancellationToken cancellationToken = default)
		{
			return GetTrialStatusAsync(selector.InvokeOrDefault(new GetTrialStatusDescriptor()), cancellationToken);
		}

		public PostResponse Post(IPostRequest request)
		{
			return DoRequest<IPostRequest, PostResponse>(request, request.RequestParameters);
		}

		public Task<PostResponse> PostAsync(IPostRequest request, CancellationToken cancellationToken = default)
		{
			return DoRequestAsync<IPostRequest, PostResponse>(request, request.RequestParameters, cancellationToken);
		}

		public PostResponse Post(Func<PostDescriptor, IPostRequest> selector = null)
		{
			return Post(selector.InvokeOrDefault(new PostDescriptor()));
		}

		public Task<PostResponse> PostAsync(Func<PostDescriptor, IPostRequest> selector = null, CancellationToken cancellationToken = default)
		{
			return PostAsync(selector.InvokeOrDefault(new PostDescriptor()), cancellationToken);
		}

		public PostStartBasicResponse PostStartBasic(IPostStartBasicRequest request)
		{
			return DoRequest<IPostStartBasicRequest, PostStartBasicResponse>(request, request.RequestParameters);
		}

		public Task<PostStartBasicResponse> PostStartBasicAsync(IPostStartBasicRequest request, CancellationToken cancellationToken = default)
		{
			return DoRequestAsync<IPostStartBasicRequest, PostStartBasicResponse>(request, request.RequestParameters, cancellationToken);
		}

		public PostStartBasicResponse PostStartBasic(Func<PostStartBasicDescriptor, IPostStartBasicRequest> selector = null)
		{
			return PostStartBasic(selector.InvokeOrDefault(new PostStartBasicDescriptor()));
		}

		public Task<PostStartBasicResponse> PostStartBasicAsync(Func<PostStartBasicDescriptor, IPostStartBasicRequest> selector = null, CancellationToken cancellationToken = default)
		{
			return PostStartBasicAsync(selector.InvokeOrDefault(new PostStartBasicDescriptor()), cancellationToken);
		}

		public PostStartTrialResponse PostStartTrial(IPostStartTrialRequest request)
		{
			return DoRequest<IPostStartTrialRequest, PostStartTrialResponse>(request, request.RequestParameters);
		}

		public Task<PostStartTrialResponse> PostStartTrialAsync(IPostStartTrialRequest request, CancellationToken cancellationToken = default)
		{
			return DoRequestAsync<IPostStartTrialRequest, PostStartTrialResponse>(request, request.RequestParameters, cancellationToken);
		}

		public PostStartTrialResponse PostStartTrial(Func<PostStartTrialDescriptor, IPostStartTrialRequest> selector = null)
		{
			return PostStartTrial(selector.InvokeOrDefault(new PostStartTrialDescriptor()));
		}

		public Task<PostStartTrialResponse> PostStartTrialAsync(Func<PostStartTrialDescriptor, IPostStartTrialRequest> selector = null, CancellationToken cancellationToken = default)
		{
			return PostStartTrialAsync(selector.InvokeOrDefault(new PostStartTrialDescriptor()), cancellationToken);
		}
	}
}