namespace MauiAppMinhasCompras.Views;
using MauiAppMinhasCompras.Models;

public partial class RelatorioPeriodo : ContentPage
{
    public RelatorioPeriodo()
    {
        InitializeComponent();
    }

    private async void OnFiltrarClicked(object sender, EventArgs e)
    {
        DateTime dataInicial = dpInicio.Date;
        DateTime dataFinal = dpFim.Date;

        var produtosFiltrados = await App.Db.GetProdutosPorPeriodo(dataInicial, dataFinal);
        lvRelatorio.ItemsSource = produtosFiltrados;
    }
}