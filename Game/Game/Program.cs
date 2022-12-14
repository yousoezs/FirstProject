using System;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using static System.Console;

namespace Game
{
//Skriv om DrawBox så den istället returnerar en 2D-array av char med tecknen som den tidigare skrev ut på displayen.
//Man ska också kunna mata in en tredje parameter för antal slumpade ‘#’.
//Om man anger t.ex 5 så ska 5 stycken extra ‘#’ slumpas ut på random ställen inne i boxen.
//Skriv sedan en annan metod som tar och ritar ut arrayen på skärmen.
//Fixa så man kan flytta runt @ med piltangenterna.
//Jämför positionen mot arrayen och gör så man inte kan gå på någon ‘#’.
    internal class Program
    {
        static void Main(string[] args)
        {
            //Här skriver användaren in 2 värden för att rita ut en box.
            DrawBox(80, 40);
        }
        static void DrawBox(int width, int height)
        {
            //Skapar en 2D Array för att få ut en y och x axel. där Height är Row(y) och width är x(column)
            //Efteråt skapar vi 2 variabler för att få ut mitten av boxen, därav att man delar width med 2 och height med 2.
            //Vi skapar även en playerIndex variabel, för att ha en index för själva "spelaren".
            while (true)
            {
                Clear();
                string[,] bigBox = new string[height, width];
                int widthMiddle = width / 2;
                int heightMiddle = height / 2;

                int[] playerIndex = new int[2] { heightMiddle, widthMiddle };
                bool wrongKey = false;

                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        //I första for loppen går vi igenom höjden, och i den andra går vi igenom bredden.
                        //För att hämta ut längden av höjden, så skapar vi en variabel jag har namngett length som är = height - 1.
                        //Inuti första if-satsen kollar vi om i(height) är == 0 eller om i(height) är == längden.
                        //om något av ovanstående är sant, så tillsätter vi i 2D Arrayen bigBox tecknet "#".
                        //Vi gör samma sak i de andra if-satserna med andra statements ex... att hitta ytkanterna samt mitten..
                        int length = height - 1;
                        if (i == 0 || i == length)
                        {
                            bigBox[i, j] = "#";
                        }
                        else if (j == 0 || j == width - 1)
                            bigBox[i, j] = "#";
                        else if (j == widthMiddle && i == heightMiddle)
                        {
                            bigBox[i, j] = "@";
                        }
                        else
                            bigBox[i, j] = "-";
                    }
                }
                //Här skapar vi 2 for loops för radbrytning med 2D Array.
                for (int i = 0; i < bigBox.GetLength(0); i++)
                {
                    for (int j = 0; j < bigBox.GetLength(1); j++)
                    {
                        Write(bigBox[i, j]);
                    }
                    WriteLine();
                }
                CursorVisible = false;

                //Här skapar vi själva spelaren som en variabel.
                var player = bigBox[playerIndex[0], playerIndex[1]];
                //Här skapar vi en while loop för rörelse av användaren.
                //en while loop för att kolla ifall fel knapp trycks in så stängs konsolen av.
                while (!wrongKey)
                {
                    //Vi skapar en ConsoleKeyInfo för att titta efter knapptryck i switch satsen.
                    //I varje case kollar vi ett knapptryck, vi nestlar in en if sats för att kolla index samt 
                    //justera vart CursorPosition är. För varje rörelse så ska indexet antingen ökas eller minskas med 1.
                    ConsoleKeyInfo keyPressed = ReadKey();
                    switch (keyPressed.Key)
                    {
                        case ConsoleKey.LeftArrow:
                            if (playerIndex[1] > 1)
                            {
                                SetCursorPosition(playerIndex[1], playerIndex[0]);
                                Write("-");
                                SetCursorPosition(playerIndex[1] - 1, playerIndex[0]);
                                Write(player);
                                playerIndex[1]--;
                            }
                            break;
                        case ConsoleKey.RightArrow:
                            if (playerIndex[1] < width - 2 )
                            {
                                SetCursorPosition(playerIndex[1], playerIndex[0]);
                                Write("-");
                                SetCursorPosition(playerIndex[1] + 1, playerIndex[0]);
                                Write(player);
                                playerIndex[1]++;
                            }
                            break;
                        case ConsoleKey.UpArrow:
                            if (playerIndex[0] > 1)
                            {
                                SetCursorPosition(playerIndex[1], playerIndex[0]);
                                Write("-");
                                SetCursorPosition(playerIndex[1], playerIndex[0] - 1);
                                Write(player);
                                playerIndex[0]--;
                            }
                            break;
                        case ConsoleKey.DownArrow:
                            if (playerIndex[0] < height - 2)
                            {
                                SetCursorPosition(playerIndex[1], playerIndex[0]);
                                Write("-");
                                SetCursorPosition(playerIndex[1], playerIndex[0] + 1);
                                Write(player);
                                playerIndex[0]++;
                            }
                            break;
                        default:
                            wrongKey = true;
                            break;
                    }
                }
            }
        }
    }
}