class Pessoa 
{
    // Atributo
    private string nome;

    //get e set >> é sempre publico >> Igual atributo mas começa maicusculo >> Maneira de se acessar um atributo privado
    //Você pode restringir se você quer apenas enviar ou receber informação para restringir mais ainda
    public string Nome 
    {
        //PODEMOS REMOVER UM DOS DOIS SE QUISERMOS // DEIXAR TUDO RESTRINGIDO 
        get{return nome;}
        set{nome = value;}
    }
}