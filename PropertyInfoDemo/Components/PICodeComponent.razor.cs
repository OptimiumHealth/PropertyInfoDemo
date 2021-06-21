
using Microsoft.AspNetCore.Components;

using PropertyInfoDemo.Data;

namespace PropertyInfoDemo.Components
{
    public partial class PICodeComponent<TViewModel>
    {
        [Parameter] public System.Reflection.PropertyInfo pPropertyAsParameter { get; set; }
        [Parameter] public TViewModel pViewModel { get; set; }

        private string pSomeComponentValue { get; set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();

            pSomeComponentValue = (string)pPropertyAsParameter.GetValue(pViewModel);
        }
    }
}
