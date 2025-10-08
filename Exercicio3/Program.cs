float n1, n2;

Console.WriteLine("Digite dois números: ");
n1 = float.Parse(Console.ReadLine());
n2 = float.Parse(Console.ReadLine());

if(n1 > n2){
    Console.WriteLine("Maior: " + n1); 
}else if(n2 > n1){
    Console.WriteLine("Maior: " + n2);
}else{
    Console.WriteLine("Os números são iguais");
}

