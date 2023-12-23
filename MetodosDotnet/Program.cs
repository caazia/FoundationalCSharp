// Random dice = new Random();
// int roll = dice.Next(980000000, 999999999);
// Console.WriteLine(roll);

// Para chamar métodos de uma classe na Biblioteca de Classes do .NET, use o formato ClassName.MethodName(), em que o símbolo . é o operador de acesso de membro para acessar um método definido na classe e os símbolos () são os operadores de invocação de método.
// Ao chamar um método sem estado, não é necessário criar uma instância de sua classe primeiro.
// Ao chamar um método com estado, é necessário criar uma instância da classe e acessar o método no objeto.
// Use o operador new para criar uma instância de uma classe.
// Uma instância de uma classe é chamada de um objeto.

// int number = 7;
// string text = "seven";

// Console.WriteLine(number);
// Console.WriteLine();
// Console.WriteLine(text);

/*
Random dice = new Random();
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");
*/

int firstValue = 500;
int secondValue = 600;
int largerValue;

largerValue = Math.Min(firstValue, secondValue);

Console.WriteLine(largerValue);