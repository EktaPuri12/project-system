﻿// Licensed to the .NET Foundation under one or more agreements. The .NET Foundation licenses this file to you under the MIT license. See the LICENSE.md file in the project root for more information.

namespace Microsoft.VisualStudio.ProjectSystem.LanguageServices;

/// <summary>
/// Groups data related to build updates into a single object.
/// </summary>
internal sealed class BuildUpdate
{
    public BuildUpdate(ConfiguredProject configuredProject, IProjectSubscriptionUpdate buildRuleUpdate, CommandLineArgumentsSnapshot commandLineArgumentsSnapshot)
    {
        Requires.NotNull(configuredProject, nameof(configuredProject));
        Requires.NotNull(buildRuleUpdate, nameof(buildRuleUpdate));
        Requires.NotNull(commandLineArgumentsSnapshot, nameof(commandLineArgumentsSnapshot));

        ConfiguredProject = configuredProject;
        BuildRuleUpdate = buildRuleUpdate;
        CommandLineArgumentsSnapshot = commandLineArgumentsSnapshot;
    }

    /// <summary>
    /// Gets the <see cref="ConfiguredProject"/> currently bound to the workspace's project slice.
    /// </summary>
    /// <remarks>
    /// This value may change over time.
    /// For example, it changes when switching between Debug and Release configurations.
    /// </remarks>
    public ConfiguredProject ConfiguredProject { get; }

    public IProjectSubscriptionUpdate BuildRuleUpdate { get; }

    public CommandLineArgumentsSnapshot CommandLineArgumentsSnapshot { get; }
}
