namespace MauiAppHotel.Views;

public partial class HospedagemContratada : ContentPage
{
    public HospedagemContratada(int adultos, int criancas, string suite, int dias)
    {
        InitializeComponent();

        double valor = 150;

        if (suite == "Luxo")
            valor = 250;
        else if (suite == "Master")
            valor = 400;

        double total = ((adultos * valor) + (criancas * 75)) * dias;

        lblAdultos.Text = "Adultos: " + adultos;
        lblCriancas.Text = "Crianças: " + criancas;
        lblSuite.Text = "Suíte: " + suite;
        lblDias.Text = "Dias: " + dias;
        lblTotal.Text = "Total: R$ " + total.ToString("F2");
    }

    private async void Voltar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}