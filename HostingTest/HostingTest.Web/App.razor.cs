using Avalonia.Web.Blazor;

namespace HostingTest.Web
{
    public partial class App
    {
        protected override void OnParametersSet()
        {
            base.OnParametersSet();

            WebAppBuilder.Configure<HostingTest.App>()
                .SetupWithSingleViewLifetime();
        }
    }
}