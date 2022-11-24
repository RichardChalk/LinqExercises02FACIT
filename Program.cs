//I följande uppgifter skall LINQ/LAMBDA användas för att göra urval från listor och
//arrayer. Ex bilar.Where(r=>r…..)

// ////////////////////////////////////////////////////////////////////////////
//BILAR
string[] cars = { "Volvo", "BMW", "Audi", "Skoda", "Toyota", "Ford", "Mercedes","Seat", "Honda", "Volkswagen","Opel", "Mazda","Suzuki" };

//a.Ta fram den bil som heter ”Opel” från arrayen. 
var myOpel = cars.FirstOrDefault(b =>  b == "Opel");
var myOpel2 = cars.FirstOrDefault(b =>  b == "Opel".ToLower());
var myOpel3 = cars.FirstOrDefault(b =>  b.Equals("Opel", StringComparison.OrdinalIgnoreCase));
Console.WriteLine("Bil A:");
Console.WriteLine(myOpel);
Console.WriteLine("---------------------------------");

//b. Ta fram alla bilar vars namn börjar på ”V”.
var carsStartingWithW = cars.Where(b => b.StartsWith("V")).ToList();
Console.WriteLine("Bil B:");
foreach (var car in carsStartingWithW)
{
    Console.WriteLine(car);
}
Console.WriteLine("---------------------------------");

//c. Ta fram alla bilar vars namn innehåller bokstäverna ”da”.
var carsContainingDA = cars.Where(b => b.Contains("da")).ToList();
Console.WriteLine("Bil C:");
foreach (var car in carsContainingDA)
{
    Console.WriteLine(car);
}
Console.WriteLine("---------------------------------");

//d. Ta fram alla bilar som börjar på ”M” eller som slutar på ”i”
var carsStartingWithMEndingWithI = cars.Where(b => b.StartsWith("M") || b.EndsWith("i")).ToList();
Console.WriteLine("Bil D:");
foreach (var car in carsStartingWithMEndingWithI)
{
    Console.WriteLine(car);
}
Console.WriteLine("---------------------------------");

// ////////////////////////////////////////////////////////////////////////////
//2. BAND
string[] bands = { "ACDC", "Queen", "Aerosmith", "Iron Maiden", "Megadeth", "Metallica", "Pearl Jam", "Oasis", "Abba", "Blur", "Eurythmics", "Genesis", "INXS", "Midnight Oil", "Kent", "Madness", "Manic Street Preachers", "The Offspring", "Pink Floyd", "Rammstein", "Red Hot Chili Peppers", "Deep Purple", "U2"};

//a.Ta fram det band som har längst bandnamn
// First sort DESCENDING THEN take the first band in the list.... this will be the longest
var longestBand = bands.OrderByDescending(bands => bands.Length).FirstOrDefault();

Console.WriteLine("Band A:");
Console.WriteLine(longestBand);
Console.WriteLine("---------------------------------");

//b. Ta fram det band som har kortast bandnamn
// First sort ASCENDING THEN take the first band in the list.... this will be the longest
var shortestBand = bands.OrderBy(bands => bands.Length).FirstOrDefault();

Console.WriteLine("Band B:");
Console.WriteLine(shortestBand);
Console.WriteLine("---------------------------------");

//c. Ta fram en siffra på hur många band som börjar på bokstaven ”M”
var startsWithM = bands.Where(bands => bands.StartsWith("M")).Count();
var startsWithM2 = bands.Count(bands => bands.StartsWith("M")); // 2nd solution

Console.WriteLine("Band C:");
Console.WriteLine(startsWithM);
Console.WriteLine("---------------------------------");

//d. Ta ut en lista på alla band sorterad i bokstavsordning.
//Visa bara band som har ett bandnamn som är längre än 6 bokstäver
var longerThanSix = bands.Where(b => b.Count() > 6).ToList();
Console.WriteLine("Band D:");
foreach (var band in longerThanSix)
{
    Console.WriteLine(band);
}
Console.WriteLine("---------------------------------");

//e. Skapa en lista som sorteras på längden på banden namn.
//Det band med kortast namn skall hamna först i listan och det med längst namn skall hamna sist
var sortedList = bands.OrderBy(bands => bands.Length).ToList();

Console.WriteLine("Band E:");
foreach (var band in sortedList)
{
    Console.WriteLine(band);
}
Console.WriteLine("---------------------------------");

// ////////////////////////////////////////////////////////////////////////////
//LAMBDA
List<int> myIntegers = new List<int> { 54, 23, 76, 123, 93, 7, 3489, 88 };

//a.Ta fram medelvärdet av alla tal utan att loopa igenom listan.
var findAverage = myIntegers.Average();
Console.WriteLine("LAMBDA A:");
Console.WriteLine(findAverage);
Console.WriteLine("---------------------------------");

//b. Ta fram det största av alla tal utan att loopa igenom listan.
var maxNum = myIntegers.Max();
Console.WriteLine("LAMBDA B:");
Console.WriteLine(maxNum);
Console.WriteLine("---------------------------------");

//c. Ta fram det minsta av alla tal utan att loopa igenom listan.
var minNum = myIntegers.Min();
Console.WriteLine("LAMBDA C:");
Console.WriteLine(minNum);
Console.WriteLine("---------------------------------");

//d. Beräkna summan av alla tal.
var sum = myIntegers.Sum();
Console.WriteLine("LAMBDA D:");
Console.WriteLine(sum);
Console.WriteLine("---------------------------------");

//e. Ta fram alla jämna tal utan att loopa igenom listan
var evens = myIntegers.Where(num => num% 2 == 0);
Console.WriteLine("LAMBDA E:");
foreach (var even in evens)
{
    Console.WriteLine(even);
}
Console.WriteLine("---------------------------------");

//F. LAMBDA Order by 
//Sortera på efternamn (sista split ‘ ‘) utan att använda någon loop
//OBS: .Split() creates a new array.
// As we want to choose the surname we need to collect the LAST item in the array
// Second item = index 1 (name.Split(' ').Last())
// OBS: This even works for names like "Richard E Chalk" (will sort on 'Chalk')
string[] namnLista = { "Karl Folkesson", "Sven Karlsson", "Greta Blom", "Richard E Chalk" };
Console.WriteLine("LAMBDA F:");
var sortedBySurname = namnLista.OrderBy(name => name.Split(' ').Last());
foreach (var name in sortedBySurname)
{
    Console.WriteLine(name);
}
Console.WriteLine("---------------------------------");

//G. NY LISTA
//Skapa en ny lista från denna array där alla värden ökats med 2 dvs nya listan blir 3,5,7,9
int[] intList = { 1, 3, 5, 7 };
Console.WriteLine("LAMBDA G:");
var newList = intList.Select(num => num+2);
foreach (var num in newList)
{
    Console.WriteLine(num);
}
Console.WriteLine("---------------------------------");


//H. VOKALER

//Skapa en lista med alla vokaler ur meningen
string fullText = "Flygande Abeckasiner söka whila på mjuka tufvor";
Console.WriteLine("LAMBDA H:");

char[] allVowels = new[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'};

// Show ALL vowels
var vowels = fullText.Where(v => allVowels.Contains(v));
// Show distinct vowels only!
var vowelsDistinct = fullText.Where(v => allVowels.Contains(v)).Distinct();
foreach (var letter in vowelsDistinct)
{
    Console.WriteLine(letter);
}
Console.WriteLine("---------------------------------");





