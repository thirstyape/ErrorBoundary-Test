using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace BlazorApp1.Shared;

/// <summary>
/// Generates a tab control header from the provided dictionary and highlights the currently active tab
/// </summary>
public partial class TabBar
{
    #region Properties

    /// <summary>
    /// Use to indicate which tab is currently active
    /// </summary>
    /// <remarks>
    /// Matches the corresponding key in <see cref="Tabs"/>
    /// </remarks>
    [Parameter]
    public string? Active { get; set; }

    /// <summary>
    /// A collection containing tab display names and icons &lt;display name, icon&gt;
    /// </summary>
    public Dictionary<string, string> Tabs { get; set; } = new();

    /// <summary>
    /// HTML content to include within the component
    /// </summary>
    /// <remarks>
    /// Add <see cref="Tab"/> items here
    /// </remarks>
    [Parameter]
    public RenderFragment ChildContent { get; set; }

    #endregion

    #region Methods

    private void OnTabBarChanged(string tab)
    {
        Active = tab;
        StateHasChanged();
    }

    private string? GetClass(string tab)
    {
        return Active == tab ? "is-active" : null;
    }

    #endregion
}
