
float Nota1, Nota2, Nota3, Media;
int Peso1, Peso2, Peso3;

Console.WriteLine("Digite a nota da Prova 1: ");
Nota1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o peso da Prova 1: ");
Peso1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a nota da Prova 2: ");
Nota2 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o peso da Prova 2: ");
Peso2 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a nota da Prova 3: ");
Nota3 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o peso da Prova 3: ");
Peso3 = int.Parse(Console.ReadLine());

Media = ((Nota1 * Peso1) + (Nota2 * Peso2) + (Nota3 * Peso3)) / (Peso1 + Peso2 + Peso3);

Console.WriteLine("Sua média foi: " + Media);


if(Media >= 9){
    Console.WriteLine("Conceito: A");
}else if(Media >= 7 && Media < 9){
    Console.WriteLine("Conceito: B");
}else if(Media >= 5 && Media < 7){
    Console.WriteLine("Conceito: C");
}else{
    Console.WriteLine("Conceito: D");
}
    