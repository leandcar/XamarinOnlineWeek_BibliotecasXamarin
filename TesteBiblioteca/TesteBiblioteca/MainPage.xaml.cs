using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TesteBiblioteca
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnObterVersao_Clicked(object sender, EventArgs e)
        {
            lblVersao.Text = BibliotecaXamarinWeek.Metodos.ObterVersaoSistemaOperacional();
        }
    }
}
