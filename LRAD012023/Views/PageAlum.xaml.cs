using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LRAD012023.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageAlum : ContentPage
    {
        public PageAlum()
        {
            InitializeComponent();
        }

        private async void btnmostrar_Clicked(object sender, EventArgs e)
        {
            var alum = new Models.Alumno
            {
                nombres = txtnombre.Text,
                apellidos = txtapellidos.Text,
                edad = txtedad.Text,
                correo = txtcorreo.Text
            };


            var page = new Views.PageResultado();
            page.BindingContext= alum;
            await Navigation.PushAsync(page);

        }
    }
}