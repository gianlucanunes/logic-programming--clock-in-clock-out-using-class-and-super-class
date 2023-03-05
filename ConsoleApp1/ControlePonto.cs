public class ControlePonto
{
    public void RegistrarEntrada(Funcionario f)
    {
        DateTime data = DateTime.Now;

        Console.WriteLine($"\n--=-- Entrada --=--" +
            $"\nHorário de entrada: {data}" +
            $"\nFuncionário: {f.nome}" +
            $"\nCódigo do funcionário: {f.codigo}" +
            $"\nSetor: {f.NomeSetor}" +
            $"\nID do setor: {f.IdSetor}" +
            $"\nCargo: {f.cargo}");
    }

    public void RegistrarSaida(Funcionario f)
    {
        DateTime data = DateTime.Now;

        Console.WriteLine($"\n--=-- Saída --=--" +
            $"\nHorário de saída: {data}" +
            $"\nFuncionário: {f.nome}" +
            $"\nCódigo do funcionário: {f.codigo}" +
            $"\nSetor: {f.NomeSetor}" +
            $"\nID do setor: {f.IdSetor}" +
            $"\nCargo: {f.cargo}");
    }
}

