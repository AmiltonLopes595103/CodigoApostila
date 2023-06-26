using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosApst.cs
{
     class Carros:IPadrao
    {

        private int Id;

        public int getId()
        {
            return Id;
        }

        public void setId(int Id)
        {
            this.Id = Id;

        }
        public string marca;
        public string getMarca()
        {
            return marca;
        }

        public void setMarca(string marca)
        {
            this.marca = marca;
        }

        public double valor;
       public double getValor()
        {
            return valor;
        }

        public void setValor(double valor)
        {
            this.valor = valor;
        }
        public string cor;
      public string getCor()
        {
            return cor;
        }
        public void setCor( string cor)
        {
            this.cor = cor;
        }

        public string modelo;
        public string getModelo()
        {
            return modelo;
        }
        public void setModelo(string modelo)
        {
            this.modelo = modelo;
        }
        public string ano;
        public string getAno()
        {
            return ano;
        }
        public void setAno(string ano)
        {
            this.ano = ano;
        }


        public Carros  CadastrarVeiculo()//Esse método deve ser do mesmo tipo da classe a qual ele pertece pois ira utilizar
            // de todos os atributos dessa classe.
        {
            

            Carros objcarro= new Carros();
            Console.WriteLine("Informe o ID do  veiculo:   ");
            objcarro.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o modelo do veiculo: ");
            objcarro.modelo = Console.ReadLine();
            Console.WriteLine("Informe a marca do veiculo: ");
            objcarro.marca = Console.ReadLine();
            Console.WriteLine("Informe o ano do veiculo: ");
            objcarro.ano = Console.ReadLine();
            Console.WriteLine("Informe o Valor do veiculo: ");
            objcarro.valor = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a cor do veiculo: ");
            objcarro.cor = Console.ReadLine();
         
           return objcarro;
            



        }

        public void ListarVeiculos(List<Carros> lista)
        {
            
            foreach (Carros c in lista )
            {
                Console.WriteLine();
                
                Console.WriteLine("{0}, {1},   {2},   {3},    {4},        {5}", "Id|", " Modelo| "," Marca| "," Ano| "," Valor| ",  " Cor| " );
                Console.WriteLine("{0},  {1},     {2},         {3}     {4},         {5}", c.Id, c.modelo, c.marca,  c.ano, c.valor.ToString("F2"),c.cor);
               
                //Neste caso não conseguiremos utilizar o método ToString dentro de um outro medodo da Classe Carros.
                //então teremos que utilizar outra maneira de exibir as informações dos objetos.

            }
        }
        

        public void EXcluirVeiculo(List<Carros> lista)
        {
            int id;



            foreach (Carros c in lista)
            {
                Console.WriteLine();

                Console.WriteLine("{0}, {1},   {2},   {3},    {4},        {5}", "Id|", " Modelo| ", " Marca| ", " Ano| ", " Valor| ", " Cor| ");
                Console.WriteLine("{0},  {1},     {2},         {3}     {4},         {5}", c.Id, c.modelo, c.marca, c.ano, c.valor.ToString("F2"), c.cor);

                //Neste caso não conseguiremos utilizar o método ToString dentro de um outro medodo da Classe Carros.
                //então teremos que utilizar outra maneira de exibir as informações dos objetos.

            }
            Console.WriteLine();
            Console.WriteLine("Inform o ID do carro que deseja excluir:");
            id = int.Parse(Console.ReadLine());
            
            int posicao= lista.FindIndex(x => x.Id == id);//Solução que funciona. FindIndex();
            lista.RemoveAt(posicao);

            
        }

        public override string ToString()
        {
            return  "Id: "+ Id+"\n"+
                    "Modelo: " + modelo + "\n" +
                    "Marca: " + marca + "\n" +
                    "Ano: " + ano + "\n" +
                    "Valor: " + valor.ToString("F3") + "\n" +
                    "Cor: " + cor + "\n";
        }




    }
}
