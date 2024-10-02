namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
      // Construtor que chama o construtor base da classe Smartphone
        public Nokia(string numero, string modelo, string imei, int memoria) 
            : base(numero, modelo, imei, memoria)
        {
        }

        // Sobrescrevendo o método abstrato "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia.");
        }
    }
}