using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.OpenWhatsApp;

namespace EnviaMensajeWhastApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtmensaje.Text))
                {
                    string CodigoPaisCelular;
                    CodigoPaisCelular = "+529512267176";
                    Chat.Open(CodigoPaisCelular, txtmensaje.Text);
                }
            }
            catch (Exception ex)
            {

                DisplayAlert("Alerta", ex.Message, "OK");
            }
        }
    }
}
