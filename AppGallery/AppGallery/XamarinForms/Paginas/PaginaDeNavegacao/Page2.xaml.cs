using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Paginas.PaginaDeNavegacao
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void VoltarPaginaAnterior(object sender, EventArgs e)
        {
            Navigation.PopAsync();  
        }
        private void AbrirPagina03(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page3());
        }
    }
}