using Microsoft.Extensions.DependencyInjection;
using MauiAppCadastroEventos.Views;

namespace MauiAppCadastroEventos
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new NavigationPage(new HomePage()));
        }
    }
}