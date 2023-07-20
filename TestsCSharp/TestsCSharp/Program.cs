
/*
float grade = 3.33f;
Console.WriteLine(grade);//wynik: 3.33


//Rzutowanie z float na int

int valueInteger = (int) grade;
Console.WriteLine(valueInteger);//wynik: 3, ucina do kropki

int valueInteger1 = (int)Math.Ceiling(grade);//zaokrąglam w górę i konwertuję na int
Console.WriteLine(valueInteger1);

int valueInteger2 = (int)Math.Floor(grade);//zaokrąglam w dół i konwertuję na int
Console.WriteLine(valueInteger2);


//Rzutowanie z int na float
float grade2 = (float) valueInteger1;
float grade3 = valueInteger1; //można też bezpośrednio przypisać
Console.WriteLine("int to float: " + grade3);
*/


//Konwersja z string na int
string ageString = "15";
Console.WriteLine("ageString: " + ageString);

int ageInt = int.Parse(ageString);
Console.WriteLine("ageInt: " + ageInt);

//Konwersja z string na int z informacja zwrotną
string ageString2 = "aa";

var testInt = int.TryParse(ageString2, out ageInt);

if (testInt)
{
    Console.WriteLine("Udało się sparsować z wartości string na int: " + ageInt);
}
else
{
    Console.WriteLine($"Nie udłao się sparsować wattości string: '{ageString2}' na int");
}


