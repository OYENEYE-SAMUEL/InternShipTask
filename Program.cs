//Task 1
string name = "John Doe";
int age = 25;
bool isAdmin = true;

//Task 2
Console.WriteLine("Enter an integer number");
int input = int.Parse(Console.ReadLine());
if (input % 2 == 0)
{
    Console.WriteLine("Thus, your number is even number");
}
else
{
    Console.WriteLine("The input number is odd number");
}

//Task 3
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}

//Task 4
int[] array = {2, 4, 6, 8, 10};
int sum = 0;
foreach (var item in array)
{
    sum += item;  
}
Console.WriteLine(sum);

//Task 5
string name = "Alice";
string result = (Greet(name));
Console.WriteLine(result);


static string Greet(string name)
{
    return $"Hello, !{name}";
}
