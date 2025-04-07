using TempoAgora.Models;
using TempoAgora.Services;

namespace TempoAgora
{
    public partial class MainPage : ContentPage
    {

        Tempo lst_Legal;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void btn_previsao_Clicked(object sender, EventArgs e)
        {
            try
            {

                if (!string.IsNullOrEmpty(ent_cidade.Text))
                {

                    Tempo? t = await DataService.GetWeather(ent_cidade.Text);

                    if (t != null)
                    {

                        lst_Legal = t;
                        BindingContext = lst_Legal;

                        return;

                    }



                }

            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro!", ex.Message, "OK!");
            }
        }
    }

}