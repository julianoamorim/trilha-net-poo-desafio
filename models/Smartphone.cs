using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace trilha_net_poo_desafio.models
{
    public abstract class Smartphone
    {
        public Smartphone(string numero, string modelo, string imei, int memoria){
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }
        public string Numero {get; set;}
        private string Modelo {get; set;}
        private string IMEI {get; set;}
        private int Memoria {get; set;}
        public void Ligar(){
            Console.WriteLine("Ligando...");
        }
        public void ReceberLigacao(){
            Console.WriteLine("Recebendo Ligacao...");
        }
        public abstract void InstalarAplicativo(string nomeApp);
        
    }
}