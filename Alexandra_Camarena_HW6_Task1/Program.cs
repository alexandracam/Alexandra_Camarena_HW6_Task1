﻿// Alexandra Camarena
// MIS 3013 HW 6 Task 1

string str = "Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning.";
Console.WriteLine(str);

Console.Write("Please input the work that you are looking for: ");
string wordSearch = Console.ReadLine();

Console.Write("Please input the word that you want to replace with: ");
string wordReplace = Console.ReadLine();

if (str.Contains(wordSearch))
{
   string newStr = str.Replace(wordSearch, wordReplace);
    Console.WriteLine("The new sentence is: ");
   Console.WriteLine(newStr);
}
else
{
    string m = string.Format($"Sorry, I could not find your word {wordSearch} ");
    Console.WriteLine(m);

    for (int i = wordSearch.Length-1;i >=0 ;i -- )// i -- i = i - 1
    { 
        char c = wordSearch[i];
        Console.Write(c);
    }
}

