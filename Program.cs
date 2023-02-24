
Console.Write("Enter your name: ");
string name = Console.ReadLine();
string greeting = $"Hello! {name}";
Console.WriteLine(greeting);

Console.Write("Enter your age: ");
string ageAsString = Console.ReadLine();
Console.WriteLine("Converting");
int age = Convert.ToInt32(ageAsString);
Console.WriteLine($"Succesfully converted  {age}");

int keschasAge = 3;
int ageDiffernece = age - keschasAge;
Console.WriteLine($"The difference between your and keschas age is {ageDiffernece}");

string message = 
    keschasAge<=age
        ? "You are older than or equal to KESCHA"
        : "You are younger than KESCHA";

System.Console.WriteLine(message);

System.Console.WriteLine("Let me tell you about my friends.");

string[] friendsName = {"Vasya", "Kasee", name};
int[] friendsage = {1,2,age};

foreach(string fName in friendsName)
{
    System.Console.WriteLine(fName);
}

for (int i = 0; i < friendsName.Length; i++)
{
    System.Console.WriteLine($"{friendsName[i]} is {friendsage[i]} years old!");
    
}
/*  
System.Console.WriteLine($"You are older than KESCHA: {age>keschasAge}");
System.Console.WriteLine($"You are younger than KESCHA: {age<keschasAge}");
System.Console.WriteLine($"You are older than or equal to KESCHA: {age>=keschasAge}");
System.Console.WriteLine($"You are younger than or equal to KESCHA: {age<=keschasAge}");
System.Console.WriteLine($"Your age is equal to KESCHAs age: {age==keschasAge}");
System.Console.WriteLine($"Your age is not equal to KESCHAs age: {age!=keschasAge}");
*/



