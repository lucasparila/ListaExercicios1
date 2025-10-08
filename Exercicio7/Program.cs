float Lado1, Lado2, Lado3;

Console.WriteLine("Digite os três lados do triângulo: ");
Lado1 = float.Parse(Console.ReadLine());
Lado2 = float.Parse(Console.ReadLine());
Lado3 = float.Parse(Console.ReadLine());

if((Lado1 < (Lado2 + Lado3)) && (Lado2 < (Lado1 + Lado3)) && (Lado3 < (Lado1 + Lado2))){
    if(Lado1 == Lado2 && Lado2 == Lado3){
        Console.WriteLine("Tipo do triângulo: Equilátero");
    }else if(Lado1 == Lado2 && Lado1 != Lado3 || Lado2 == Lado3 && Lado2 != Lado1){
        Console.WriteLine("Tipo do triângulo: Isósceles");
    }
    else {
        Console.WriteLine("Tipo do triângulo: Escaleno");
    }
}else{
    Console.WriteLine("Não é um triângulo");
}

Console.WriteLine("Pressione qualquer tecla para sair...");
Console.ReadKey();