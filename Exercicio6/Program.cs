float Preco;
int Operacao;

Console.WriteLine("Digite o valor do produto: ");
Preco = float.Parse(Console.ReadLine());

Console.WriteLine("Informe o método de pagamento: 1- À Vista; 2 - Parcelado ");
Operacao = int.Parse(Console.ReadLine());

if(Operacao == 1){
    Console.WriteLine("Pagamentos À Vista tem um desconto de 10%");
    float ValorDesconto = Preco * (float)0.10;
    Console.WriteLine("Valor total: R$ " + (Preco - ValorDesconto));
}else if(Operacao == 2){
    Console.WriteLine("Valor total: R$ " + Preco);
}else{
    Console.WriteLine("Escolha um número válido correspondente a uma operação disponível");
}
