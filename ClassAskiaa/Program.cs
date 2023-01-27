//Askiaa J. Nash CPS3320 SECTION 01 LAB #2
string name;
int numOfNums;
int fn;
int secn;
int trd;
int i = 0;
Console.WriteLine("Please enter your name below: ");
name = Convert.ToString(Console.ReadLine());

Console.WriteLine("Hello, {0}!",name);
while (i < 1)
{
    Console.WriteLine("Please enter the amount of numbers you would like to enter below(Either 2 or 3): ");
    numOfNums = Convert.ToInt32(Console.ReadLine());

    if (numOfNums == 2)
    {
        Console.WriteLine("Please enter your first number: ");
        fn = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter your second number: ");
        secn = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("{0} x {1} = {2}", fn, secn, Unit1_Mine.AskiaaClass.Multiply(fn, secn));
        i++;
    }

    if (numOfNums == 3)
    {
        Console.WriteLine("Please enter your first number: ");
        fn = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter your second number: ");
        secn = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter your third number: ");
        trd = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("{0} x {1} x {3}= {2}", fn, secn, Unit1_Mine.AskiaaClass.MultiplyThree(fn, secn, trd), trd);
        i++;
    }
    if(numOfNums !=2 && numOfNums != 3) {
        Console.WriteLine("ATTENTION! Please enter a valid number.");
    }
}