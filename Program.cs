// This is a comment to my code
//rakendus küsib kasutajal sisestada nime
//rakendus tervitab kasutajat nimepidi

Console.WriteLine("Enter your name");
//sting - sõne
string userName;

userName = Console.ReadLine();

Console.WriteLine("Hello" + ", " + userName + "!");
//string interpolation
Console.WriteLine($"Hello, {username} !");

