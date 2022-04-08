using AppGallery.XamarinForms.Paginas.PaginaDeCarrossel;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //var pagina = new NavigationPage(
            //    new XamarinForms.Paginas.PaginaDeNavegacao.Page1()
            //);
            // MainPage = new XamarinForms.Paginas.Modal.Page1();

            //var pagina = new CarouselPage();
            //pagina.Children.Add(new Page1());
            //pagina.Children.Add(new Page2());
            //pagina.Children.Add(new Page3());

            //pagina.CurrentPage = pagina.Children[1];

            MainPage = new AppBase.Menu();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
