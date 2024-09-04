using System;
using System.Threading;

namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        List<string> app = new List<string>();
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria){

        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Deseja instalar o aplicativo {nomeApp}? \n 1-Avançar \n 2-Cancelar");
            Console.Write("Opção: ");
            int escolha=Convert.ToInt32(Console.ReadLine());

            switch(escolha){
                case 1:
                if(nomeApp != ""){
                string point="";
                    Console.Write("Aguarde a instalação"); //20 letras      
                        for(int j=0; j < 2;j++){
                            Thread.Sleep(500);
                            point+=".";
                            Console.Write($"{point}");
                                if(point == "..."){
                                Console.SetCursorPosition(20,11);
                                Console.Write(" ");
                                }
                            Thread.Sleep(1000);
                        }
                    
                    Console.WriteLine("\n Aplicativo instalado com sucesso!\n \n");
                    app.Add(nomeApp);
                }else{
                    Console.WriteLine("Não foi possível instalar a aplicação");
                }
                    break;
                case 2:
                    Console.WriteLine("Cancelando instalação");
                    Console.ReadKey();
                    break;
                default:
                Console.WriteLine("Comando inválido");
                    break;
            }
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
    }
}