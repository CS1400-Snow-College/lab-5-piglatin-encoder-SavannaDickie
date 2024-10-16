// See https://aka.ms/new-console-template for more information

// Savanna Dickie
// 10/15/2024
// Lab 5 piglatin encoder


using System.Reflection.Metadata;

char[] vowel = {'a','e','i','o','u'};
char[] consonant = {'b','c','d','f','g','h','j','k','l','m','n','p','q','r','s','t','v','w','x','y','z'};
Console.WriteLine("Welcome to the PigLatin Cryptogram\nThis program is going to translate your message into pig Latin,\nthen it will encrypt the message into a Cryptogram.");
Console.WriteLine("Please enter the message: ");
string? userMessage = Console.ReadLine();

string[] userMessageArray = userMessage.Split(' ');
//Console.WriteLine(userMessageArray);
foreach (string word in userMessageArray)
{
    string pigLatinWord;
    string enCode = word.ToLower();
    Console.WriteLine(word);
    //if (word.Contains(vowel[])) starts or ends with vowel
    if (vowel.Contains(enCode[0]) && vowel.Contains(enCode[enCode.Length -1]))
    {
        pigLatinWord = "";
        pigLatinWord = enCode + "way";
        Console.WriteLine(pigLatinWord);
    }
    else
    {
        //char[] consonant = {'b','c','d','f','g','h','j','k','l','m','n','p','q','r','s','t','v','w','x','y','z'};
        int consonantCluster = 0;
       // while(consonantCluster.contains(vowels++) < lowerCase.Length && )
       //while(consonant != lowerCase.Length && !vowels.Contain(consonant));
       //while (consonantCluster < enCode.Length && !vowel.Contains(enCode[consonantCluster]))
       while(consonantCluster < enCode.Length && consonant.Contains(enCode[consonantCluster]))
       {
        //consonantCluster = lowerCase++
        //lowerCase = consonantCluster++;
        consonantCluster++;
       }
    //string removal;
    string removal = enCode.Substring(consonantCluster); 
    string mixLetters = enCode.Substring(0, consonantCluster);
    string pigLatin = "ay";
    pigLatinWord = removal + mixLetters + pigLatin;

    }
    //Console.Write(string.Join("", pigLatinWord));
    //else if (consonant.Contains(lowerCase[0]))
    //Console.WriteLine(pigLatinWord)
    //Console.Write(string.Join(" ", pigLatinWord));
    
}
//Console.WriteLine(pigLatinWord)
 

//char[] vowel = {'a','e','i','o','u'};
//char[]
