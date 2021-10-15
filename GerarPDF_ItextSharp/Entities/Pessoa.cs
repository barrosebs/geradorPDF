namespace GerarPDF_ItextSharp.Entities
{
    internal class Pessoa
    {
        public int IdPessoa { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public decimal Salario { get; set; }
        public Profissao Profissao { get; set; }
        public bool Empregado { get; set; }
    }
}