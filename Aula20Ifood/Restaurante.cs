namespace Aula20Ifood
{
    public class Restaurante{
        public string NomedoRestaurante { get; set; }
        public string Endereco { get; set; }
         public Restaurante(string _nome){
            this.NomedoRestaurante = _nome;
        }

        public string MostrarDadosdoRestaurante(){
            return $"Restaurante: {NomedoRestaurante} \nEndereco: {Endereco} \n\n";
        }
    }
}