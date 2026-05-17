namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
    public ContratacaoHospedagem()
    {
        InitializeComponent();
        pckSuite.SelectedIndex = 0;
    }

    private async void Contratar_Clicked(object sender, EventArgs e)
    {
        int adultos = Convert.ToInt32(txtAdultos.Text);
        int criancas = Convert.ToInt32(txtCriancas.Text);

        string suite = pckSuite.SelectedItem.ToString();

        TimeSpan? periodo = dtSaida.Date - dtChegada.Date;
        int dias = periodo.Value.Days;

        await Navigation.PushAsync(
            new HospedagemContratada(adultos, criancas, suite, dias)
        );
    }

    private async void Sobre_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Sobre());
    }
}