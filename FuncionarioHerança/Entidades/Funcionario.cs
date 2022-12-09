namespace FuncionarioHerança.Entidades
{
    class Funcionarios
    {
        public string Nome { get; set; }
        public int Horas { get; set; }
        public double ValorHoras { get; set; }



        public Funcionarios()
        {

        }

        public Funcionarios(string nome, int horas, double valorhoras)
        {
            Nome = nome;
            Horas = horas;
            ValorHoras = valorhoras;
        }


        public virtual double Pagamento()
        {
            return Horas * ValorHoras;
        }
    }
}
