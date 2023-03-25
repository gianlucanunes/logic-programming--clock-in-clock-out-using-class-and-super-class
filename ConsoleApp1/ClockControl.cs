public class ClockControl
{
    public void ClockIn(Employee e)
    {
        DateTime Date = DateTime.Now;

        Console.WriteLine($"\n--=-- Clock In --=--" +
            $"\nClock In Date: {Date}" +
            $"\nEmployee Name: {e.Name}" +
            $"\nEmployee Code: {e.Code}" +
            $"\nDepartment: {e.NameDepartment}" +
            $"\nDepartment ID: {e.IdDepartment}" +
            $"\nFunction: {e.Function}");
    }

    public void ClockOut(Employee e)
    {
        DateTime Date = DateTime.Now;

        Console.WriteLine($"\n--=-- Clock Out --=--" +
            $"\nClock Out Date: {Date}" +
            $"\nEmployee Name: {e.Name}" +
            $"\nEmployee Code: {e.Code}" +
            $"\nDepartment: {e.NameDepartment}" +
            $"\nDepartment ID: {e.IdDepartment}" +
            $"\nFunction: {e.Function}");
    }
}

