
using ObjectOrientedProgrammingH1day6.Files;
string firstName;
string lastName;
int age;
string email;
bool isMacthingTheConditions = true;


while (true) 
{
    Console.WriteLine("Indtast fornavn: ");
    try
    {
        firstName = Console.ReadLine();
        if (firstName == null || firstName.Length == 0)
            throw new InvalidNameException("Fornavn må ikke være tomt");
        break;
    }
    catch (InvalidNameException ex1)
    {
        Console.WriteLine($"Fejl {ex1}");
        isMacthingTheConditions = false;
    }
    catch (Exception ex2)
    {
        Console.WriteLine($"Fejl {ex2}");
        isMacthingTheConditions = false;
    }
    {


    }
}
while (true)
{
    Console.WriteLine("Indtast efternavn: ");
    try
    {
        lastName = Console.ReadLine();
        if (lastName == null || lastName.Length == 0)
            throw new InvalidNameException("efternavn må ikke være tomt");
        break;
    }
    catch (InvalidNameException ex3)
    {
        Console.WriteLine($"Fejl {ex3}");
        isMacthingTheConditions = false;
    }
    catch (Exception ex4)
    {
        Console.WriteLine($"Fejl {ex4}");
        isMacthingTheConditions = false;
    }
    {


    }
}
while (true)
{
    Console.WriteLine("Indtast din alder: ");
    try
    {
        age = int.Parse(Console.ReadLine());
        if (age < 18 || age >50) 
            throw new InvalidAgeException("Din alder skal være mellem 18 og 50");
        break;
    }
    catch (InvalidAgeException ex5) when (!(firstName.ToLower() == "niels" || lastName.ToLower() == "olesen"))
    {
        Console.WriteLine($"Fejl {ex5}");
        isMacthingTheConditions = false;
    }
    catch (Exception ex6)
    {
        Console.WriteLine("Det er jo dig Niels");
        
    }
    {


    }
}
while (true)
{
    Console.WriteLine("Indtast email: ");
    try
    {
        email = Console.ReadLine();
        if (email == null || email.Length == 0 || !email.Contains("@") || !email.Contains("."))
            throw new InvalidEmailException("email må ikke være tomt");
        break;
    }
    catch (InvalidEmailException ex7)
    {
        Console.WriteLine($"Fejl {ex7}");
        isMacthingTheConditions = false;
    }
    catch (Exception ex8)
    {
        Console.WriteLine($"Fejl {ex8}");
        isMacthingTheConditions = false;
    }
    {


    }
}
if (isMacthingTheConditions)
{
    User newUser = new User(firstName, lastName, age, email);
    string binDirectory = AppDomain.CurrentDomain.BaseDirectory;
    string projectRootDirectory = Path.GetFullPath(Path.Combine(binDirectory, @"..\..\..\"));
    string usersFilePath = Path.Combine(projectRootDirectory, "Files", "Users.txt");

    try
    {

        File.AppendAllText(usersFilePath, $"{newUser.firstName}, {newUser.lastName}, {newUser.age}, {newUser.email}" + Environment.NewLine);
    }
    catch
    {
        using (FileStream fs = File.Create(usersFilePath))
        {

        }
        File.AppendAllText(usersFilePath, $"{newUser.firstName}, {newUser.lastName}, {newUser.age}, {newUser.email}" + Environment.NewLine);
    }
}



