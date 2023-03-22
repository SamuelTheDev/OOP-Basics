using System;

class Pessoa
{
    //Atributos
    public double peso;
    public double altura;

    //Métodos
    public double IMCCalculator()
    {
        return peso / (altura * altura);
    }
    public string IMCResult(double IMCCalculator)
    {
        //Sempre inicializa a variável local com o valor padrão
        string retorno = "";
        if (IMCCalculator < 18.5)
        {
            retorno = "Abaixo do peso";
        }
        else if (IMCCalculator < 25)
        {
            retorno = "Peso normal";
        }
        else if (IMCCalculator < 30)
        {
            retorno = "Acima do peso";
        }
        else if (IMCCalculator < 35)
        {
            retorno = "Obesidade I";
        }
        else if (IMCCalculator < 40)
        {
            retorno = "Obesidade II";
        }
        else if (IMCCalculator >= 40)
        {
            retorno = "Obesidade III";
        }
        return retorno;

    }
    public void mensagem()
    {
        // Obter calculo
        double obterCalculo = IMCCalculator();
        // Obter Situação
        string obterSituacao = IMCResult(obterCalculo);
        // Exibir Mensagem 
        Console.WriteLine("Seu indice é: " + obterCalculo + ". E você está: " + obterSituacao);
    }
}