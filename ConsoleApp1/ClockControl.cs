// Creating the puclic class ClockControl
public class ClockControl
{
    // Creating a Void method to do the Clock In
    public void ClockIn(Employee e)
    {
        // Getting the system current date and time
        DateTime Date = DateTime.Now;

        Console.WriteLine($"\n--=-- Clock In --=--" +
            $"\nClock In Date: {Date}" +
            $"\nEmployee Name: {e.Name}" +
            $"\nEmployee Code: {e.Code}" +
            $"\nDepartment: {e.NameDepartment}" +
            $"\nDepartment ID: {e.IdDepartment}" +
            $"\nFunction: {e.Function}");
    }

    // Creating a Void method to do the Clock Out
    public void ClockOut(Employee e)
    {
        // Getting the system current date and time
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
