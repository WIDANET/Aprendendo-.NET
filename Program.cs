using Aprendendo_.NET.Models;
 //...

// *** TRABALHANDO COM LISTAS ***

// List<string> listaString = new List<string>();

// listaString.Add("PE");           
// listaString.Add("PB");   
// listaString.Add("BA");
// listaString.Add("RN");


// // OBSERVANDO BENEFÍCIOS DAS LISTAS: O TAMANHO SE ADPTA À QUANTIDADE DE DADOS INSERIDA, NÃO PECISA INICIAR COM TAMANHO FIXO

// Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// listaString.Add("SE");

// Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// listaString.Remove("RN");

// Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// Console.WriteLine("PERCORRENDO A LISTA COM FOR");
// for(int i = 0; i < listaString.Count; i++)
// {
//     Console.WriteLine($"Posição Nº {i} - {listaString[i]}");
// }

// Console.WriteLine("PERCORRENDO A LISTA COM FOREACH");
// int contadorForEach = 0;
// foreach(string item in listaString)
// {
//      Console.WriteLine($"Posição Nº {contadorForEach} - {item}");
//      contadorForEach++;
// }





 // *** INICIANDO ARRAYS ***

// int[] arrayInteiros = new int[3];

// arrayInteiros[0] = 72;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;

// // *** COPIANDO UM ARRAY PARA OUTRO *** 

// int[] arrayInteirosDobrados = new int[arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayInteirosDobrados, arrayInteiros.Length);


// Console.WriteLine("PERCORRENDO O ARRAY COM FOR");

// for(int i = 0; i < arrayInteiros.Length; i++)
// {
//     Console.WriteLine($"Posição Nº {i} - {arrayInteiros[i]}");
// }



// DOBRANDO O TAMNHANDO DO ARRAY COM RESIZE

// Array.Resize(ref arrayInteiros, arrayInteiros.Length + 2);




// Console.WriteLine("PERCORRENDO O ARRAY COM FOREACH");
// int contadorForEach = 0;
// foreach(int valor in arrayInteiros)
// {
//     Console.WriteLine($"Posição Nº {contadorForEach} - {valor}");
//     contadorForEach++;
// }






// int soma = 0, numero = 0;

// do
// {
//     Console.WriteLine("Digite um número (0 para parar): ");
//     numero = Convert.ToInt32(Console.ReadLine());
    
//     soma += numero;

//     if(numero == 0)
//     {
//         Console.WriteLine("Programa encerrado!");
//     }
//     else
//     {
//         Console.WriteLine($"A soma dos números é: {soma}");
//     }

// }while(numero != 0);





// *** WHILE ***

// int numero = 5;
// int contador = 0;

// while(contador <= 10)
// {
//     Console.WriteLine($"{numero} x {contador} é igual a {numero * contador}");
//     contador++;

//     if(contador == 6)
//     {
//         // INTERROMPENDO FLUXO DE EXECUÇÃO
//         break;
        
//     }
// }





// *** LAÇOS DE REPETIÇÃO COM FOR ***

// int numero = 5;



// for(int i = 0; i <= 10; i++)
// {
//     Console.WriteLine($"{numero} x {i} é igual a {numero * i}");
// }





// *** RAIZ QUADRADA *** 

// Calculadora Calc = new Calculadora();

// Calc.RaizQuadrada(9);





// *** INCREMENTO E DECREMENTO ***

// int numeroIncremento = 10;

// Console.WriteLine($"O valor do número é {numeroIncremento}");
// Console.WriteLine($"Incrementando o {numeroIncremento}...");

// numeroIncremento++;

// Console.WriteLine($"O valor incrementado é: {numeroIncremento}");

// int numeroDecremento = 20;

// Console.WriteLine($"O valor do número é {numeroDecremento}");
// Console.WriteLine($"Decrementando o {numeroDecremento}...");

// numeroDecremento--;

// Console.WriteLine($"O valor decrementado é: {numeroDecremento}");





// ***  CHAMANDO A CLASSE CALCULADORA COM OPERADORES ARITIMÉTICOS *** 

//  Calculadora Calc = new Calculadora();

// Calc.seno(30);
// Calc.coseno(30);
// Calc.tangente(30);



//  Calc.Somar(10, 30);
//  Calc.Subtrair(10, 50);
//  Calc.Multiplicar(15, 45);
//  Calc.Dividir(2, 2);
//  Calc.Potencia(3, 3);




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
