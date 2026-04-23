using CurrentAccountBalance_Mark1.Views;
using Microsoft.Extensions.DependencyInjection;

namespace CurrentAccountBalance_Mark1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new ListaDivida());
        }
        /*
        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());

        }
        */
    }
}