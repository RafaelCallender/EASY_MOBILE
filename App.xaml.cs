using Microsoft.Extensions.DependencyInjection;

namespace EASYPROJECT01.EASY_MOBILE
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}