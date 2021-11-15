namespace WindowsFormsEntityMVC.Models
{
    public class Customer : EntityBase
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Cidade { get; set; }
        public string Endereco { get; set; }
    }
}
