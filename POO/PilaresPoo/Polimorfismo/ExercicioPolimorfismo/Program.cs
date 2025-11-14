using ExercicioPolimorfismo;


PagamentoPix compraPix = new PagamentoPix();
compraPix.valorCompra = 15000;
float valorPagar = compraPix.CalcularTotal();
Console.WriteLine($"Produto: Smartphone");
Console.WriteLine($"preço: {compraPix.valorCompra}");
Console.WriteLine($"Forma de pagamento: PIX");
Console.WriteLine($"Compra com desconto: {valorPagar}");

Console.WriteLine();

PagamentoCartão compraCartao= new PagamentoCartão();
compraCartao.valorCompra = 50;


Console.WriteLine($"Produto: Caneca");
Console.WriteLine($"preço: {compraCartao.valorCompra}");
Console.WriteLine($"Forma de pagamento: Cartão");
Console.WriteLine($"Compra com acresimo: {compraCartao.CalcularTotal()}");

