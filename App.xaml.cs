using Maui28414.IssueRepro;

namespace Maui28414
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new NavigationPage(new FirstPage()));
        }
    }
}