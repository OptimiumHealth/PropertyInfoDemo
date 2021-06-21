using Microsoft.AspNetCore.Components;

using PropertyInfoDemo.Data;

namespace PropertyInfoDemo.Components
{
    public partial class PIRazorComponent<TViewModel>
    {
        [Parameter] public System.Reflection.PropertyInfo pPropertyAsParameter { get; set; }
        [Parameter] public TViewModel pViewModel { get; set; }
    }
}
