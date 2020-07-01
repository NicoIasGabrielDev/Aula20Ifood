namespace Aula20Ifood
{
    public class Cliente
    {
        public string NomedoCliente { get; set; }
        public string EnderecoAtual { get; set; }
        public Cliente(string _nome){
            this.NomedoCliente = _nome;
        }
    
        public string MostrarDadosdocliente(){
            return $"Cliente: {NomedoCliente} \nEndereco: {EnderecoAtual} \n\n";
        }
    }
}
