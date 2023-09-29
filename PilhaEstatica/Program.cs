
using PilhaEstatica;

Console.WriteLine("Pilha Estática");
Console.WriteLine();
Console.WriteLine();

// consumindo a classe Pilha
Pilha pilha = new Pilha(5);

// empilhandos valores na Pilha
pilha.Empilhar("A");
pilha.Empilhar("B");
pilha.Empilhar("C");
pilha.Empilhar("D");
pilha.Empilhar("E");
pilha.Empilhar("F"); // pilha cheia

// desempilhando valores da Pilha
pilha.Desempilhar();
pilha.Desempilhar();
//pilha.Desempilhar();
//pilha.Desempilhar();
//pilha.Desempilhar();
//pilha.Desempilhar(); // pilha vazia

pilha.Imprimir();

