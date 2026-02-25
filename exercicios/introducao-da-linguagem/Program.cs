using introducao_da_linguagem.Models;

// ------------------------------------------------------------------------------------
// List<string> listaString = new List<string>();
// listaString.Add("São Paulo");
// listaString.Add("Rio de Janeiro");
// listaString.Add("Minas Gerais");
// listaString.Add("Bahia");
// Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");
// listaString.Add("Pernambuco");
// Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");
// listaString.Remove("Minas Gerais");
// Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// Console.WriteLine("Percorrendo a lista com o FOR");
// for(int contador = 0; contador < listaString.Count; contador++)
// {
//     Console.WriteLine($"Posição N° {contador} - {listaString[contador]}");
// }

// Console.WriteLine("Percorrendo a lista com o FOREACH");
// int contadorForeach = 0;
// foreach(string item in listaString)
// {
//     Console.WriteLine($"Posição N° {contadorForeach} - {item}");
//     contadorForeach++;
// }

// ------------------------------------------------------------------------------------
// int[] arrayInteiros = new int[4];
// arrayInteiros[0] = 72;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;
// arrayInteiros[3] = 1;

// int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

// for(int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//     Console.WriteLine($"Posição Nº {contador} - {arrayInteiros[contador]}");
// }

// ------------------------------------------------------------------------------------
// int[] arrayInteiros = new int[4];
// arrayInteiros[0] = 72;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;
// arrayInteiros[3] = 1;

// Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);
// for(int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//     Console.WriteLine($"Posição Nº {contador} - {arrayInteiros[contador]}");
// }

// ------------------------------------------------------------------------------------
// int [] arrayInteiros = new int[4];
// arrayInteiros[0] = 72;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;
// arrayInteiros[3] = 1;

// int contador = 0;
// foreach(int valor in arrayInteiros)
// {
//     Console.WriteLine($"Posição Nº {contador} - {valor}");
//     contador++;
// }

// ------------------------------------------------------------------------------------
// int[] arrayInteiros = new int[3];
// arrayInteiros[0] = 72;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;

// for(int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//     Console.WriteLine($"Posição Nº {contador} - {arrayInteiros[contador]}");
// }

// ------------------------------------------------------------------------------------
// string opcao;
// bool exibirMenu = true;

// while(exibirMenu)
// {
//     Console.Clear();
//     Console.WriteLine("Digite a sua opção: ");
//     Console.WriteLine("1 - Cadastrar cliente");
//     Console.WriteLine("2 - Buscar cliente");
//     Console.WriteLine("3 - Apagar cliente");
//     Console.WriteLine("4 - Encerrar");

//     opcao = Console.ReadLine();

//     switch(opcao)
//     {
//         case "1":
//             Console.WriteLine("Cadastro de cliente");
//             break;
//         case "2":
//             Console.WriteLine("Busca de cliente");
//             break;
//         case "3":
//             Console.WriteLine("Apagar cliente");
//             break;
//         case "4":
//             Console.WriteLine("Encerrar");
//             exibirMenu = false;
//             //Environment.Exit(0);
//             break;
//         default:
//             Console.WriteLine("Opção inválida");
//             break;
//     }
// }
// Console.WriteLine("Fim do programa");

// ------------------------------------------------------------------------------------
// int soma = 0, numero = 0;

// do 
// {
//     Console.WriteLine("Digite um número: (Digite 0 para parar)");
//     numero = Convert.ToInt32(Console.ReadLine());
//     soma += numero;

// } while(numero != 0);
// Console.WriteLine($"Total da soma dos números digitados é: {soma}");

// ------------------------------------------------------------------------------------
// int numero = 5;
// int contador = 0;
// while (contador <= 10)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//     contador++;
//     if(contador == 6)
//     {
//         break;
//     }
// }

// ------------------------------------------------------------------------------------
// int numero = 5;
// int contador = 0;
// while (contador <= 10)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//     contador++;
// }

// ------------------------------------------------------------------------------------
// int numero = 5;
// for(int contador = 0; contador <= 10; contador++)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }

// ------------------------------------------------------------------------------------
// Calculadora calc = new();
// calc.RaizQuadrada(9);

