using Aprendendo_.NET.Models;

// ***  CHAMANDO A CLASSE CALCULADORA COM OPERADORES ARITIMÉTICOS ** 

 Calculadora Calc = new Calculadora();

 Calc.Somar(10, 30);
 Calc.Subtrair(10, 50);
 Calc.Multiplicar(15, 45);
 Calc.Dividir(2, 2);
 Calc.Potencia(3, 3);




// *** OPERADOR NOT (!) ***

// bool choveu = false;
// bool estaTarde = false;

// if(!choveu && !estaTarde){
//     Console.WriteLine("Vou pedalar.");
// }
// else{
//     Console.WriteLine("Vou pedalar um outro dia.");
// }





// *** SWITCH CASE ***

// Console.WriteLine("Digite uma letra: ");
// string letra = Console.ReadLine();

// switch(letra){
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("É uma vogal");
//         break;
//     default:
//         Console.WriteLine("Não é uma vogal!");
//         break;
// }



// if(letra == "a" ||
//    letra == "e" ||
//    letra == "i" ||
//    letra == "o" ||
//    letra == "u"){
//     Console.WriteLine("É uma vogal!");
//    }
//    else{
//     Console.WriteLine("Não é uma vogal!");
//    }


// if(letra == "a"){
//     Console.WriteLine("Vogal");
// }
// else if(letra == "e"){
//     Console.WriteLine("Vogal");
// }
// else if(letra == "i"){
//     Console.WriteLine("Vogal");
// }
// else if(letra == "o"){
//     Console.WriteLine("Vogal");
// }
// else if(letra == "u"){
//     Console.WriteLine("Vogal");
// }
// else{
//     Console.WriteLine("Não é uma vogal!");
// }





// *** OPERADORES CONDICIONAIS COM IF/ELSE *** 

// int quantidadeEmEstoque = 10;

// int quantidadeCompra = 0;

// // bool = variável booleana
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade comppra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

// if(quantidadeCompra == 0){
//     Console.WriteLine("Venda inválida!");
// }
// else if(possivelVenda){

//     Console.WriteLine("Venda realizada!");
// }
// else{

//     Console.WriteLine("Desculpe, não temos a quantidade desejada em estoque!");
// }






// *** CONVERSÃO SEGURA  USANDO TRYPARSE***

// string a = ("32");

// int b = 0;

// int.TryParse(a, out b);

// Console.WriteLine(b);
// Console.WriteLine("Valor convertido com sucesso!");





// *** ORDEM DE OPERADORES ***

// double a = 4 / (2 + 2);

// Console.WriteLine(a);





// *** CASTING IMPLÍCITO ***

// int a = 5;
// double b = a;

// Console.WriteLine(b);





// *** FAZENDO CASTING PARA CONVERTER TIPOS DE VARIÁVEIS ***

//  int a = Convert.ToInt32("26");

//  Console.WriteLine(a);

//  int b = int.Parse("24");

//  Console.WriteLine(b);


//  string c = a.ToString();

//  Console.WriteLine(c);





// *** USANDO DATA ***

// using System.Data.Common;

// DateTime dataAtual = DateTime.Now.AddDays(5);

// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));





// *** TESTANDO TIPOS DE VARIÁVEIS ***

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





//  using Aprendendo_.NET.Models;

//  string Nome = "Willian";
//  int Idade = 24;

// Pessoa p = new Pessoa(Nome, Idade);

//  p.Apresentar();
