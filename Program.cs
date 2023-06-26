using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using ExerciciosApst.cs;

namespace AtividadesApostila
{
    class Program
    {
        //Questão - 1.
      
       

        static void Main(string[] args)
        {
            Console.WriteLine("Questção - 1");

            List<Carros> myList = new List<Carros>(); 

            Carros carro1 = new Carros();
             carro1.setId(1);
             carro1.setModelo("Gol");
             carro1.setMarca("Volksvagen");
             carro1.setAno("2015");
             carro1.setValor(40.000);
             carro1.setCor("Vermelho");
            myList.Add(carro1);//Adicionando um objeto a lista de objetos.

            Carros carro2 = new Carros();
            carro2.setId(2);
            carro2.setModelo("Compass");
            carro2.setMarca("Jeep");
            carro2.setAno("2023");
            carro2.setValor(157.579);
            carro2.setCor("Grafite");
            myList.Add(carro2);

            Carros carro3 = new Carros();
            carro3.setId(3);
            carro3.setModelo("Camaro");
            carro3.setMarca("Chevrolet");
            carro3.setAno("2022");
            carro3.setValor(494.900);
            carro3.setCor("Amarelo");
            myList.Add(carro3);


           




            myList.Sort((m1, m2) =>m1.valor.CompareTo(m2.valor));//Utilizando metodo compareTo para compararar e organizar os os objetos por valoes.
            myList.Reverse();




            foreach(Carros car in myList)
            {
                Console.WriteLine(car);

            }


            Console.WriteLine("//*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=-*=*=*=*=*=*=*=*=*=*=*=*=*=//");

            Console.WriteLine("Questão - 2.");
            Console.WriteLine();
            int opcao;
            List<Carros> list = new List<Carros>();//Lista de uso geral, escopo do metodo Main.

            do
            {
                Console.WriteLine("*======================*");
                Console.WriteLine("|(1) Cadastrar Veiculo |");
                Console.WriteLine("|(2) Excluir Veiculo   |");
                Console.WriteLine("|(3)Listar Veiculo     |");
                Console.WriteLine("|(0)Sair               |");
                Console.WriteLine("*======================*");
                opcao = int.Parse(Console.ReadLine());

           
          



                switch (opcao )
                {

                    case 1:

                    list.Add(new Carros().CadastrarVeiculo());//Instanciado um objeto e chamando um método
                                                              //desse objeto ao mesmo tempo e adicionando esse objeto a lista de objetos.
                       
                        break;

                    case 2:
                          new Carros().EXcluirVeiculo(list);

                        
                     break;

                    case 3:
                           new Carros().ListarVeiculos(list);
                        break;

                    default:

                        break;
                     
                       
                }








                
                




            
                    
            } while (opcao != 0);






        }
    }
}