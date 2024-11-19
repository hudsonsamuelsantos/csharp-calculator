int primeiroNumero = PrimeiroInput();
int segundoNumero = SegundoInput();
string operador = SelecaoDeOperador();
Resultado(operador, primeiroNumero, segundoNumero);

static int PrimeiroInput()
{
    Console.Clear();
    Console.WriteLine(
        @"Bem vindo a sua calculadora!

        Digite o primeiro número: "
        );
    int primeiroNumero = int.Parse(Console.ReadLine());
    Console.Clear();

    return primeiroNumero;
}

static string SelecaoDeOperador()
{
    Console.WriteLine(
    @"Diga qual operador deseja usar. Digite:
    + (Para soma)
    - (Para multiplicação)
    * (Para multiplicação)
    / (Para divisão)
    
    Digite o operador: "
);
    string operador = Console.ReadLine();

    Console.Clear();

    return operador;
}

static int SegundoInput()
{
    Console.WriteLine("Digite o segundo número: ");
    int segundoNumero = int.Parse(Console.ReadLine());
    Console.Clear();

    return segundoNumero;
}

static void Resultado(string operador, int primeiroNumero, int segundoNumero)
{
    int resultado = 0;
    bool operadorValido = true;
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
            operadorValido = false;
            break;
    }

    if (operadorValido)
        Console.WriteLine($"Resultado: {primeiroNumero} {operador} {segundoNumero} = {resultado}");
    else
        Console.WriteLine("Operador inválido! Tente novamente!");

}
