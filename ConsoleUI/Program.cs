

string firstName = "";
Console.Write("Nombre: ");
firstName = Console.ReadLine();

Console.Write("Apellido: ");
string lastName = Console.ReadLine();

if (firstName.ToLower() == "héctor" && lastName.ToLower() =="sandoval")
{
    Console.WriteLine("Soy yo");
}
else if (firstName.ToLower() == "claudia")
{
    Console.WriteLine("Es Claudia");

}else
{
    Console.WriteLine("Es otra persona");
}

if ((firstName.ToLower() == "héctor" || firstName.ToLower() == "claudia") && lastName.ToLower()=="sandoval")
{
    Console.WriteLine("Hola familia Sandoval");
}
else
{
    Console.WriteLine("Hola extraño");
}

if (firstName.ToLower() != "héctor" )
{
    Console.WriteLine("No es Héctor");
}

int age = 0;
Console.Write("Age: ");
string ageAsked = Console.ReadLine();
bool result = int.TryParse(ageAsked, out age); 
if (age > 40)
{
    Console.WriteLine("La edad es mayor que 40.");
}

string phoneNumber = "5554-555-333";

switch(firstName.ToLower())
{
    case "héctor":
        Console.WriteLine("Soy yo");
        break;
    case "claudia":
        Console.WriteLine("Es Claudia");
        break;
    default:
        Console.WriteLine("Hola Extraño");
        break ;
}

if (firstName.ToLower()=="héctor")
{
    Console.WriteLine("Hola campéon");
}
else
{
    Console.WriteLine("Hola estudiante");
}