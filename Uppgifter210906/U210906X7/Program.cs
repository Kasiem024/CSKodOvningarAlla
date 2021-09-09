using System;
//Be användaren mata in en mening.
//Översätt den enligt Leet Speak (när det finns flera alternativ i tabellen, välj själv så det bara är 1-1)

namespace U210906X7
{
    class Program
    {
        static void Main(string[] args)
        {
            string alphabet = "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z, ";//Skapar en string med alla bokstäver förutom Å Ä Ö då de inte finns i Leet Speak.
            string[] alphabetSplit = alphabet.Split(",");//Gör ovan string till en array och splitar den.
            string leetSpeak = "4,8,(,|),3,|#,6,|-|,!,_),|(,1,|\\\\/|,|\\\\|,0,|>,?,|2,5,+,|_|,\\\\/,\\\\|/,%,`/,7_, ";
            string[] leetSpeakSplit = leetSpeak.Split(",");

            //Försökte här göra något med 2D array men insåg senare att det inte behövs. Denna for loop kombinerar de två ovan arrays till en 2D array.
            /* string[,] array2D = new string[26, 2];

            for (int i = 0; i <= alphabetSplit.Length - 1; i++)
            {
                array2D[i, 0] = alphabetSplit[i];
                array2D[i, 1] = leetSpeakSplit[i];
            }*/

            Console.WriteLine("Skriv en mening på engelska med stora bokstäver som du vill översätta till Leet Speak.");//På engelska eftersom å ä ö inte finns.
            char[] letters = Console.ReadLine().ToCharArray();//Console.ReadLine förväntar sig en string men ToCharArray gör vad som matas in till char. Har samma funktion som ConvertToInt32.
            string[] sentence = new string[letters.Length];//Gör en string som är lika lång som antalet bokstäver i den inmatade meningen.

            for (int i = 0; i < sentence.Length; i++)
            {
                sentence[i] = letters[i].ToString();//Konverterar char till string igen.
            }
            //Sentence just nu är en string och letters är char.

            for (int i = 0; i < sentence.Length; i++)
            {
                sentence[i] = sentence[i].ToUpper();//Gör så att datorn läser vad som än matades in till stora bokstäver eftersom string alphabet är bara stora bokstäver.
            }

            string sentenceLeet = "";//Skapas innan for loopen så att den kan användas efter den.

            for (int i = 0; i < sentence.Length; i++)
            {
                sentenceLeet += leetSpeakSplit[Array.IndexOf(alphabetSplit, sentence[i])];//Letar i alphabetSplit efter bokstäverna som finns i meningen.                                                                          //alphabetSplit och LeetSplit är parallela, därför fungerar det här.
            }

            for (int i = 0; i < sentence.Length; i++)
            {
                //Titta på vad som finns i array2D [i,0] och ersätt den med vad som finns i array2D [i,1]

                 

            }

            Console.WriteLine(sentenceLeet);
        }
    }
}