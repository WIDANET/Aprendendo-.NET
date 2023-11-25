



// USANDO DATA

 // using System.Data.Common;

// DateTime dataAtual = DateTime.Now.AddDays(5);

// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));




// // TESTANDO TIPO DE VARIÁVEIS

// string texto = "Olá, seja bem-vindo!";

// int quantidade = 1;

// double altura = 1.80;

// decimal preco = 1.80M;

// bool condicao = true;

// Console.WriteLine(texto);
// Console.WriteLine("O valor da variável condição é: " +quantidade);
// Console.WriteLine("O valor da variável altura é: " + altura.ToString("0.00"));
// Console.WriteLine("O valor da variável preço é: " + preco);
// Console.WriteLine("O valor da variável condição é: " + condicao);





 using Aprendendo_.NET.Models;

 string Nome = "Willian";
 int Idade = 24;

Pessoa p = new Pessoa(Nome, Idade);

 p.Apresentar();
