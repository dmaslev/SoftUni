using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Threading;
using System.Text;
using System.Threading.Tasks;


class FallingRocks
{
    /*Problem 12.	** Falling Rocks
    Implement the "Falling Rocks" game in the text console. 
    * A small dwarf stays at the bottom of the screen and can move left and right (by the arrows keys). 
    * A number of rocks of different sizes and forms constantly fall down and you need to avoid a crash.
    Rocks are the symbols ^, @, *, &, +, %, Java, #, !, ., ;, - distributed with appropriate density. 
    * The dwarf is (O). 
    * Ensure a constant game speed by Thread.Sleep(150).
     Implement collision detection and scoring system.
    */
    //WE DECIDE THE STRUCTURE OF OUR OBJECTS 
    struct Object
    {
        public int x;
        public int y;
        public ConsoleColor color;
        public string symbol;
        public bool collected;
        public int delay;
        public int dwarfLives;
    }

    //WE CREATE A METHOD FOR PRINTING OBJECTS (AND TEXT) ON THE GAME BOARD
    static void PrintObject(int x, int y, string symbol, ConsoleColor color = ConsoleColor.Red)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.WriteLine(symbol);
    }
    static void Main()
    {
        //WE DECIDE THE SIZE OF OUR PLAYFIELD
        int windowHeight = 34;
        int windowWidth = 41;
        int playfieldWidth = 25; // positions 0 to 24


        // WE REMOVE THE CONSOLE SCROLL BAR FOR THE GAME (buffer is the scroll bar pointer)
        Console.BufferHeight = Console.WindowHeight = windowHeight;
        Console.BufferWidth = Console.WindowWidth = windowWidth;

        // WE CREATE A NEW  OBJECT - OUR "DWARF" 
        Object dwarf = new Object();
        dwarf.x = playfieldWidth / 2;
        dwarf.y = Console.WindowHeight - 1;   // (0 is on the top row of Console, hight-1 is the bottom row of Console, 
        // point [0,0 ]is top-left of Console
        dwarf.color = ConsoleColor.Yellow;
        dwarf.symbol = ((char)2).ToString();
        dwarf.dwarfLives = 5;



        // WE CREATE A RANDOM GENERATOR ( for we want our rocks to fall on random placies) 
        // AND WE SAVE MEMORY FOR OUR RANDOM GENERATOR (by assainig to it new Random())
        Random randomGenerator = new Random();

        // WE CREATE AN EMPTY LIST OF OBGECTS AND SAVE MEMORY FOR THAT LIST 
        List<Object> listOfObjects = new List<Object>();

        //WE CREATE AN EMPTY ARRAY FOR THE GEMS , 
        //IN THE BEGINING OF THE GAME, THE DWARF HAS NO GERMS, SO WE ARE SETING THEM TO FALSE

        Object[] gem = new Object[11];
        for (int i = 0; i < 11; i++)
        {
            gem[i].collected = false;
        }

        Object gameSpeed = new Object();

        gameSpeed.delay = 250;
        PrintObject(11, 1, "< FALLING ROCKS >", ConsoleColor.Yellow);
        PrintObject(6, 4, "COLLECT ALL PROGRAMMER's GEMS ", ConsoleColor.Yellow);
        PrintObject(18, 6, "AND", ConsoleColor.Yellow);
        PrintObject(4, 8, "HELP THE DWARF TO AVOID THE ROCKS ", ConsoleColor.Yellow);
        PrintObject(15, 10, "ON HIS WAY", ConsoleColor.Yellow);
        PrintObject(6, 12, "TO BECOME A SOFTWARE ENGENEER!", ConsoleColor.Yellow);

        PrintObject(windowWidth / 2, 15, ((char)2).ToString(), ConsoleColor.Yellow);

        PrintObject(5, 17, "         DWARF's JEMS   \n\nHARD WORK                      " + (char)6 + "\nSHARP MAIND                    "
                   + (char)15 + "\nINTELIGENCE                    " + (char)5
                   + "\nBE FUNNY AND HUMORIOS          " + (char)14 + "\nLEARN C#                       C# "
                   + "\nLEARN JAVA                     Java  \nLEARN C++                      C++"
                   + "\nLEARN VB.NET                   VB.Net \nLEARN RUBY                     Ruby"
                   + "\nLEARN PYTHON                   Python \nLEARN PHP                      Php", ConsoleColor.Yellow);

        PrintObject(0, 31, "press [enter]  to play the game  \npress [escape] to exit", ConsoleColor.Cyan);

        ConsoleKeyInfo info = Console.ReadKey();
        if (info.Key == ConsoleKey.Escape)
        {
            return;
        }
        else
        {
            info = Console.ReadKey();
            if (info.Key == ConsoleKey.Enter)
            {
                while (true)
                {
                    //GAME RESULTS
                    //SUCSSESS - THE DWARF COLLECTED ALL 11 GEMS

                    if (gem[0].collected && gem[1].collected && gem[2].collected && gem[3].collected
                           && gem[4].collected && gem[5].collected && gem[6].collected
                           && gem[7].collected && gem[8].collected && gem[9].collected && gem[10].collected)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 200; j <= 3000; j += 400)
                            {
                                Console.Beep(j, 200);
                            }
                            Console.Beep(3400, 600);
                            Console.Beep(1000, 1000);
                        }


                        Console.Clear();
                        PrintObject(18, 6, ((char)2).ToString(), ConsoleColor.Yellow);

                        PrintObject(2, 10, "O, THANK YOU VERY MUCH MY DEAR FRIEND!", ConsoleColor.Cyan);
                        PrintObject(6, 12, "BECAUSE OF YOUR HELP", ConsoleColor.Cyan);
                        PrintObject(6, 14, "I'M ALREADY A COMPUTER PROFI!", ConsoleColor.Cyan);
                        PrintObject(14, 20, "GAME OVER!!!", ConsoleColor.Yellow);
                        PrintObject(6, 24, "press [enter]  to play the again", ConsoleColor.Cyan);
                        PrintObject(6, 26, "press [escape] to exit", ConsoleColor.Cyan);

                        listOfObjects.Clear();
                        for (int i = 0; i < 11; i++)
                        {
                            gem[i].collected = false;
                        }
                        gameSpeed.delay = 250;
                        dwarf = new Object();
                        dwarf.x = playfieldWidth / 2;
                        dwarf.y = Console.WindowHeight - 1;
                        dwarf.color = ConsoleColor.Yellow;
                        dwarf.symbol = ((char)2).ToString();
                        dwarf.dwarfLives = 5;

                        info = Console.ReadKey();
                        if (info.Key == ConsoleKey.Escape)
                        {
                            return;
                        }
                        else
                        {
                            info = Console.ReadKey();
                            if (info.Key == ConsoleKey.Enter)
                            {
                                Main();
                            }
                        }
                    }
                    //GAME RESULT FAILURE
                    //DWARF HAS NO MORE LIFES && THE 11 GEMS ARE NOT ALL COLLECTED

                    else if (dwarf.dwarfLives == 0 && (gem[0].collected == false || gem[1].collected == false || gem[4].collected == false
                                                || gem[5].collected == false || gem[6].collected == false || gem[7].collected == false
                                                || gem[8].collected == false || gem[9].collected == false || gem[9].collected == false))
                    {
                        for (int i = 200; i <= 2800; i += 800)
                        {
                            Console.Beep(i, 100);
                            Console.Beep(3400, 600);
                            Console.Beep(1000, 1000);
                        }

                        Console.Clear();

                        PrintObject(19, 4, ((char)2).ToString(), ConsoleColor.Black);
                        PrintObject(17, 6, "O,YOU!", ConsoleColor.Red);
                        PrintObject(12, 8, "YOU MISS!I'M DEAD!", ConsoleColor.Red);
                        PrintObject(11, 10, "I'M DEEEEEEEEEEEEAD!", ConsoleColor.Red);
                        PrintObject(8, 12, "BECAUSE OF YOUR CLUMSINESS", ConsoleColor.Red);
                        PrintObject(4, 14, "I'AM NOT GOING TO BE A PROGRAMMER!", ConsoleColor.Red);
                        PrintObject(15, 18, "GAME OVER!!!", ConsoleColor.Black);
                        PrintObject(8, 22, "press [enter]  to play again", ConsoleColor.Red);
                        PrintObject(8, 24, "press [escape] to exit", ConsoleColor.Red);

                        listOfObjects.Clear();
                        for (int i = 0; i < 11; i++)
                        {
                            gem[i].collected = false;
                        }

                        gameSpeed.delay = 250;
                        dwarf = new Object();
                        dwarf.x = playfieldWidth / 2;
                        dwarf.y = Console.WindowHeight - 1;
                        dwarf.color = ConsoleColor.Yellow;
                        dwarf.symbol = ((char)2).ToString();
                        dwarf.dwarfLives = 5;

                        info = Console.ReadKey();
                        if (info.Key == ConsoleKey.Escape)
                        {
                            return;
                        }
                        else
                        {
                            info = Console.ReadKey();
                            if (info.Key == ConsoleKey.Enter)
                            {
                                Main();
                            }
                        }
                    }

                    //PLAYING
                    else
                    {
                        Console.Clear();
                        //FIRST WE DRAW THE DWARF

                        PrintObject(dwarf.x, dwarf.y, dwarf.symbol, dwarf.color);

                        //THEN WE PRINT ALL ROCKS OF OUR LIST OF rocks(THE FALLING ROCKS), 
                        //on the first while-loop call nothing is printed, because the list is still empty
                        foreach (Object rocks in listOfObjects)
                        {
                            PrintObject(rocks.x, rocks.y, rocks.symbol, rocks.color);
                        }

                        // TIME TO CREATE ROCKS!
                        // WE CREATE AN OBJECT(ROCK) ON A RANDOM POSITION, ON THE TOP OF OUR PLAYFIELD (ON THE FIRST ROW, ON THE TOP OF THE CONSOLE)
                        // AND WE ADD THIS OBJECT TO OUR LIST OF OBJECTS(ROCKS)
                        //SUCH OBJECT(ROCK IS CREATED AND ADDED TO THE LIST every time the PROGRAM CALLS the while cicle) 

                        // random generator - creates random possitions for the good rock (bonuses)
                        int bonusChance = randomGenerator.Next(0, 100);

                        Object rock = new Object();
                        rock.x = randomGenerator.Next(0, playfieldWidth);  //will return RANDOM values 0 to playfieldWidth
                        rock.y = 0;                                         //object will apears always on the top line
                        //of console y = 0 is on the first Consol- row
                        //BONUSIES

                        if (bonusChance < 4) // chance 5%, when numbers 0,1,2,3,4,5 are randomly generated 
                        {
                            // NEW CHANCE
                            rock.symbol = ((char)3).ToString();
                            rock.color = ConsoleColor.Red;
                        }
                        else if (bonusChance >= 4 && bonusChance < 8)
                        {
                            // ROCK SPEED REDUCTION
                            rock.symbol = ((char)24).ToString();
                            rock.color = ConsoleColor.Red;
                        }

                        //GEMS

                        else if (bonusChance >= 10 && bonusChance < 12)
                        {
                            // gem  HARD WORK
                            rock.symbol = ((char)5).ToString();
                            rock.color = ConsoleColor.DarkRed;
                        }
                        else if (bonusChance >= 20 && bonusChance < 22)
                        {
                            // gem  SMART MIND
                            rock.symbol = ((char)6).ToString();
                            rock.color = ConsoleColor.Black;
                        }
                        else if (bonusChance >= 30 && bonusChance < 32)
                        {
                            // gem  BE FUNNY AND HUMORIOS
                            rock.symbol = ((char)14).ToString();
                            rock.color = ConsoleColor.DarkBlue;
                        }
                        else if (bonusChance >= 40 && bonusChance < 42)
                        {
                            // gem  INTELIGENCE
                            rock.symbol = ((char)15).ToString();
                            rock.color = ConsoleColor.Yellow;
                        }
                        else if (bonusChance >= 50 && bonusChance < 52)
                        {
                            // gem   LEARN C#
                            rock.symbol = "C#";
                            rock.color = ConsoleColor.DarkBlue;
                        }
                        else if (bonusChance >= 60 && bonusChance < 62)
                        {
                            // gem LEARN Java
                            rock.symbol = "Java";
                            rock.color = ConsoleColor.DarkYellow;
                        }
                        else if (bonusChance >= 70 && bonusChance < 72)
                        {
                            // gem LEARN C++
                            rock.symbol = "C++";
                            rock.color = ConsoleColor.Yellow;
                        }
                        else if (bonusChance >= 80 && bonusChance < 82)
                        {
                            // gem  LEARN Php
                            rock.symbol = "Php";
                            rock.color = ConsoleColor.Magenta;
                        }
                        else if (bonusChance >= 90 && bonusChance < 92)
                        {
                            // gem LEARN Python
                            rock.symbol = "Python";
                            rock.color = ConsoleColor.Yellow;
                        }
                        else if (bonusChance >= 98 && bonusChance < 100)
                        {
                            // gem LEARN VB.Net
                            rock.symbol = "VB.Net";
                            rock.color = ConsoleColor.Black;
                        }
                        else if (bonusChance >= 96 && bonusChance < 98)
                        {
                            // gem LEARN RUBY
                            rock.symbol = "Ruby";
                            rock.color = ConsoleColor.DarkRed;
                        }

                       // BAD ROCK
                        else
                        {
                            rock.symbol = ((char)4).ToString();
                            rock.color = ConsoleColor.Green;
                        }



                        //ADDING THE ROCK TO THE LIST OF OBJECTS (ROCKS)

                        listOfObjects.Add(rock);


                        // AVOIDING THE FALLING ROCKS BY MOVING OUR DWARF
                        // WE MOVE THE DWARF ON THE BOTTOM ROW OF CONSOLE (y= windoHhight-1, x = 0 to windowWidth )
                        // BY PRESSING  "<--" , "-->" KEYS ON THE KEYBOARD

                        while (Console.KeyAvailable) // ? KEY PRESSED ?
                        {

                            // WE FIRST READ AND THEN CLEAN THE BUFFER FROM OLD KEY (IF ONE THERE)(for better and quicker program flow)
                            ConsoleKeyInfo pressedKey = Console.ReadKey(true);

                            //WE CHECK, IF GEME-PLAYER HAS PRESSED THE "<--" OR THE "-->" KEY
                            //AND IF DWARF, AFTER STEP BY STEP MOVING, HAS REACHED THE WINDOW END 
                            //WE CHECK IF DWARF BY PRESSING THE "-->" KEY HAS REACHED x= windowWidth or
                            //IF DWARF BY PRESSING THE "<--" KEY RECHED x = 0

                            if ((pressedKey.Key == ConsoleKey.LeftArrow) && ((dwarf.x - 1) >= 0))
                            {
                                dwarf.x = dwarf.x - 1;
                            }
                            else if ((pressedKey.Key == ConsoleKey.RightArrow) && ((dwarf.x + 1) <= playfieldWidth - 1))
                            {
                                dwarf.x = dwarf.x + 1;
                            }
                        }


                        // HERE WE MAKE THE ROCKS "FALLING"
                        //we create a new list of the same objects, but already in their new possitions, 
                        //one position down from the old one or x is the same, y= y-1

                        List<Object> objectsInNewPositions = new List<Object>();

                        for (int i = 0; i < listOfObjects.Count; i++)
                        {

                            Object objectInOldPosition = listOfObjects[i];
                            Object objectInNewPosition = new Object();
                            objectInNewPosition.x = objectInOldPosition.x;
                            objectInNewPosition.y = objectInOldPosition.y + 1;
                            objectInNewPosition.color = objectInOldPosition.color;
                            objectInNewPosition.symbol = objectInOldPosition.symbol;


                            // IS A ROCKS HITING THE DWARF?
                            // HERE WE CHECK ! 
                            // if rock coordinates are the same as dwarf coordinates - the rock is hitting the dwarf !

                            //THAT CAN BE A BAD THING, IF DWARD IS HIT BY A BAD ROCK OR A GOOD THING , 
                            //WHEN THE DOWARD IS HIT BY A GOOD ROCK!

                            //A BAD ROCKS HITITING THE DWARF ?
                            if (objectInNewPosition.x == dwarf.x && objectInNewPosition.y == dwarf.y
                                && objectInNewPosition.symbol == ((char)4).ToString())
                            {
                                // WHEN A BAD ROCK HITS THE DWARf MANY THINGS HAPPENED

                                // 1. sign of crush "red X" appears
                                PrintObject(dwarf.x, dwarf.y, ('X').ToString(), ConsoleColor.DarkRed);

                                // 2. sound is sounding
                                Console.Beep(500, 1000);

                                // 3. all rocks on the playfield disappear
                                listOfObjects.Clear();

                                // 4. the dwarf losses one of his lifes
                                dwarf.dwarfLives--;

                                // 5. the speed of the rocks increases
                                gameSpeed.delay -= 50;
                                if (gameSpeed.delay < 50)
                                {
                                    gameSpeed.delay = 50;
                                }
                            }

                            // WHEN A GOOD ROCK HITS THE DWARF

                            // THERE ARE MANY DIFFERENT KINDS OF GOOD ROCKS IN THE GAME (BONUS ROCKS), 
                            // DEPENDING ON WHICH KIND OF GOOD ROCK HAS HIT THE DWARF
                            // DIFFERENT THINGS HAPPEND

                            // BONUSES

                            else if (objectInNewPosition.x == dwarf.x && objectInNewPosition.y == dwarf.y
                                    && objectInNewPosition.symbol == ((char)3).ToString())
                            {
                                //LIFE GIVING ROCK - HEART
                                PrintObject(dwarf.x, dwarf.y, "X", ConsoleColor.DarkRed);
                                Console.Beep(1500, 1000);
                                dwarf.dwarfLives++;
                                if (dwarf.dwarfLives > 5)
                                {
                                    dwarf.dwarfLives = 5;
                                }
                                listOfObjects.Clear();

                            }
                            else if (objectInNewPosition.x == dwarf.x && objectInNewPosition.y == dwarf.y
                                     && objectInNewPosition.symbol == ((char)24).ToString())
                            {
                                //ROCK FOR REDUCTION OF THE SPEED
                                PrintObject(rock.x, rock.y, "X", ConsoleColor.DarkRed);
                                Console.Beep(1500, 1000);
                                gameSpeed.delay += 50;
                                // delay upper limit
                                if (gameSpeed.delay > 250)
                                {
                                    gameSpeed.delay = 250;
                                }
                                listOfObjects.Clear();
                            }

                            //GEMS

                            else if (objectInNewPosition.x == dwarf.x && objectInNewPosition.y == dwarf.y
                                    && objectInNewPosition.symbol == ((char)5).ToString())
                            {
                                //gem 0 - INTELIGENCE
                                PrintObject(dwarf.x, dwarf.y, "X", ConsoleColor.DarkRed);
                                Console.Beep(1500, 1000);
                                gem[0].symbol = ((char)5).ToString();
                                gem[0].collected = true;
                                listOfObjects.Clear();
                            }
                            else if (objectInNewPosition.x == dwarf.x && objectInNewPosition.y == dwarf.y
                                     && objectInNewPosition.symbol == ((char)6).ToString())
                            {
                                //gem 1 - HARD WORK
                                PrintObject(dwarf.x, dwarf.y, "X", ConsoleColor.DarkRed);
                                Console.Beep(1500, 1000);
                                gem[1].symbol = ((char)6).ToString();
                                gem[1].collected = true;
                                listOfObjects.Clear();
                            }
                            else if (objectInNewPosition.x == dwarf.x && objectInNewPosition.y == dwarf.y
                                     && objectInNewPosition.symbol == ((char)14).ToString())
                            {
                                //gem 2 - BE FUNNY AND HUMORIOUS
                                PrintObject(rock.x, rock.y, "X", ConsoleColor.DarkRed);
                                for (i = 200; i <= 3000; i += 400)
                                {
                                    Console.Beep(i, 200);
                                }
                                Console.Beep(3400, 600);
                                Console.Beep(1000, 1000);
                                gem[2].symbol = ((char)14).ToString();
                                gem[2].collected = true;
                                listOfObjects.Clear();
                            }
                            else if (objectInNewPosition.x == dwarf.x && objectInNewPosition.y == dwarf.y
                                     && objectInNewPosition.symbol == ((char)15).ToString())
                            {
                                //gem 3 - SHARP MAIND
                                PrintObject(dwarf.x, dwarf.y, "X", ConsoleColor.DarkRed);
                                Console.Beep(1500, 1000);
                                gem[3].symbol = ((char)15).ToString();
                                gem[3].collected = true;
                                listOfObjects.Clear();
                            }
                            else if (objectInNewPosition.x == dwarf.x && objectInNewPosition.y == dwarf.y
                                && objectInNewPosition.symbol == "C#")
                            {
                                //gem 4 - LEARN C#
                                PrintObject(dwarf.x, dwarf.y, "X", ConsoleColor.DarkRed);
                                Console.Beep(1500, 1000);
                                gem[4].symbol = "C#";
                                gem[4].collected = true;
                                listOfObjects.Clear();
                            }
                            else if (objectInNewPosition.x == dwarf.x && objectInNewPosition.y == dwarf.y
                                                   && objectInNewPosition.symbol == "Java")
                            {
                                //gem 5  LEARN Java
                                PrintObject(dwarf.x, dwarf.y, "X", ConsoleColor.DarkRed);
                                Console.Beep(1500, 1000);
                                gem[5].symbol = "Java";
                                gem[5].collected = true;
                                listOfObjects.Clear();
                            }
                            else if (objectInNewPosition.x == dwarf.x && objectInNewPosition.y == dwarf.y
                                     && objectInNewPosition.symbol == "C++")
                            {
                                //gem 6 - LEARN C++
                                PrintObject(dwarf.x, dwarf.y, "X", ConsoleColor.DarkRed);
                                Console.Beep(1500, 1000);
                                gem[6].symbol = "C++";
                                gem[6].collected = true;
                                listOfObjects.Clear();
                            }
                            else if (objectInNewPosition.x == dwarf.x && objectInNewPosition.y == dwarf.y
                                    && objectInNewPosition.symbol == "Php")
                            {
                                //gem 7 - LEARN Php
                                PrintObject(dwarf.x, dwarf.y, "X", ConsoleColor.DarkRed);
                                Console.Beep(1500, 1000);
                                gem[7].symbol = "Php";
                                gem[7].collected = true;
                                listOfObjects.Clear();
                            }
                            else if (objectInNewPosition.x == dwarf.x && objectInNewPosition.y == dwarf.y
                                    && objectInNewPosition.symbol == "Python")
                            {
                                //gem 8 - LEARN Python
                                PrintObject(dwarf.x, dwarf.y, "X", ConsoleColor.DarkRed);
                                Console.Beep(1500, 1000);
                                gem[8].symbol = "Python";
                                gem[8].collected = true;
                                listOfObjects.Clear();
                            }
                            else if (objectInNewPosition.x == dwarf.x && objectInNewPosition.y == dwarf.y
                                     && objectInNewPosition.symbol == "VB.Net")
                            {
                                //gem 9 - VB.Net
                                PrintObject(dwarf.x, dwarf.y, "X", ConsoleColor.DarkRed);
                                Console.Beep(1500, 1000);
                                gem[9].symbol = "VB.Net";
                                gem[9].collected = true;
                                listOfObjects.Clear();
                            }
                            else if (objectInNewPosition.x == dwarf.x && objectInNewPosition.y == dwarf.y
                                   && objectInNewPosition.symbol == "Ruby")
                            {
                                //gem 10 - Ruby
                                PrintObject(dwarf.x, dwarf.y, "X", ConsoleColor.DarkRed);
                                Console.Beep(1500, 1000);
                                gem[10].symbol = "Ruby";
                                gem[10].collected = true;
                                listOfObjects.Clear();
                            }


                            //FILLING THE LIST WITH ROCKS IN THE NEW (NEXT) POSITION 
                            if (objectInNewPosition.y <= Console.WindowHeight - 1)
                            {
                                objectsInNewPositions.Add(objectInNewPosition);
                            }
                        }

                        //HIER WE DELETE THE ROCKS FROM THEIR CURRENT POSSITION (X=x, Y=y )
                        //AND THE PROGRAM THEN DRAW THEM, ON THEIR NEU (NEXT) POSSITION (X=x , Y=y+1)
                        //BY REPLACING THE WHOLE OLD LIST OF OBJECTS(ROCKS) WITH A NEW LIST OF OBJECTS(ROCKS)
                        listOfObjects = objectsInNewPositions;


                        //HERE WE DRAW THE GAME INFO

                        //PRINTING THE GAME TITLE
                        PrintObject(14, 1, "O.K GO ON!", ConsoleColor.Yellow);
                        PrintObject(5, 3, "BUT, BE AWARE OF FALLING ROCKS!", ConsoleColor.Yellow);

                        //PRINTING THE SIGHNS OF LIVE - THE HEARTS
                        PrintObject(27, 10, "DWARF'S LIVES ", ConsoleColor.Cyan);
                        int hearts = dwarf.dwarfLives;
                        int j = 1;
                        while (hearts > 0)
                        {
                            int num = 26 + 2 * j;
                            PrintObject(num, 12, " " + (char)3 + " ", ConsoleColor.Red);
                            hearts--;
                            j++;
                        }

                        //PRINTING THE SIGHN OF SPEED - DOWN ARROWS
                        PrintObject(28, 14, "ROCKS SPEED", ConsoleColor.Cyan);
                        switch (gameSpeed.delay)
                        {
                            case 50:
                                string str = new string((char)25, 5);
                                PrintObject(31, 16, str, ConsoleColor.Red);
                                break;
                            case 100:
                                str = new string((char)25, 4);
                                PrintObject(32, 16, str, ConsoleColor.Red);
                                break;

                            case 150:
                                str = new string((char)25, 3);
                                PrintObject(32, 16, str, ConsoleColor.Red);
                                break;

                            case 200:
                                str = new string((char)25, 2);
                                PrintObject(33, 16, str, ConsoleColor.Red);
                                break;
                            case 250:
                                str = new string((char)25, 1);
                                PrintObject(33, 16, str, ConsoleColor.Red);
                                break;
                        }

                        // PRINTING the DWARF'S GEMS

                        PrintObject(28, 18, "DWARF'S GEMS", ConsoleColor.Cyan);

                        if (gem[0].collected)
                        {
                            PrintObject(28, 20, ((char)5).ToString(), ConsoleColor.DarkRed);
                        }
                        if (gem[1].collected)
                        {
                            PrintObject(38, 20, ((char)6).ToString(), ConsoleColor.Black);
                        }
                        if (gem[2].collected)
                        {
                            PrintObject(35, 20, ((char)14).ToString(), ConsoleColor.DarkBlue);
                        }
                        if (gem[3].collected)
                        {
                            PrintObject(32, 20, ((char)15).ToString(), ConsoleColor.Yellow);
                        }
                        if (gem[4].collected)
                        {
                            PrintObject(28, 21, "C#", ConsoleColor.DarkBlue);
                        }
                        if (gem[5].collected)
                        {
                            PrintObject(32, 21, "Java", ConsoleColor.DarkYellow);
                        }
                        if (gem[6].collected)
                        {
                            PrintObject(38, 21, "C++", ConsoleColor.Yellow);
                        }
                        if (gem[7].collected)
                        {
                            PrintObject(28, 22, "Php", ConsoleColor.Magenta);
                        }
                        if (gem[8].collected)
                        {
                            PrintObject(28, 23, "Python", ConsoleColor.Yellow);
                        }
                        if (gem[9].collected)
                        {
                            PrintObject(33, 22, "VB.Net", ConsoleColor.Black);
                        }
                        if (gem[10].collected)
                        {
                            PrintObject(36, 23, "Ruby", ConsoleColor.DarkRed);
                        }

                        //SLOWING DOWN THE GAME SPEED
                        System.Threading.Thread.Sleep(gameSpeed.delay);
                    }
                }
            }
        }
    }
}