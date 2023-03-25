/*
 * 
 *      EN: Logic Programming Exercise: Clock Control.
 *      PT-BR: Exercício de Lógica de Programação: Controle de Ponto.
 *      
 *      Created by / Feito por: Gianluca Nunes
 *
 */

Console.WriteLine("------ Clock Control ------\n");


// Creating the Employee object
Employee emp = new Employee();
// Creating the clock object
ClockControl c = new ClockControl();


// Asking the user for the employee info
Console.WriteLine("Please, fill the form bellow:");

Console.Write("\nEmployee Name: ");
emp.Name = Console.ReadLine();

// Validating the Employee Id
_empCode:
Console.Write("\nEmployee ID: ");
int code;
if (int.TryParse(Console.ReadLine(), out code))
{
    emp.Code = code;
}
else
{
    Console.WriteLine("\nIncorrect Input! Please, try it again.");
    goto _empCode;
}

Console.Write("\nDepartment Name: ");
emp.NameDepartment = Console.ReadLine();

// Validating the Department Id
_depId:
Console.Write("\nDepartment ID: ");
int id;
if (int.TryParse(Console.ReadLine(), out id))
{
    emp.IdDepartment = id;
}
else
{
    Console.WriteLine("\nIncorrect Input! Please, try it again.");
    goto _depId;
}

Console.Write("\nEmployee Function: ");
emp.Function = Console.ReadLine();

// Asking the user if he wants to Clock In
string opt;
_clockIn:
Console.WriteLine("\nDo you want to Clock In?\n[Y] Yes\n[N] No\n");
opt = Console.ReadLine().ToUpper();

switch (opt)
{
    case "Y":
        c.ClockIn(emp);
        break;
    case "N":
        goto _end;
    // Validating the user input
    default:
        Console.WriteLine("\nIncorrect option! Please, try it again.");
        goto _clockIn;
}

// Asking the user if he wants to Clock Out
_clockOut:
Console.WriteLine("\nDo you want to Clock Out?\n[Y] Yes\n[N] No\n");
opt = Console.ReadLine().ToUpper();

switch (opt)
{
    case "Y":
        c.ClockOut(emp);
        break;
    case "N":
        goto _end;
    // Validating the user input
    default:
        Console.WriteLine("\nIncorrect option! Please, try it again.");
        goto _clockOut;
}

_end:
Console.WriteLine("\nPress space to close the program...");
Console.ReadKey();
