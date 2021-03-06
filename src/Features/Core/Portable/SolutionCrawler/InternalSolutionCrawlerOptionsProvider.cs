﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Composition;
using Microsoft.CodeAnalysis.Options;
using Microsoft.CodeAnalysis.Options.Providers;

namespace Microsoft.CodeAnalysis.SolutionCrawler
{
    [ExportOptionProvider, Shared]
    internal class InternalSolutionCrawlerOptionsProvider : IOptionProvider
    {
        [ImportingConstructor]
        public InternalSolutionCrawlerOptionsProvider()
        {
        }

        public ImmutableArray<IOption> Options { get; } = ImmutableArray.Create<IOption>(
            InternalSolutionCrawlerOptions.SolutionCrawler,
            InternalSolutionCrawlerOptions.ActiveFileWorkerBackOffTimeSpanInMS,
            InternalSolutionCrawlerOptions.AllFilesWorkerBackOffTimeSpanInMS,
            InternalSolutionCrawlerOptions.EntireProjectWorkerBackOffTimeSpanInMS,
            InternalSolutionCrawlerOptions.SemanticChangeBackOffTimeSpanInMS,
            InternalSolutionCrawlerOptions.ProjectPropagationBackOffTimeSpanInMS,
            InternalSolutionCrawlerOptions.PreviewBackOffTimeSpanInMS);
    }
}
