using System;
using System.Collections.Generic;
using System.Text;

namespace MauiAppCadastroEventos.Models
{
    public class Evento
    {
        public string NomeEvento { get; set; }

        public DateTime DataCheckin { get; set; }

        public DateTime DataCheckout { get; set; }

        public TimeSpan Duracao
        {
            get => DataCheckout.Subtract(DataCheckin);
        }

        public int QntParticipantes { get; set; }
        public int CustoParticipante { get; set; }

        public string Local {  get; set; }

        public double Total
        {
            get
            {
                double valor = QntParticipantes * CustoParticipante;
                return valor;
            }

        }
    }
}
