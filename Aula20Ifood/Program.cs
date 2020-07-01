using System;

namespace Aula20Ifood
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente paulo = new Cliente("Paulo");
            paulo.EnderecoAtual = "Rua da Mocca,987";
            System.Console.WriteLine(paulo.MostrarDadosdocliente());

            Restaurante outback = new Restaurante("Outback");
            outback.Endereco = "Avenida Rebouças, 532";
            System.Console.WriteLine(outback.MostrarDadosdoRestaurante());

            Pedido pedido1 = new Pedido();
            pedido1.Cliente = paulo;
            pedido1.Restaurante = outback;
            
            {
            System.Console.WriteLine("O que deseja hoje?");
            pedido1.Itens = Console.ReadLine();

            Console.WriteLine( pedido1.EntregarPedido() );  
            }
        }
    }
}
