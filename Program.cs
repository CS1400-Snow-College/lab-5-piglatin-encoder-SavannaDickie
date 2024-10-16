// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// Savanna Dickie
// 10/15/2024
// Lab 5 piglatin encoder

Console.WriteLine("Welcome to the PigLatin Cryptogram\nThis program is going to translate your message into pig Latin,\nthen it will encrypt the message into a Cryptogram.");
Console.WriteLine("Please enter the message: ");
string? userMessage = Console.ReadLine();

string[] userMessageArray = userMessage.Split(' ');
//Console.WriteLine(userMessageArray);
foreach (string word in userMessageArray)
{
    Console.WriteLine(word);
}


//char[] vowel = {'a','e','i','o','u'};
//char[]
