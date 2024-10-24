// See https://aka.ms/new-console-template for more information

// Savanna Dickie
// 10/15/2024
// Lab 5 piglatin encoder


using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Runtime.ConstrainedExecution;
using System.Text;

char[] vowels = {'a','e','i','o','u'};
//char[] consonants = {'b','c','d','f','g','h','j','k','l','m','n','p','q','r','s','t','v','w','x','y','z'};
Console.WriteLine("Welcome to the Pig Latin Cryptogram\nThis program is going to translate your message into pig Latin,\nthen it will encrypt the message into a Cryptogram.");
Console.WriteLine("\nPlease enter the message: ");
string? userMessage = Console.ReadLine().Trim('!','.'); 

//string userMessage = userMessage.Trim('!','.');
string[] userMessageArray = userMessage.Split(' ');
string pigLatinTranslate = ""; //madlibs
//Console.WriteLine(userMessageArray);
foreach (string word in userMessageArray) //chapter 12
{
    string pigLatinWord;
    string words = word.ToLower(); //hw15
   
    if (vowels.Contains(words[0])) //|| consonantCluster != 0)
    {
        pigLatinWord = words + "way";
    }
    else
    {
        int vowelCheck = words.IndexOfAny(vowels); 

        if (vowelCheck == -1)//(consonantCluster == 1) //last hw
        {
            //pigLatinWord = enCode + "ay";
            pigLatinWord = words.Substring(1) + words[0] + "ay"; //this works for 'my' SAVANNA keep this code this is not the problem
        }
        else
        {
            //hw 15
            string removal = words.Substring(vowelCheck); 
            string switchLetters = words.Substring(0, vowelCheck);
            //string pigLatin = "ay";
            pigLatinWord = removal + switchLetters + "ay";
        }
    }
    pigLatinTranslate += pigLatinWord + " ";
}
Console.WriteLine($"\nIn pig latin that's: {pigLatinTranslate.Trim()}");
//Random rand = new Random();
//string crypto = pigLatinTranslate;
string crypto = "";
//if (char.Contains(0,26))
foreach (char c in pigLatinTranslate)
{
    //c = (char)((int)pigLatinTranslate + 5)
    //offsetTranslation = (char)((int) offsetTranslation + 5);
    char letter = c;
    //string nonLetter = " ";
    //if (letter != letter && nonLetter.Contains(" "))
    //if (char.Equals(" "))
    if (char.IsLetter(letter))//(nonLetter))
    letter = (char)((int)letter + 5);
    if(letter > 'z')
    {
        letter = (char)((int)letter - 26);
    }
    //char.Replace(crypto, letter)// += letter;
    crypto += letter;
}
Console.WriteLine();
Console.WriteLine($"We can encrypt that as: {crypto}");
Console.WriteLine();


//Console.WriteLine(pigLatinWord)
 

 //if (consonantCluster == 1)
 //{
 //   pigLatinWord = enCode.Substring(1) + enCode[0] + "ay";
 //}

//char[] vowel = {'a','e','i','o','u'};
//char[]
/*char[] vowels = {'a','e','i','o','u'};
char[] consonants = {'b','c','d','f','g','h','j','k','l','m','n','p','q','r','s','t','v','w','x','y','z'};
Console.WriteLine("Welcome to the PigLatin Cryptogram\nThis program is going to translate your message into pig Latin,\nthen it will encrypt the message into a Cryptogram.");
Console.WriteLine("Please enter the message: ");
string? userMessage = Console.ReadLine();

string[] userMessageArray = userMessage.Split(' ');
string pigLatinEncode = "";
//Console.WriteLine(userMessageArray);
foreach (string word in userMessageArray)
{
    string pigLatinWord;
    string enCode = word.ToLower();
    //string pigLatinWord = " ";
    //Console.WriteLine(word);
    //string pigLatinWord = "";
    //if (word.Contains(vowel[])) starts or ends with vowel
    //if (vowels.Contains(enCode[0]) && vowels.Contains(enCode[enCode.Length -1]))
    if (vowels.Contains(enCode[0]))
    {
        //pigLatinWord = "";
        pigLatinWord = enCode + "way";
        //Console.WriteLine(pigLatinWord);
    }
    else
    {
        //char[] consonant = {'b','c','d','f','g','h','j','k','l','m','n','p','q','r','s','t','v','w','x','y','z'};
        int consonantCluster = 0;
       // while(consonantCluster.contains(vowels++) < lowerCase.Length && )
       //while(consonant != lowerCase.Length && !vowels.Contain(consonant));
       //while (consonantCluster < enCode.Length && !vowel.Contains(enCode[consonantCluster]))
       while(consonantCluster < enCode.Length && consonants.Contains(enCode[consonantCluster]))
       {
        //consonantCluster = lowerCase++
        //lowerCase = consonantCluster++;
        consonantCluster++;
       }
    //string removal;
    string removal = enCode.Substring(consonantCluster); 
    string switchLetters = enCode.Substring(0, consonantCluster);
    //string pigLatin = "ay";
    pigLatinWord = removal + switchLetters + "ay";

    }

    //Console.Write(string.Join("", pigLatinWord));
    //else if (consonant.Contains(lowerCase[0]))
    //Console.WriteLine(pigLatinWord)
    //Console.Write(string.Join(" ", pigLatinWord));
    //Console.Write(pigLatinWord + " ");
    //string final = pigLatinWord + " ";
    //pigLatinEncode += final;
    pigLatinEncode += pigLatinWord + " ";
}
Console.WriteLine(pigLatinEncode.Trim());

Console.WriteLine(); */