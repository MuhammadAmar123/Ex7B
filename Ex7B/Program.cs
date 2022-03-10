Console.WriteLine("Enter number from 0-100 to show grade: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num <= 39)
{
    Console.WriteLine("Grade is: E");
}
else if (num <= 49)
{
    Console.WriteLine("Grade is: D");
}
else if (num <= 56)
{
    Console.WriteLine("Grade is: C");
}
else if (num <= 63)
{
    Console.WriteLine("Grade is: C+");
}
else if (num <= 70)
{
    Console.WriteLine("Grade is: B");
}
else if (num <= 77)
{
    Console.WriteLine("Grade is: B+");
}
else if (num <= 84)
{
    Console.WriteLine("Grade is: A");
}
else if (num <= 100)
{
    Console.WriteLine("Grade is: A+");
}