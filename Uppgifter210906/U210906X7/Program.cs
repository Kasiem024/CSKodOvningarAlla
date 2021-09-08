using System;
//Be användaren mata in en mening.
//Översätt den enligt Leet Speak (när det finns flera alternativ i tabellen, välj själv så det bara är 1-1)
//Skapa ett nytt publikt repo i GitHub U210906X1
//OBS skapa ingen ReadMe
//Anslut nu ditt GitHub repo till din lokala mapp
//Pusha upp ditt lokala arbete till ditt GitHub repo

namespace U210906X7
{
    class Program
    {
        static void Main(string[] args)
        {
            string alphabet = "A B C D E F G H I J K L M N O P Q R S T U V W X Y Z";
            string[] alphabetSplit = alphabet.Split(" ");
            string leetSpeak = "4 8 ( |) 3 |# 6 |-| ! _) |( 1 |\\\\/| |\\\\| 0 |> ? |2 5 + |_| \\\\/ \\\\|/ % `/ 7_";
            string[] leetSpeakSplit = leetSpeak.Split(" ");
            string[,] array2D = new string[26, 2];

            for (int i = 0; i <= alphabetSplit.Length - 1; i++)
            {
                array2D[i, 0] = alphabetSplit[i];
                array2D[i, 1] = leetSpeakSplit[i];
            }
            Console.WriteLine(array2D[0,1]);
        }
    }
}