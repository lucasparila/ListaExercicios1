int n1, n2;
Console.WriteLine("Digite dois números inteiros: ");
n1 = int.Parse(Console.ReadLine());
n2 = int.Parse(Console.ReadLine());

if(n1 % n2 == 0){
    Console.WriteLine(n2 + " é múltiplo de " + n1);
}else{
    Console.WriteLine(n2 + " não é múltiplo de " + n1);
}

if (n2 % n1 == 0)
{
    Console.WriteLine(n1 + " é múltiplo de " + n2);
}
else
{
    Console.WriteLine(n1 + " não é múltiplo de " + n2);
}
