using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.AppBase
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : FlyoutPage
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void AbrirContentPage(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new XamarinForms.Paginas.PaginaDeConteudo.Page1();
            ((FlyoutPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirNavigationPage(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Paginas.PaginaDeNavegacao.Page1());
            ((FlyoutPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirCarouselPage(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new XamarinForms.Paginas.PaginaDeCarrossel.CarrosselPage();
            ((FlyoutPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirTabbedPage(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new XamarinForms.Paginas.PaginaDeAbas.Abas();
            ((FlyoutPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirMasterDetailPage(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new XamarinForms.Paginas.PaginaMenuLateral.MenuLateral();
            ((FlyoutPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirModal(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new XamarinForms.Paginas.Modal.Page1();
            ((FlyoutPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirPilha(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new XamarinForms.Leiautes.PilhaLeiaute.Pilha();
            ((FlyoutPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirGrid(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new XamarinForms.Leiautes.GradeLeiaute.Grade();
            ((FlyoutPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirAbsolute(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new XamarinForms.Leiautes.AbsolutoLeiaute.Absoluto();
            ((FlyoutPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirFlexLayout(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new XamarinForms.Leiautes.FlexivelLeiaute.Flexivel();
            ((FlyoutPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirScrollView(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new XamarinForms.Leiautes.BarraDeRolagemLeiaute.BarraDeRolagem();
            ((FlyoutPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirContentView(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new XamarinForms.Leiautes.ControleLeiaute.Controle();
            ((FlyoutPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirFrame(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new XamarinForms.Leiautes.QuadradoLeiaute.Quadrado();
            ((FlyoutPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirBoxView(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new XamarinForms.Controles.CaixaControle.Caixa();
            ((FlyoutPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirLabel(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new XamarinForms.Controles.RotuloControler.Rotulo();
            ((FlyoutPage)App.Current.MainPage).IsPresented = false;
        }
    }
}