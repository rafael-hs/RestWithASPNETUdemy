using System.Runtime.Serialization;

namespace RestWithASPNETUdemy.Model
{
    //Contrato entre Atributos
    //e a estrutura da tabela
    //[DataContract]
    public class User
    {
        public long? Id { get; set; }
        public string Login { get; set; }
        public string AcessKey { get; set; }
    }
}
