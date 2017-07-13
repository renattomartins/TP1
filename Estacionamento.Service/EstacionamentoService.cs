using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Estacionamento.Negocio;

namespace Estacionamento.Service
{
    public class EstacionamentoService : IEstacionamentoService
    {
        public void Checkin(string placa)
        {
            Operacoes.Checkin(placa);
        }

        public double Checkout(string placa)
        {
            return Operacoes.Checkout(placa);
        }

        public int VagasRestantes()
        {
            return Operacoes.VagasRestantes();
        }
    }
}
