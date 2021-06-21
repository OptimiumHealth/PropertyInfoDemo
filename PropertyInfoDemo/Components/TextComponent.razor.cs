using Microsoft.AspNetCore.Components;

namespace PropertyInfoDemo.Components
{
    public partial class TextComponent
    {
        [Parameter] public string pLabel { get; set; }
        [Parameter] public string pValue { get; set; }
    }
}
