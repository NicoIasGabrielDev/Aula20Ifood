using System;

namespace Aula20Ifood
{
    public class Pedido
    {
   
        public string Itens { get; set; }
        public Cliente Cliente { get; set; }
        public Restaurante Restaurante { get; set; }
        public string Pagamento { get; set; }
        public bool PedidoPago {get; set;}
        public DateTime Horario {get; set;}

        public string EntregarPedido(){
        Horario = DateTime.Now;

            string retorno = $"Sua {Itens} chegou, Bom Apetite!\n";
            
            retorno += Restaurante.MostrarDadosdoRestaurante();
            retorno += Cliente.MostrarDadosdocliente();
            retorno += Horario;

            return retorno;
        }
    } 
}