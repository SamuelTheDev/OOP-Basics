abstract class Padrao {
    //Quando se cria uma classe abstrata vc está criando um padrão para o seu projeto
    //Posso ter métodos obrigatórios ou opcionais

    //Obrigatório
    public abstract void taxaEmprestimo(double valor);
    //Nesse tipo de método os calculos são feitos nas classes herdadas
    
    //Opcional
    public void calculoPoupanca(double valor, double taxa)
    {
        Console.WriteLine("Ganhos obtidos pela poupança: " + (valor * taxa));
    }

}