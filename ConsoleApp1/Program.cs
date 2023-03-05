Console.WriteLine("------ CONTROLE DE PONTO ------\n\nPreencha as informações abaixo:");
Funcionario fun = new Funcionario();
ControlePonto c = new ControlePonto();

Console.Write("\nNome: ");
fun.nome = Console.ReadLine();


_codFun:
Console.Write("\nCódigo de identificação do funcionário: ");
int idFun;
if (int.TryParse(Console.ReadLine(), out idFun))
{
    fun.codigo = idFun;
}
else
{
    Console.WriteLine("\nValor inválido! Tente novamente!\n");
    goto _codFun;
}


Console.Write("\nNome do setor: ");
fun.NomeSetor = Console.ReadLine();


_idSet:
Console.Write("\nID do setor: ");
int id;
if (int.TryParse(Console.ReadLine(), out id))
{
    fun.IdSetor = id;
}
else
{
    Console.WriteLine("\nValor inválido! Tente novamente!\n");
    goto _idSet;
}


Console.Write("\nCargo: ");
fun.cargo = Console.ReadLine();

string opc;

_regE:
Console.WriteLine("\nDeseja registrar a ENTRADA?\n[S] Sim\n[N] Não\n");
opc = Console.ReadLine().ToUpper();

switch (opc)
{
    case "S":
        c.RegistrarEntrada(fun);
        break;
    case "N":
        goto _fim;
    default:
        Console.WriteLine("\nErro: opção inválida! Tente novamente!\n");
        goto _regE;
}

_regS:
Console.WriteLine("\nDeseja registrar a SAÍDA?\n[S] Sim\n[N] Não\n");
opc = Console.ReadLine().ToUpper();

switch (opc)
{
    case "S":
        c.RegistrarSaida(fun);
        break;
    case "N":
        goto _fim;
    default:
        Console.WriteLine("\nErro: opção inválida! Tente novamente!\n");
        goto _regS;
}


_fim:
Console.WriteLine("\nTecle espaço para continuar...");
Console.ReadKey();