// ------------------------------------------------------------------------------------
// int numeroIncremento = 10;
// Console.WriteLine("Incrementando o 10");
// numeroIncremento++;
// Console.WriteLine(numeroIncremento);

// int numeroDecremento = 20;
// Console.WriteLine("Decrementando o 20");
// numeroDecremento--;
// Console.WriteLine(numeroDecremento);

// ------------------------------------------------------------------------------------
// Calculadora calc = new();
// calc.Seno(30);
// calc.Cosseno(30);
// calc.Tangente(30);

// ------------------------------------------------------------------------------------
// Calculadora calc = new();
// calc.Potencia(3, 3);

// ------------------------------------------------------------------------------------
// Calculadora calc = new();
// calc.Somar(10, 30);
// calc.Subtrair(10, 50);
// calc.Multiplicar(15, 45);
// calc.Dividir(2, 2);

// ------------------------------------------------------------------------------------
// bool chovou = true;
// bool estaTarde = true;
// if (!chovou && !estaTarde)
// {
//     Console.WriteLine("Vou pedalar");
// }
// else
// {
//     Console.WriteLine("Vou pedalar um outro dia");
// }

// ------------------------------------------------------------------------------------
// bool possuiPresencaMinima = true;
// double media = 7.5;

// if (possuiPresencaMinima && media >= 7)
// {
//     Console.WriteLine("Aprovado!");
// }
// else 
// {
//     Console.WriteLine("Reprovado!");
// }

// ------------------------------------------------------------------------------------
// bool maiorDeIdade = false;
// bool possuiAutorizacaoDoResponsavel = false;

// if (maiorDeIdade || possuiAutorizacaoDoResponsavel)
// {
//     Console.WriteLine("Entrada liberada!");
// }
// else 
// {
//     Console.WriteLine("Entrada não liberada!");
// }

// ------------------------------------------------------------------------------------
// Console.WriteLine("Digite uma letra: ");
// string letra = Console.ReadLine();

// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("É uma vogal");
//         break;
//     default:
//         Console.WriteLine("Não é uma vogal");
//         break;
// }

// ------------------------------------------------------------------------------------
// int quantidadeEmEstoque = 3;
// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

// ------------------------------------------------------------------------------------
// if(quantidadeCompra == 0)
// {
//     Console.WriteLine("Venda inválida!");
// }
// else if (possivelVenda)
// {
//     Console.WriteLine("Venda realizada com sucesso!");
// } 
// else 
// {
//     Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque.");
// }

// ------------------------------------------------------------------------------------
// string a = "15";
// int.TryParse(a, out int b);
// Console.WriteLine(b);
// Console.WriteLine("Conversão realizada com sucesso!");

// ------------------------------------------------------------------------------------
// double a = 4 / (2 + 2);
// Console.WriteLine(a);

// ------------------------------------------------------------------------------------
// int a = int.MaxValue;
// long b = a;
// Console.WriteLine(b);

// ------------------------------------------------------------------------------------
// int a = 5;
// double b = a;
// Console.WriteLine(b);

// ------------------------------------------------------------------------------------
// int inteiro = 5;
// string a = inteiro.ToString();
// Console.WriteLine(a);

// ------------------------------------------------------------------------------------
// Cast - Casting
// int a = Convert.ToInt32(null);
//int a = int.Parse("5");
// Console.WriteLine(a);

// ------------------------------------------------------------------------------------
// int a = 10;
// int b = 20;
// int c = a + b;
// // c = c + 5;
// // c += 5;
// c -= 5;
// Console.WriteLine(c);

// ------------------------------------------------------------------------------------
// DateTime dataAtual = DateTime.Now.AddDays(3);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));

// ------------------------------------------------------------------------------------
// string apresentacao = "Olá, seja bem vindo";
// int quantidade = 1;
// double altura = 1.80;
// decimal preco = 1.80M;
// bool condicao = true;

// ------------------------------------------------------------------------------------
// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da variável quantidade: " + quantidade);
// Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
// Console.WriteLine("Valor da variável preco: " + preco);
// Console.WriteLine("Valor da variável condicao: " + condicao);

// ------------------------------------------------------------------------------------
// Pessoa p = new Pessoa();
// p.Nome = "Camilly";
// p.Idade = 20;
// p.Apresentar();
