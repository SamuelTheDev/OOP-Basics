class PessoaFisica : Padrao
{
    //Somos obrigatos a usar o metodo ABSTRATO da classe Padrao // Tenho que utilizar o metodo Herdado colocando minha regra de negocios portanto é override (Sobscrever)
    public override void taxaEmprestimo(double valor)
    {
      Console.WriteLine("Taxa de empréstimo para Pessoa Física R$: " + (valor * 0.1));
    }
}