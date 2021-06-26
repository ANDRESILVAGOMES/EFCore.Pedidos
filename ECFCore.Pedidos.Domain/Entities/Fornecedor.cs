using ECFCore.Pedidos.Domain.ValueObjects;

namespace ECFCore.Pedidos.Domain.Entities
{
     public class Fornecedor
    {
        public int Codigo { get; set; }
        public Nome Nome { get; set; }
        public Endereco Endereco { get; set; }


    }
}
