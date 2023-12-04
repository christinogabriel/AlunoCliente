using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Workspace.Models
{
    public class Cliente
    {
        public string NomeCliente { get; set; }
        public string Cpf { get; set; }
        public decimal Saldo;


        public void Sacar(decimal valor)
        {
            Saldo -= valor;
        }

        public void Depositar(decimal Valor){
            Saldo += valor;
        }
    }
}