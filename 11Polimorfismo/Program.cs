//Instanciar Estagiario
Imposto objE = new Estagiario();
objE.valeAlimentacao(1000);
objE.valeTransporte(1000);
Console.WriteLine("__________");

//Instanciar Gerente
Imposto objG = new Gerente();
objG.valeAlimentacao(5000);
objG.valeTransporte(5000);
Console.WriteLine("__________");

//Instanciar Atendente
Imposto objA = new Atendente();
objA.valeAlimentacao(2000);
objA.valeTransporte(2000);
Console.WriteLine("__________");

//Polimorfismo é importante para projetos de medio e grande porte para reutilizar os seus métodos