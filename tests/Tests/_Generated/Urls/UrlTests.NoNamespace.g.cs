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
// TODO - RUN INSTRUCTIONS
//
// ------------------------------------------------
using Elastic.Elasticsearch.Xunit.XunitPlumbing;
using Nest;
using System.Threading.Tasks;
using Tests.Domain;
using Tests.Framework.EndpointTests;

namespace Tests.Urls.NoNamespace
{
    public class ClosePointInTimeUrlTests : UrlTestsBase
    {
        [U]
        public override async Task Urls()
        {
            await UrlTester.DELETE("/_pit").Request(c => c.ClosePointInTime(new ClosePointInTimeRequest())).RequestAsync(c => c.ClosePointInTimeAsync(new ClosePointInTimeRequest()));
        }
    }

    public class OpenPointInTimeUrlTests : UrlTestsBase
    {
        [U]
        public override async Task Urls()
        {
            await UrlTester.POST("/_pit").Request(c => c.OpenPointInTime(new OpenPointInTimeRequest())).RequestAsync(c => c.OpenPointInTimeAsync(new OpenPointInTimeRequest()));
            await UrlTester.POST("/_all/_pit").Request(c => c.OpenPointInTime(new OpenPointInTimeRequest(Nest.Indices.All))).RequestAsync(c => c.OpenPointInTimeAsync(new OpenPointInTimeRequest(Nest.Indices.All)));
            await UrlTester.POST("/project/_pit").Request(c => c.OpenPointInTime(new OpenPointInTimeRequest(Nest.IndexName.From<Project>()))).RequestAsync(c => c.OpenPointInTimeAsync(new OpenPointInTimeRequest(Nest.IndexName.From<Project>())));
        }
    }

    public class PingUrlTests : UrlTestsBase
    {
        [U]
        public override async Task Urls()
        {
            await UrlTester.HEAD("/").Request(c => c.Ping(new PingRequest())).RequestAsync(c => c.PingAsync(new PingRequest()));
        }
    }
}