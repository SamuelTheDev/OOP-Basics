using System;

class Exemplo
{
    //atributo estatico
    public static string nome;


    //Metodo estático
    //Vou ter acesso ao metodo SOMA sem ter que instaciar um objeto pq está STATIC
    public static void soma(int n1, int n2)
    {
        Console.WriteLine(n1 + n2);
    }
}