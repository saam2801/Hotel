
namespace Hotel
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
        }
        protected override Window CreateWindow(IActivationState? activationState)
        {
            //criação da window com propriedades de altura e largura modificadas (sobrescrevidas)
            var window = base.CreateWindow(activationState);
            window.Height = 600;
            window.Width = 400;

            return window;
        }
    }
}
