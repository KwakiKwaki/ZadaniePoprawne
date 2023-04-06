using System.ComponentModel.Design;

string name = "Monika";
string sex = "Kobieta";
var age = 15;

if (sex == "Kobieta" && age < 30)
{
    Console.WriteLine("Kobieta przed 30");
}
else if (name == "Monika" && age == 33)
{
    Console.WriteLine("Monika lat 33");
}
else if (age < 18 && sex != "Kobieta")
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}

