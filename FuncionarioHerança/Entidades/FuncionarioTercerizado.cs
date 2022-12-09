namespace FuncionarioHerança.Entidades
{
     sealed class FuncionarioTercerizado : Funcionarios
    {
        public double DispensaAdicional { get; set; }


        public FuncionarioTercerizado()
        {

        }

        public FuncionarioTercerizado(string nome, int horas, double valorhoras, double dispensaadicional) : base(nome, horas, valorhoras)
        {
            DispensaAdicional = dispensaadicional;
        }



        //Função Pagamento para Funcionario Tercerizado.
        public sealed override double Pagamento()
        {
            return base.Pagamento() + 1.1 * DispensaAdicional;

        }
    }
}
