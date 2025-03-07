using Fantasy.Shared.Resources;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;

namespace Fantasy.Frontend.Shared;

public partial class FilterComponent
{
    [Inject] public IStringLocalizer<Resource> Localizer { get; set; } = null!;

    [Parameter] public string FilterValue { get; set; } = string.Empty;
    [Parameter] public EventCallback<string> ApplyFilter { get; set; }

    private async Task ClearFilter()
    {
        FilterValue = string.Empty;
        await ApplyFilter.InvokeAsync(FilterValue);
    }

    private async Task OnfilterApply()
    {
        await ApplyFilter.InvokeAsync(FilterValue);
    }
}