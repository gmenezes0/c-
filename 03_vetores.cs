using System;

class Principal{
    static void Main(){
        int[] vet = new int[5]; //criado o vetor de declarado o seu tamanho 
        
        for(int i=0; i < 5; i++){ //estrutura de repetição 
            Console.Write("\nentre com um valor para o vetor: "); //mensagem na tela
            vet[i] = int.Parse(Console.ReadLine()); //preenchimento das posições do vetor 
        }
        for(int j=0; j < 5; j++){
            Console.Write(vet[j]); //o vetor preenchido sendo apresentado na tela 
    }
        Console.Read();
        }
    }