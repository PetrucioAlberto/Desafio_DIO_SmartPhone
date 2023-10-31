using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
       
        Nokia nokia = new Nokia("123456789"); 
        iPhone iphone = new iPhone("987654321"); 

       
        nokia.InstalarAplicativo("WhatsApp");
        iphone.InstalarAplicativo("Instagram");

        nokia.Ligar();
        iphone.ReceberLigacao();
    }
}
