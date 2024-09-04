namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        List<string> app = new List<string>();
        public Iphone(string numero,string modelo, string imei, int memoria) : base(numero,modelo,imei,memoria){

        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("\n \n Obter");
            Console.WriteLine("1- Sim \n2- Não");
            Console.Write("Opção: ");
            int escolha = Convert.ToInt32(Console.ReadLine());
            switch(escolha){
                case 1:
                    app.Add(nomeApp);
                break;
                case 2:
                    Console.WriteLine("Cancelando instalação");
                    break;
            }

        }   
    }
}