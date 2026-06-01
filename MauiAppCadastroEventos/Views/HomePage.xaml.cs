namespace MauiAppCadastroEventos.Views;

using MauiAppCadastroEventos.Models;
using Microsoft.Maui.Controls;

public partial class HomePage : ContentPage
{
    
    public HomePage()
	{
		InitializeComponent();

		DatePicker_checkin.Date = DateTime.Now;
		DatePicker_checkin.MinimumDate = DateTime.Now;
		DatePicker_checkin.MaximumDate = DateTime.Today.AddMonths(6);

		DatePicker_checkout.MinimumDate = DatePicker_checkin.Date.Value.AddDays(1);
		DatePicker_checkout.MaximumDate = DatePicker_checkin.Date.Value.AddDays(7);
	}

    private void DatePicker_checkin_DateSelected(object sender, DateChangedEventArgs e)
    {
		try
		{
			DatePicker elemento = sender as DatePicker;

			DateTime? Checkin_dataSelecionada = elemento.Date;

			DatePicker_checkout.MinimumDate = Checkin_dataSelecionada.Value.AddDays(1);
			DatePicker_checkout.MaximumDate = Checkin_dataSelecionada.Value.AddDays(7);

		} catch (Exception ex)
		{
			DisplayAlertAsync("Erro", ex.Message, "Ok");
		}



    }

    private void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			Evento evento = new Evento
			{
				NomeEvento = txt_NomeEvento.Text,
				DataCheckin = DatePicker_checkin.Date.Value,
				DataCheckout = DatePicker_checkout.Date.Value,
				QntParticipantes = Convert.ToInt32(stepper_participantes.Value),
				

				

			}

        }
    }
}