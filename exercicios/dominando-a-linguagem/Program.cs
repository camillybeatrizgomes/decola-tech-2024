using System.Globalization;
using dominando_a_linguagem.Models;
// -------------------------------------------------------------------
// Dictionary<string, string> estados = new Dictionary<string, string>();
// estados.Add("SP","São Paulo");
// estados.Add("BA","Bahia");
// estados.Add("MG","Minas Gerais");

// Console.WriteLine(estados["MG"]);

// foreach (var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key} | valor: {item.Value}");
// }

// Console.WriteLine("------------------------------------");
// estados.Remove("BA");
// estados["SP"] = "São Paulo - Valor Alterado";

// foreach (var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key} | valor: {item.Value}");
// }

// string chave = "BAE";
// Console.WriteLine($"Verificando o elemento {chave}");

// if(estados.ContainsKey(chave))
// {
//     Console.WriteLine($"Valor existente: {chave}");
// }
// else 
// {
//     Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave}");
// }

// -------------------------------------------------------------------
// Stack<int> pilha = new Stack<int>();
// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");
// pilha.Push(20);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }

// -------------------------------------------------------------------
// Queue<int> fila = new Queue<int>();
// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
// fila.Enqueue(10);

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }

// -------------------------------------------------------------------
// new ExemploExcecao().Metodo1();

// -------------------------------------------------------------------
// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/arquivo-Leitura.txt");
//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// } 
// catch(FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
// }
// catch(DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado. {ex.Message}");
// }
// catch(Exception ex)
// {
//     Console.WriteLine($"Ocorrei uma exceção genérica. {ex.Message}");
// }
// finally 
// {
//     Console.WriteLine("Fim do Programa");
// }
// -------------------------------------------------------------------
// string dataString = "2024-01-03 18:00";
// bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, 
//                         DateTimeStyles.None, out DateTime data);

// if(sucesso)
// {
//     Console.WriteLine($"Conversão com sucesso! Data: {data}");
// }
// else 
// {
//     Console.WriteLine($"{dataString} não é uma data válida");
// }

// -------------------------------------------------------------------
// DateTime data = DateTime.Now;
// Console.WriteLine(data.ToShortTimeString());
// -------------------------------------------------------------------
// DateTime data = DateTime.Now;
// Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));
// -------------------------------------------------------------------
// double porcentagem = .3421;
// Console.WriteLine(porcentagem.ToString("P"));

// int numero = 123456;
// Console.WriteLine(numero.ToString("##-##-##"));
// -------------------------------------------------------------------
// using System.Globalization;

// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");
// decimal valorMonetario = 1582.40M;
// Console.WriteLine(valorMonetario.ToString("C1"));

// -------------------------------------------------------------------
// using System.Globalization;

// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");
// decimal valorMonetario = 1582.40M;
// Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));

// -------------------------------------------------------------------
// using System.Globalization;

// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
// decimal valorMonetario = 1582.40M;
// Console.WriteLine($"{valorMonetario:C}");
// -------------------------------------------------------------------
// decimal valorMonetario = 82.40M;
// Console.WriteLine($"{valorMonetario:C}");
// -------------------------------------------------------------------
// string numero1 = "10";
// string numero2 = "20";
// string resultado = numero1 + numero2;
// Console.WriteLine(resultado);

// -------------------------------------------------------------------
// Pessoa p1 = new Pessoa(nome: "Camilly", sobrenome: "Beatriz");
// Pessoa p2 = new Pessoa(nome: "Laís", sobrenome: "Gabriela");

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Inglês";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();

// -------------------------------------------------------------------
// Pessoa p1 = new Pessoa();
// p1.Nome = "Camilly";
// p1.Sobrenome = "Beatriz";
// p1.Idade = 20;
// p1.Apresentar();
