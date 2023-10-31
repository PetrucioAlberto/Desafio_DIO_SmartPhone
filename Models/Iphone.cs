namespace DesafioPOO.Models
{
    public class iPhone : Smartphone
    {
        
        public iPhone(string numero) : base(numero, "iPhone", "ModeloiPhone")
        {
            
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no iPhone {Modelo}");
        }
    }
}