using System;

class Principal{
    static void Main(){
        int num,num2,soma; //variaveis declaradas 
        Console.WriteLine("digite dois numeros: "); //mensagem na tela com quebra de linha
        num = int.Parse(Console.ReadLine()); //leitura e conversão de tipos 
        num2 = Convert.ToInt32(Console.ReadLine()); //outro modo conversão de tipos 
        soma = num + num2; //atribuição 
        Console.WriteLine(soma); //impressão final 
        Console.Read(); //novamente pausando a tela 
    }
}