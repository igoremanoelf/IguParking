using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace IguParking
{
    internal class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento( decimal precoInicial , decimal precoHora)
        {
            this.precoInicial = precoInicial;
            this.precoHora = precoHora;

        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo:");
            string placa = Console.ReadLine();

            if (veiculos.Any(x => x.Equals(placa.ToUpper())))
            {
                Console.WriteLine("Já existe um veículo com essa placa.");
            } else
            {
                veiculos.Add(placa);
                Console.WriteLine("Veículo cadastrado com sucesso.");

            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Informe a placa do  veículo a ser removido:");
            string placa = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas do veículo no pátio:");
                int horas = Convert.ToInt32(Console.ReadLine());
                decimal precoTotal = precoInicial + precoHora * horas;
                veiculos.Remove(placa);
                Console.WriteLine($" O veículo de placa {placa} foi removido com sucesso. Deverá ser pago {precoTotal} reais");
            }
             else
            {
                Console.WriteLine($"O veículo da placa {placa} não foi encontrado");
            }
        }

        public void ListarVeiculo()
        {
            if (veiculos.Any())
            {
                Console.Write("Os veículos estacionados são:");
                foreach (var v in veiculos)
                {
                    Console.WriteLine(v);
                }

            } else
            {
                Console.WriteLine("Não há veículos no pátio.");
            }
            }
        }
    }

