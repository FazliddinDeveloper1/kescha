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
