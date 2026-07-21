// Projeto de um sorteio de um carro, onde o usuário digita um número de 1 a 99 e se ele acertar os números 30, 60 ou 90 ele ganha o carro.

Console.WriteLine("Participe do nosso sorteio, digite um número de 1 a 99");
Console.Write("Digite um numero: ");
    int num = Convert.ToInt32(Console.ReadLine());

    if(num <=0 || num >= 100 )
    {
       Console.WriteLine("Número inválido digite outro valor ");

    }
        else if(num == 30 || num == 60 || num == 90)
    {
        Console.WriteLine("Parabéns você ganhou um carro ");
    }
    else
    {
        Console.WriteLine("Não foi desssa vez, tente novamente");
    }




    

    Console.ReadKey();