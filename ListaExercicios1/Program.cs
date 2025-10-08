
float n1, n2, n3, media;

Console.WriteLine("Digite a primeira nota: ");
n1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a segunda nota: ");
n2 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a terceira nota: ");
n3 = float.Parse(Console.ReadLine());

media = (n1 + n2 + n3) / 3;

Console.WriteLine("Sua média foi: " + media);

if (media >= 7)
{
    Console.WriteLine("Situação: Aprovado");
}
else{
    Console.WriteLine("Situação: Reprovado");
}
   

