Console.Clear();
Console.WriteLine("Digite o primeiro número: ");
int primeiroNumero = int.Parse(Console.ReadLine());
Console.Clear();
// Console.WriteLine(primeiroNumero);

Console.WriteLine(
    @"Diga qual operador deseja usar. Digite:
    + (Para soma)
    - (Para multiplicação)
    * (Para multiplicação)
    / (Para divisão)
    
    Digite o operador: "
);
string operador = Console.ReadLine();
// Console.WriteLine(operador);
Console.Clear();

Console.WriteLine("Digite o segundo número: ");
int segundoNumero = int.Parse(Console.ReadLine());
Console.Clear();
// Console.WriteLine(segundoNumero);

int resultado = 0;
switch (operador)
{
    case "+":
        resultado = primeiroNumero + segundoNumero;
        break;
    case "-":
        resultado = primeiroNumero - segundoNumero;
        break;
    case "*":
        resultado = primeiroNumero * segundoNumero;
        break;
    case "/":
        resultado = primeiroNumero / segundoNumero;
        break;
    default:
        Console.WriteLine("Operador inválido tente novamente.");
        break;
}

Console.WriteLine($"Resultado: {primeiroNumero} {operador} {segundoNumero} = {resultado}");
