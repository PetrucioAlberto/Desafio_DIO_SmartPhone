using System;

namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
       
        public Nokia(string numero) : base(numero, "Nokia", "ModeloNokia")
        {
            
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no Nokia {Modelo}");
        }
    }
}
