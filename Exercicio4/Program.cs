float Peso, Altura, Imc;

Console.WriteLine("Digite seu peso: ");
Peso = float.Parse(Console.ReadLine());
Console.WriteLine("Digite sua altura: ");
Altura = float.Parse(Console.ReadLine());

Imc = Peso / (Altura * Altura);

Console.WriteLine("Seu IMC (índice de massa corporal é: " + Imc);
