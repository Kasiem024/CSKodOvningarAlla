using System;
//Be användaren mata in en mening.
//Översätt den enligt Leet Speak (när det finns flera alternativ i tabellen, välj själv så det bara är 1-1)
//Skapa ett nytt publikt repo i GitHub U210906X1
//OBS skapa ingen ReadMe
//Anslut nu ditt GitHub repo till din lokala mapp
//Pusha upp ditt lokala arbete till ditt GitHub repo
//Skapa två array för varje alfabet. Läser meningen som en chararray konverterar till string och sen tillbaka till char och skriver ut den som den förra uppiften.
//Jag vill att vad som användaren skriver in delas upp i bokstäver och sen jämförs med vad som finns i alfabetet. 
//Den jämför genom att jämföra varje bokstav i meningen med alfabetet

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

            //Försökte här göra något med 2D array men insåg senare att det inte behövs.
            /* string[,] array2D = new string[26, 2];

            for (int i = 0; i <= alphabetSplit.Length - 1; i++)
            {
                array2D[i, 0] = alphabetSplit[i];
                array2D[i, 1] = leetSpeakSplit[i];
            }*/

            Console.WriteLine("Skriv en mening på engelska med stora bokstäver som du vill översätta till Leet Speak.");//På engelska eftersom å ä ö inte finns.
            char[] letters = Console.ReadLine().ToCharArray();//Console.ReadLine förväntar sig en string men ToCharArray gör vad som matas in till char.
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
                sentenceLeet += leetSpeakSplit[Array.IndexOf(alphabetSplit, sentence[i])];//Letar i alphabetSplit efter bokstäverna som finns i meningen.
                                                                                          //alphabetSplit och LeetSplit är parallela, därför fungerar det här.
            }

            Console.WriteLine(sentenceLeet);
        }
    }
}