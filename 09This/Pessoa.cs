using System;

class Pessoa 
{
    //atributos
    private string nome = "Tatiana";

    //construtor
    public Pessoa(string nome)
    {
        Console.WriteLine(nome); //Esse pega o parametro preenchido no Program.cs
        Console.WriteLine(this.nome); //Esse pega o atributo lá em cima
        //This sempre liga o atributo da classe ao seu método
    }
}