Console.WriteLine("Vad är ditt namn? ");
string name = Console.ReadLine();
Console.WriteLine("Hur gammal är du? ");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Did you have your breakfast?");
Console.WriteLine("Press Y for yes");
Console.WriteLine("Press N for no");
   
string answer = Console.ReadLine().ToUpper();
Console.WriteLine($"Hello,my name is {name} and I am {age} years old.");
bool isHungry = answer == "N";
if (isHungry)
{
    Console.WriteLine("By the way I am hungry!");
}
