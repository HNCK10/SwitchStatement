// See https://aka.ms/new-console-template for more information
//Switch = an alternative to many if statements
//Look at this example and let us see how we can simplify it
//--------------------------------------------------------------------
//Console.WriteLine("What day is it today?");
//String day = Console.ReadLine();
//String day2;
//if (day == "")
//{
//    Console.WriteLine("Enter the day!");
//    day2 = Console.ReadLine(); 
//    if (day2 != "")
//    {
//        Console.WriteLine("Thank you");
//    }
//}
//else if (day == "Monday")
//{
//    Console.WriteLine("It's Monday!");
//}
//else if (day == "Tuesday")
//{
//    Console.WriteLine("It's Tuesday");
//}
//else if (day == "Wednesday")
//{
//    Console.WriteLine("It's Wednesday");
//}
//else if (day == "Thursday")
//{
//    Console.WriteLine("It's Thursday");
//}
//else if (day == "Friday")
//{
//    Console.WriteLine("It's Friday");
//}
//else if (day == "Saturday")
//{
//    Console.WriteLine("It's Saturday");
//}
//else if (day == "Sunday")
//{
//    Console.WriteLine("It's Sunday");
//}
Console.WriteLine("What day is it today?");
String day = Console.ReadLine();
//Within parenthesis we will place what we would like to examine
//if match, execute block of code, add break to exit the switch
switch (day)
{   case "Monday":
        Console.WriteLine("It's Monday!");
        break;
    case "Tuessday":
        Console.WriteLine("It's Tuesday!");
        break;
    case "Wednesday":
        Console.WriteLine("It's Wednesday!");
        break;
    case "Thursday":
        Console.WriteLine("It's Thursday!");
        break;
    case "Friday":
        Console.WriteLine("It's Friday!");
        break;
    case "Saturday":
        Console.WriteLine("It's Saturday!");
        break;
    case "Sunday":
        Console.WriteLine("It's Sunday!");
        break;
    default:
        Console.WriteLine(day + " is not a day!");
        break;
}
Console.ReadKey();