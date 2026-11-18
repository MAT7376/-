Console.Clear();
Console.ForegroundColor=ConsoleColor.Red;
Console.WriteLine("Tap to get the information of worker's salary");
Console.ForegroundColor=ConsoleColor.White;
Console.ReadKey(true);
await Task.Delay(2000);
Console.Clear();
Console.WriteLine("All the salaries are going to be counted with $3 for each hour");
Console.ForegroundColor=ConsoleColor.Red;
Console.WriteLine("\nPlease enter the number of hours the worker has worked");
Console.ForegroundColor=ConsoleColor.White;
await Task.Delay(2000);
try
{
    Console.Write("\nTime: ");
    var time=Convert.ToInt32(Console.ReadLine());
    var salary=time*3;
    var tax=salary*5/100;
    var recieved=salary-tax;
    await Task.Delay(2000);
    Console.Write("\nNet salary: $");
    Console.WriteLine(salary);
    await Task.Delay(1000);
    Console.Write("With a 5% tax: $");
    Console.WriteLine(tax);
    await Task.Delay(1000);
    Console.Write("Net amount recieved: $");
    Console.WriteLine(recieved);
}
catch(FormatException)
{
    Console.WriteLine("Invalid input, please enter a number");
}
catch(OverflowException)
{
    Console.WriteLine("Invalid input, please enter a right number");
}
catch
{
    Console.WriteLine("Invalid input, please try again");
}    
//base of project is done
//"try-catch" added