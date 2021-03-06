﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Xml.Schema;

namespace Edabit
{
    class Program
    {

        static void Main(string[] args)
        {





            // Return Something to Me! 1

            // Write a function that returns the string "something" joined with a space " " and the given argument a.

            //Examples
            //GiveMeSomething("is better than nothing") ➞ "something is better than nothing"

            //GiveMeSomething("Bob Jane") ➞ "something Bob Jane"

            //GiveMeSomething("something") ➞ "something something"

            static string GiveMeSomething(string a)
            {
                return "something " + a;
            }




            //Using the "&&" Operator 2

            //C# has a logical operator &&. The && operator takes two boolean values, and returns true if both values are true.

            //Consider a && b:

            //a is checked if it is true or false.
            //If a is false, false is returned.
            //b is checked if it is true or false.
            //If b is false, false is returned.
            //Otherwise, true is returned(as both a and b are therefore true ).
            //The && operator will only return true for true && true.

            //Make a function using the && operator.

            static bool And(bool x, bool y)
            {
                if (x == true && y == true)
                {
                    return (true);
                }
                else
                {
                    return (false);
                }
            }



            //A Circle and Two Squares 3

            //Imagine a circle and two squares: a smaller and a bigger one. For the smaller one, the circle is a circumcircle and for the bigger one, an incircle.
            //Create a function, that takes an integer(radius of the circle) and returns the difference of the areas of the two squares.

            //            Examples
            //square_areas_difference(5) ➞ 50

            //square_areas_difference(6) ➞ 72

            //square_areas_difference(7) ➞ 98

            static int square_areas_difference(int radius)
            {

                return 2 * radius * radius;

            }



            // Football 4

            // Create a function that takes the number of wins, draws and losses and calculates the number of points a football team has obtained so far.

            //wins get 3 points
            //draws get 1 point
            //losses get 0 points
            //Examples
            //FootballPoints(3, 4, 2) ➞ 13

            //FootballPoints(5, 0, 2) ➞ 15

            //FootballPoints(0, 0, 1) ➞ 0

            static int footballPoints(int wins, int draws, int losses)
            {
                int w = wins * 3;
                int d = draws * 1;
                int l = losses * 0;

                return w + d + l;
            }



            //Inches to Feet 5
            //Create a function that accepts a measurement value in inches and returns the equivalent of the measurement value in feet.

            //Examples
            //inchesToFeet(324) ➞ 27

            //inchesToFeet(12) ➞ 1

            //inchesToFeet(36) ➞ 3
            //Notes
            //If inches are under 12, return 0.

            static int inchesToFeet(int inches)
            {

                int result = 0;

                if (inches == 12)
                {
                    return 1;
                }

                result = inches / 12;

                if (result < 12)
                {
                    return 0;
                }
                else
                {
                    return result;
                }
            }



            //Convert All Array Objects to String 6

            //Create a function that takes an array of integers and strings, converts integers to strings, and returns the array as a string array.

            //Examples
            //ParseArray([1, 2, "a", "b"]) ➞ ["1", "2", "a", "b"]
            //Notes
            //If you get stuck on a challenge, find help in the Resources tab.

            static string[] ParseArray(object[] arr)
            {
                string arr2 = Array.ConvertAll(arr, x => x).ToString();

                return new[] { arr2 };
            }



            //Maximum Edge of a Triangle 7

            //Create a function that finds the maximum range of a triangle's third edge, where the side lengths are all integers.

            //Examples
            //NextEdge(8, 10) ➞ 17

            //NextEdge(5, 7) ➞ 11

            //NextEdge(9, 2) ➞ 10
            //Notes
            //(side1 + side2) - 1 = maximum range of third edge.
            //The side lengths of the triangle are positive integers.
            //Don't forget to return the result.

            static int NextEdge(int side1, int side2)
            {
                return side1 + side2 - 1;
            }



            //Return the First Element in an Array 8

            //Create a function that takes an array and returns the first element.

            //Examples
            //GetFirstValue([5, 6, 7]) ➞ 5

            //GetFirstValue(["Semiramis", "Gaia", "Hypatia"]) ➞ "Semiramis"

            //GetFirstValue([true, false, true]) ➞ true
            //Notes
            //The first element in an array always has an index of 0.

            static object GetFirstValue(object[] arr)
            {
                return arr[0];
            }



            //Free Coffee Cups 9

            //For each of the 6 coffee cups I buy, I get a 7th cup free.In total, I get 7 cups.Create a function that takes n cups bought and return the total number of cups I would get.

            //Examples
            //TotalCups(6) ➞ 7

            //TotalCups(12) ➞ 14

            //TotalCups(213) ➞ 248
            //Notes
            //Number of cups I bought +number of cups I got for free.
            //Only valid inputs will be given.

            static int TotalCups(int n)
            {

                return n / 6 + n;

            }



            //Frames Per Second 10

            //Create a function that returns the number of frames shown in a given number of minutes for a certain FPS.

            //Examples
            //Frames(1, 1) ➞ 60

            //Frames(10, 1) ➞ 600

            //Frames(10, 25) ➞ 15000
            //Notes
            //FPS stands for "frames per second" and it's the number of frames a computer screen shows every second.

            static int Frames(int minutes, int fps)
            {
                int Result = minutes * fps;

                return Result;

            }



            //Correct the Mistakes 11

            //Fix the code in the code tab to pass this challenge(only syntax errors).Look at the examples below to get an idea of what the function should do.


            //Examples 13
            //Squa        red(5) ➞ 25

            //Squared(9) ➞ 81 
            //Squared(100) ➞ 10000
            //Notes
            //READ EVERY WORD CAREFULLY, CHARACTER BY CHARACTER!
            //Don't overthink this challenge; it's not supposed to be hard.

            static int squaed(int a, int b)
            {
                int result = a * b;

                return result;
            }



            //Broken Bridge 12

            //Create a function which validates whether a bridge is safe to walk on(i.e.has no gaps in it to fall through).

            //Examples
            //IsSafeBridge("####") ➞ true

            //IsSafeBridge("## ####") ➞ false

            //IsSafeBridge("#") ➞ true
            //Notes
            //You can expect the bridge's ends connecting it to its surrounding.

            static bool IsSafeBridge(string str)
            {
                {

                    return !(str.Contains(" "));

                }
            }



            //Are the Numbers Equal? 13

            //Create a function that returns true when num1 is equal to num2; otherwise return false.

            //Examples
            //IsSameNum(4, 8) ➞ false

            //IsSameNum(2, 2) ➞  true

            //IsSameNum(0, 6) ➞ false
            //Notes
            //Don't forget to return the result.

            static bool IsSameNum(int num1, int num2)
            {
                if (num1.Equals(num2))
                {
                    return true;
                }
                else
                    return false;
            }



            //Return a String as an Integer 14

            //Create a function that takes a string and returns it as an integer.

            //Examples
            //StringInt("6") ➞ 6

            //StringInt("1000") ➞ 1000

            //StringInt("12") ➞ 12
            //Notes
            //All numbers will be whole.
            //All numbers will be positive.

            static int StringInt(string txt)
            {
                return int.Parse(txt);
            }



            //Find the Perimeter of a Rectangle 15

            //Create a function that takes length and width and finds the perimeter of a rectangle.

            //Examples
            //FindPerimeter(6, 7) ➞ 26

            //FindPerimeter(20, 10) ➞ 60

            //FindPerimeter(2, 9) ➞ 22
            //Notes
            //Don't forget to return the result.
            //If you're stuck, find help in the Resources tab.
            //If you're really stuck, find solutions in the Solutions tab.

            static int FindPerimenter(int lenght, int width)
            {
                return (lenght + width) * 2;

            }



            //Reverse an Array 16

            //Write a function to reverse an array.

            //Examples
            //Reverse(new int[] { 1, 2, 3, 4 }) ➞ { 4, 3, 2, 1}

            //Reverse(new int[] { 9, 9, 2, 3, 4 }) ➞ { 4, 3, 2, 9, 9}

            //Reverse(new int[] { }) ➞ { }
            //Notes
            //Don't forget to return the result.
            //If you get stuck on a challenge, find help in the Resources tab.
            //If you're really stuck, unlock solutions in the Solutions tab.

            static int[] Reverse(int[] arr)
            {

                return arr.Reverse().ToArray();

            }



            //Add, Subtract, Multiply or Divide ? 17

            //Write a function that takes two numbers and returns if they should be added, subtracted, multiplied or divided to get 24.If none of the operations can give 24, return "none".

            //Examples
            //Operation(15, 9) ➞ "added"

            //Operation(26, 2) ➞ "subtracted"

            //Operation(11, 11) ➞ "none"
            //Notes
            //Only integers are used as test input.
            //Numbers should be added, subtracted, divided or multiplied in the order they appear in the parameters.
            //The function should return either "added", "subtracted", "divided", "multiplied" or "none".

            static string Operation(int num1, int num2)
            {
                if (num1 + num2 == 24)
                {
                    return "added";
                }
                else if (num1 - num2 == 24)
                {
                    return "subtracted";
                }
                else if (num1 * num2 == 24)
                {
                    return "multiplied";
                }
                else if (num1 / num2 == 24)
                {
                    return "divided";
                }
                else
                {
                    return "none";
                }
            }



            //Is the String Odd or Even? 18

            //Given a string, return true if its length is even or false if the length is odd.

            //Examples
            //oddOrEven("apples") ➞ true

            //oddOrEven("pears") ➞ false

            //oddOrEven("cherry") ➞ true
            //Notes
            //N / A

            static string OddOrEven(string word)
            {

                return (word.Length % 2 == 0).ToString();

            }



            //Both Zero, Negative or Positive 19

            //Write a function that returns true if both numbers are:

            //Smaller than 0, OR...
            //Greater than 0, OR...
            //Exactly 0
            //Otherwise, return false.

            //Examples
            //Both(6, 2) ➞ true

            //Both(0, 0) ➞ true

            //Both(-1, 2) ➞ false

            //Both(0, 2) ➞ false
            //Notes
            //Inputs will always be two numbers.

            static bool Both(int n1, int n2)
            {
                if ((n1 + n2 == 0) || (n1 > 0 && n2 > 0) || n1 < 0 && n2 < 0)
                {
                    return true;
                }
                else
                    return false;
            }



            //Recursion: Length of a String 20

            //Write a function that returns the length of a string.Make your function recursive.

            //Examples
            //Length("apple") ➞ 5

            //Length("make") ➞ 4

            //Length("a") ➞ 1

            //Length("") ➞ 0
            //Notes
            //Check the Resources tab for info on recursion.

            static int Length(string str) => str.Length;



            //Name Greeting! 21

            //Create a function that takes a name and returns a greeting in the form of a string.

            //Examples
            //HelloName("Gerald") ➞ "Hello Gerald!"

            //HelloName("Tiffany") ➞ "Hello Tiffany!"

            //HelloName("Ed") ➞ "Hello Ed!"
            //Notes
            //The input is always a name(as string).
            //Don't forget the exclamation mark!
            //If you get stuck on a challenge, find help in the Resources tab.
            //If you're really stuck, unlock solutions in the Solutions tab.

            static string HelloName(string name)
            {
                return "Hello " + name + "!";
            }



            //Are the Numbers Equal? 22

            //Create a function that takes two integers and checks if they are equal.

            //Examples
            //IsEqual(5, 6) ➞ false

            //IsEqual(1, 1) ➞ true

            //IsEqual(36, 35) ➞ false
            //Notes
            //N / A

            static bool IsEqual(int num1, int num2)
            {
                if (num1.Equals(num2))
                {
                    return true;
                }
                else
                    return false;
            }



            //Char - to - ASCII 23

            //Create a function that returns the ASCII value of the passed in character.

            //Examples
            //CharToASCII('S') ➞ 83

            //CharToASCII('m') ➞ 109

            //CharToASCII('1') ➞ 49

            //CharToASCII('a') ➞ 97
            //Notes
            //Don't forget to return the result.
            //If you get stuck on a challenge, find help in the Resources tab.
            //If you're really stuck, unlock solutions in the Solutions tab.

            static int CharToASCII(char ch)
            {

                int i = ch;
                return i;

            }



            //Drinks Allowed? 24

            //A bartender is writing a simple program to determine whether he should serve drinks to someone.He only serves drinks to people 18 and older and when he's not on break.

            //Given the person's age, and whether break time is in session, create a function which returns whether he should serve drinks.

            //Examples
            //ShouldServeDrinks(17, true) ➞ false

            //ShouldServeDrinks(19, false) ➞ true

            //ShouldServeDrinks(30, true) ➞ false
            //Notes
            //Return true or false.
            //Some countries have a slightly higher drinking age, but for the purposes of this challenge, it will be 18.

            static bool ShouldServeDrinks(int age, bool on_break)
            {
                if (age >= 18 && !on_break)
                {
                    return true;
                }
                else
                    return false;
            }



            //Lowercase, Uppercase or Mixed ? 25

            //Create a function which returns "upper" if all the letters in a word are uppercase, "lower" if lowercase and "mixed" for any mix of the two.

            //Examples
            //GetCase("whisper...") ➞ "lower"

            //GetCase("SHOUT!") ➞ "upper"

            //GetCase("Indoor Voice") ➞ "mixed"
            //Notes
            //Ignore punctuation, spaces and numbers.

            static string GetCase(string str)
            {

                if (str == str.ToLower())
                {
                    return "lower";
                }

                else if (str == str.ToUpper())
                {
                    return "upper";
                }

                else
                    return "mixed";
            }



            //Concatenating First and Last Character of a String 26

            //Creates a function that takes a string and returns the concatenated first and last character.

            //Examples
            //FirstLast("forza") ➞ "fa"

            //FirstLast("kali") ➞ "ki"

            //FirstLast("always") ➞ "as"

            //FirstLast("love") ➞ "le"

            //FirstLast("edabit") ➞ "et"
            //Notes
            //There is no empty string.

            static string FirstLast(string str)
            {
                {
                    string s = string.Empty;
                    s += str[0];
                    s += str[str.Length - 1];
                    return s;
                }
            }



            //On / Off Switches 27

            //Create a function that returns how many possible outcomes can come from a certain number of switches(on / off). In other words, for a given number of switches, how many different combinations of on and off can we have ?

            //Examples
            //PosCom(1) ➞ 2


            //PosCom(3) ➞ 8


            //PosCom(10) ➞ 1024
            //Notes
            //All numbers will be whole and positive.

            static int PosCom(int n)
            {
                double result = Math.Pow(2, n);

                return (int)result;
            }



            //Smash Factor 28

            //Smash factor is a term in golf that relates to the amount of energy transferred from the club head to the golf ball.The formula for calculating smash factor is ball speed divided by club speed.


            //Create a function that takes ball speed bs and club speed cs as arguments and returns the smash factor to the nearest hundredth.


            //Examples
            //SmashFactor(139.4, 93.8) ➞ 1.49


            //SmashFactor(181.2, 124.5) ➞ 1.46


            //SmashFactor(154.7, 104.3) ➞ 1.48
            //Notes
            //Remember to round to the nearest hundredth.
            //All values will be valid(so no dividing by zero).

            static double SmashFactor(double a, double b)
            {

                return Math.Round(a / b, 2);

            }



            //Stack the Boxes 29

            //Here's an image of four models. Some of the cubes are hidden behind other cubes. Model one consists of one cube. Model two consists of four cubes, and so on...

            //Stack the Boxes

            //Write a function that takes a number n and returns the number of stacked boxes in a model n levels high, visible and invisible.

            //Examples
            //StackBoxes(1) ➞ 1

            //StackBoxes(2) ➞ 4

            //StackBoxes(0) ➞ 0
            //Notes
            //Step n is a positive integer.

            static int StackBoxes(int n)
            {

                double result = Math.Pow(n, 2);

                return (int)result;

            }



            //Convert Hours into Seconds 30

            //Write a function that converts hours into seconds.

            //Examples
            //howManySeconds(2) ➞ 7200

            //howManySeconds(10) ➞ 36000

            //howManySeconds(24) ➞ 86400
            //Notes
            //60 seconds in a minute, 60 minutes in an hour.
            //Don't forget to return your answer.

            static int HowManySecound(int hours)
            {
                return hours * 60 * 60;
            }



            //Is the Last Character an N? 31

            //Create a function that takes a string(a random name).If the last character of the name is an "n", return true, otherwise return false.

            //Examples
            //isLastCharacterN("Aiden") ➞ true

            //isLastCharacterN("Piet") ➞ false

            //isLastCharacterN("Bert") ➞ false

            //isLastCharacterN("Dean") ➞ true
            //Notes
            //The function must return a boolean value(i.e. true or false).

            static bool isLastCharaterN(string word)
            {

                if (word.EndsWith("n"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            //How Many D's Are There? 32

            //Create a function that counts how many D's are in a sentence.

            //Examples
            //CountDs("My friend Dylan got distracted in school.") ➞ 4

            //CountDs("Debris was scattered all over the yard.") ➞ 3

            //CountDs("The rodents hibernated in their den.") ➞ 3
            //Notes
            //Your function must be case-insensitive.
            //Remember to return the result.
            //Check the Resources for help.

            static int CountDS(string str)
            {

                int count = 0;

                for (int i = 0; i < str.Length; i++)
                {

                    if (str[i] == 'D' || str[i] == 'd') ++count;

                }

                return count;

            }



            //How Much is True? 33

            //Create a function which returns the number of true values there are in an array.

            //Examples
            //CountTrue([true, false, false, true, false]) ➞ 2

            //CountTrue([false, false, false, false]) ➞ 0

            //CountTrue([]) ➞ 0
            //Notes
            //Return 0 if given an empty array.
            //All array items are of the type bool(true or false).

            static int CountTrue(bool[] arr)
            {

                int counter = 0;

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == true) counter++;
                }
                return counter;

            }



            //Raucous Applause 34

            //fter an amazing performance, the crowd goes wild! People clap enthusiastically and most claps overlap with each other to create one homogeneous sound.

            //An overlapped clap is a clap which starts but doesn't finish, as in "ClaClap" (the first clap is cut short and there are overall 2 claps).

            //Given a string of what the overlapping claps sounded like, return how many claps were made in total.

            //Examples
            //CountClaps("ClaClaClaClap!") ➞ 4

            //CountClaps("ClClClaClaClaClap!") ➞ 6

            //CountClaps("CCClaClClap!Clap!ClClClap!") ➞ 9
            //Notes
            //Each clap starts with a capital "C".

            static int CountClaps(string txt)
            {
                int clapCounter = 0;
                for (int i = 0; i < txt.Length; i++)
                {
                    if (txt[i] == 'C')
                    {
                        clapCounter++;

                    }
                }

                return clapCounter;

            }



            //Shapes With N Sides 35

            //Create a function that takes a whole number as input and returns the shape with that number's amount of sides. Here are the expected outputs to get from these inputs.

            //Inputs Outputs
            //1   "circle"
            //2   "semi-circle"
            //3   "triangle"
            //4   "square"
            //5   "pentagon"
            //6   "hexagon"
            //7   "heptagon"
            //8   "octagon"
            //9   "nonagon"
            //10  "decagon"
            //Examples
            //NSidedShape(3) ➞ "triangle"

            //NSidedShape(1) ➞ "circle"

            //NSidedShape(9) ➞ "nonagon"
            //Notes
            //There won't be any tests with a number below 1 or greater than 10.
            //Return the output in lowercase.
            //The challenge is intended to be completed without conditionals(it would take too long)!

            static string NSidedShape(int n)
            {
                string[] shapes = {"circle", "semi-circle", "triangle", "square","pentagon",
                "hexagon",
                "heptagon",
                "octagon",
                "nonagon",
                "decagon"};

                return shapes[n - 1];

            }



            //Convert Hours and Minutes into Seconds 36

            //Write a function that takes two integers(hours, minutes), converts them to seconds, and adds them.

            //Examples
            //Convert(1, 3) ➞ 3780

            //Convert(2, 0) ➞ 7200

            //Convert(0, 0) ➞ 0
            //Notes
            //Don't forget to return the result.
            //If you get stuck on a challenge, find help in the Resources tab.
            //If you're really stuck, unlock solutions in the Solutions tab.

            static int Convert(int hours, int minutes)
            {
                int h = hours * 3600;
                int m = minutes * 60;

                return h + m;
            }



            //String to Integer and Vice Versa 37

            //Write two functions:

            //toInt() : A function to convert a string to an integer.
            //toStr() : A function to convert an integer to a string.
            //Examples
            //toInt("77") ➞ 77

            //toInt("532") ➞ 532

            //toStr(77) ➞ "77"

            //toStr(532) ➞ "532"
            //Notes
            //Don't forget to return the result.
            //If you get stuck on a challenge, find help in the Resources tab.
            //If you're really stuck, unlock solutions in the Solutions tab.

            //public static int toInt(string str)
            //{
            //    return Convert.ToInt32(str);
            //}
            //public static string toStr(int num)
            //{
            //    return Convert.ToString(num);
            //}



            //No Conditionals? 38

            //Write a function that returns 0 if the input is 1, and returns 1 if the input is 0.

            //Examples
            //Flip(1) ➞ 0

            //Flip(0) ➞ 1
            //Notes
            //Try completing this challenge without using any:

            //Conditionals
            //Ternary operators
            //Negations
            //Bit operators

            static int Flip(int y)
            {
                return 1 - y;
            }



            //Hashes and Pluses 39

            //Create a function that returns the number of hashes and pluses in a string.

            //Examples
            //HashPlusCount("###+") ➞ [3, 1]

            //HashPlusCount("##+++#") ➞ [3, 3]

            //HashPlusCount("#+++#+#++#") ➞ [4, 6]

            //HashPlusCount("") ➞ [0, 0]
            //Notes
            //Return[0, 0] for an empty string.
            //Return in the order of[hashes, pluses].

            static int[] HashPlusCount(string s)
            {
                int hash = 0;
                int plus = 0;

                char[] arr = s.ToCharArray();
                for (int i = 0; i < s.Length; i++)
                {
                    if (arr[i] == '#')
                    {
                        hash++;
                    }
                    if (arr[i] == '+')
                    {
                        plus++;
                    }
                }
                int[] ans = { hash, plus };
                return ans;
            }



            //The Study of Wumbology 40

            //Create a function that flips M's to W's(all uppercase).

            //Examples
            //wumbo("I LOVE MAKING CHALLENGES") ➞ "I LOVE WAKING CHALLENGES"

            //wumbo("MEET ME IN WARSAW") ➞ "WEET WE IN WARSAW"

            //wumbo("WUMBOLOGY") ➞ "WUWBOLOGY"
            //Notes
            //N / A

            static string wumbo(string words)
            {
                return words.Replace("m", "w").ToUpper();
            }



            //Get the File Name 41

            //Create a function that returns the selected filename from a path.Include the extension in your answer.

            //Examples
            //GetFilename("C:/Projects/pil_tests/ascii/edabit.txt") ➞ "edabit.txt"

            //GetFilename("C:/Users/johnsmith/Music/Beethoven_5.mp3") ➞ "Beethoven_5.mp3"

            //GetFilename("ffprobe.exe") ➞ "ffprobe.exe"
            //Notes
            //Tests will include both absolute and relative paths.
            //For simplicity, all paths will include forward slashes.

            static string GetFilename(string path)
            {

                return path.Split('/').Last();

            }



            //Burrrrrrrp 42

            //Create a function that returns the string "Burp" with the amount of "r's" determined by the input parameters of the function.

            //Examples
            //LongBurp(3) ➞ "Burrrp"

            //LongBurp(5) ➞ "Burrrrrp"

            //LongBurp(9) ➞ "Burrrrrrrrrp"
            //Notes
            //Expect num to always be >= 1.
            //Remember to use a capital "B".
            //Don't forget to return the result.

            static string Longburp(int b)
            {

                string r = new string('r', b);
                return $"Bu{r}p";
            }



            //Reverse and Capitalize 43

            //Create a function that takes a string of lowercase characters and returns that string reversed and in upper case.

            //Examples
            //ReverseCapitalize("abc") ➞ "CBA"

            //ReverseCapitalize("hellothere") ➞ "EREHTOLLEH"

            //ReverseCapitalize("input") ➞ "TUPNI"

            static string ReverseCapitalze(string str)
            {

                return new string(str.ToUpper().Reverse().ToArray());

            }



            //Recursion to Repeat a String n Number of Times 44

            //Create a recursive function that takes two parameters and repeats the string n number of times.The first parameter txt is the string to be repeated and the second parameter is the number of times the string is to be repeated.

            //Examples
            //Repetition("ab", 3) ➞ "ababab"

            //Repetition("kiwi", 1) ➞ "kiwi"

            //Repetition("cherry", 2) ➞ "cherrycherry"
            //Notes
            //The second parameter of the function is positive integer.

            static string Repetition(string txt, int n)
            {
                string Txt = "";
                if (n > 0)
                {
                    Txt = txt + Repetition(txt, n - 1);
                }
                return Txt;
            }



            //Re - Form the Word 45

            //A word has been split into a left part and a right part.Re - form the word by adding both halves together, changing the first character to an uppercase letter.

            //Examples
            //GetWord("seas", "onal") ➞ "Seasonal"

            //GetWord("comp", "lete") ➞ "Complete"

            //GetWord("lang", "uage") ➞ "Language"
            //Notes
            //N / A

            static string GetWord(string left, string right)
            {
                string str = System.String.Concat(left, right);
                str = char.ToUpper(str[0]) + str.Substring(1);
                return str;
            }



            //Modifying the Last Character 46

            //Create a function which makes the last character of a string repeat n number of times.

            //Examples
            //ModifyLast("Hello", 3) ➞ "Hellooo"

            //ModifyLast("hey", 6) ➞ "heyyyyyy"

            //ModifyLast("excuse me what?", 5) ➞ "excuse me what?????"
            //Notes
            //Test will include numbers and punctuation.
            //Make sure the code is not case sensitive.

            static string ModifyLast(string str, int n)
            {

                return str + new string(str[str.Length - 1], n - 1);

            }



            //Date Format 47

            //Create a function that converts a date formatted as MM / DD / YYYY to YYYYDDMM.

            //Examples
            //FormatDate("11/12/2019") ➞ "20191211"

            //FormatDate("12/31/2019") ➞ "20193112"

            //FormatDate("01/15/2019") ➞ "20191501"
            //Notes
            //Return value should be a string.

            static string FormatDate(string date)
            {

                DateTime inputDate = DateTime.Parse(date);
                return inputDate.ToString("yyyydMM");

            }



            //The Collatz Conjecture 48

            //Consider the following operation on an arbitrary positive integer:

            //If n is even -> n / 2
            //If n is odd -> n * 3 + 1
            //Create a function to repeatedly evaluate these operations, until reaching 1.Return the number of steps it took.

            //See the following example, using 10 as the input, with 6 steps:

            //10 is even - 10 / 2 = 5
            //5 is odd - 5 * 3 + 1 = 16
            //16 is even - 16 / 2 = 8
            //8 is even - 8 / 2 = 4
            //4 is even - 4 / 2 = 2
            //2 is even - 2 / 2 = 1->Reached 1, so return 6
            //Examples
            //collatz(2) ➞ 1

            //collatz(3) ➞ 7

            //collatz(10) ➞ 6
            //Notes
            //For further information, check the Resources tab.

            static int collatz(int num)
            {

                int steps = 0;

                while (num != 1)
                {
                    if (num % 2 == 0)
                    {
                        num = num / 2;
                        steps++;
                    }
                    else
                    {
                        num = num * 3 + 1;
                        steps++;
                    }
                }

                return steps;

            }

            //Return the First and Last Elements in an Array 49

            //Create a function that takes an array of numbers and return the first and last elements as a new array.

            //Examples
            //FirstLast([5, 10, 15, 20, 25]) ➞ [5, 25]

            //FirstLast(["edabit", 13, null, false, true]) ➞ ["edabit", true]

            //FirstLast([undefined, 4, "6", "hello", null]) ➞ [undefined, null]
            //Notes
            //Test input will always contain a minimum of two elements within the array.
            //Don't forget to return the result.
            //If you get stuck on a challenge, find help in the Resources tab.
            //If you're really stuck, unlock solutions in the Solutions tab.

            static object[] FirstLast2(object[] values)
            {
                return new[] { values[0], values[values.Length - 1] };
            }



            //Stuttering Function 50

            //Write a function that stutters a word as if someone is struggling to read it. The first two letters are repeated twice with an ellipsis ... and space after each, and then the word is pronounced with a question mark?.

            //Examples
            //Stutter("incredible") ➞ "in... in... incredible?"

            //Stutter("enthusiastic") ➞ "en... en... enthusiastic?"

            //Stutter("outstanding") ➞ "ou... ou... outstanding?"
            //Notes
            //Assume all input is in lower case and at least two characters long.

            static string Stutter(string word)
            {
                string s = word.Substring(0, 2) + new string('.', 3) + " ";
                return s + s + word;
            }



            //Concatenating Two Integer Arrays 51

            //Create a function to concatenate two integer arrays.

            //Examples
            //concat([1, 3, 5], [2, 6, 8]) ➞ [1, 3, 5, 2, 6, 8]

            //concat([7, 8], [10, 9, 1, 1, 2]) ➞ [7, 8, 10, 9, 1, 1, 2]

            //concat([4, 5, 1], [3, 3, 3, 3, 3]) ➞ [4, 5, 1, 3, 3, 3, 3, 3]
            //Notes
            //Don't forget to return the result.
            //See Resources tab for more info.

            static int[] Concatarrays(int[] arr1, int[] arr2)
            {
                int[] arr3 = new int[arr1.Length + arr2.Length];

                arr1.CopyTo(arr3, 0);
                arr2.CopyTo(arr3, arr1.Length);

                return arr3;

            }



            //Equality Check 52

            //In this challenge, you must verify the equality of two different values given the parameters a and b.

            //Both the value and type of the parameters need to be equal. The possible types of the given parameters are:

            //Numbers
            //Strings
            //Booleans(false or true)
            //What have you learned so far that will permit you to do two different checks(value and type) with a single statement?

            //Implement a function that returns true if the parameters are equal, and false if they are not.

            //Examples
            //CheckEquality(1, true) ➞ false
            //// A number and a boolean: the value and type are different.

            //CheckEquality(0, "0") ➞ false
            //// A number and a string: the type is different.

            //CheckEquality(1, 1) ➞ true
            //// A number and a number: the type and value are equal.
            //Notes
            //If you get stuck on a challenge, find help in the Resources tab.
            //If you're really stuck, unlock solutions in the Solutions tab.

            static bool CheckEquality(object a, object b)
            {
                if (a.Equals(b))
                {
                    return true;
                }
                else
                    return false;
            }



            //Convert Yen to USD 53

            //Create a function that can turn Yen(Japanese dollar) to USD(American dollar).

            //Examples
            //YenToUsd(1) ➞ 0.01

            //YenToUsd(500) ➞ 4.65

            //YenToUsd(649) ➞ 6.04
            //Notes
            //Each Yen to USD conversion is Yen / 107.5
            //Round the result to two decimal places.

            static double YenToUsd(int yen)
            {
                double result = yen / 107.5;
                return Math.Round(result, 2);
            }



            //Fraction Greater Than One 54

            //Given a fraction as a string, return whether or not it is greater than 1 when evaluated.

            //Examples
            //GreaterThanOne("1/2") ➞ false

            //GreaterThanOne("7/4") ➞ true

            //GreaterThanOne("10/10") ➞ false
            //Notes
            //Fractions must be strictly greater than 1(see example #3).

            static bool GreaterThanOne(string str)
            {
                int a = int.Parse(str.Split('/')[0]);
                int b = int.Parse(str.Split('/')[1]);
                return a > b ? true : false;
            }



            //Finding Nemo 55


            //You're given a string of words. You need to find the word "Nemo", and return a string like this: "I found Nemo at [the order of the word you find nemo]!".

            //If you can't find Nemo, return "I can't find Nemo: (".

            //Examples
            //FindNemo("I am finding Nemo !") ➞ "I found Nemo at 4!"

            //FindNemo("Nemo is me") ➞ "I found Nemo at 1!"

            //FindNemo("I Nemo am") ➞ "I found Nemo at 2!"
            //Notes
            //! , ? . are always separated from the last word.
            //Nemo will always look like Nemo, and not NeMo or other capital variations.
            //Nemo's, or anything that says Nemo with something behind it, doesn't count as Finding Nemo.
            //If there are multiple Nemo's in the sentence, only return for the first one.

            static string FindNemo(string sentece)
            {
                string[] words = sentece.Split(' ');
                int pos = 0;
                foreach (string w in words)
                {
                    pos++;
                    if (w == "Nemo")
                        return string.Format("I found Nemo at {0}!", pos);
                }
                return "I can't find Nemo :(";
            }



            //Spaces Between Each Character 56

            //Create a function that takes a string and returns a string with spaces in between all of the characters.

            //Examples
            //SpaceMeOut("space") ➞ "s p a c e"

            //SpaceMeOut("far out") ➞ "f a r  o u t"

            //SpaceMeOut("elongated musk") ➞ "e l o n g a t e d   m u s k"
            //Notes
            //Treat a space as its own character(i.e.leave three spaces between words).

            static string SpaceMeOut(string str)
            {

                string result = "";

                foreach (char letters in str)
                {
                    result = string.Join(" ", str.ToCharArray());
                }

                return result;

            }



            //Find the Bomb 57

            //Create a function that finds the word "bomb" in the given string.If found, return "Duck!!!", otherwise, return "There is no bomb, relax.".

            //Examples
            //Bomb("There is a bomb.") ➞ "Duck!!!"

            //Bomb("Hey, did you think there is a bomb?") ➞ "Duck!!!"

            //Bomb("This goes boom!!!") ➞ "There is no bomb, relax."
            //Notes
            //"bomb" may appear in different cases(i.e.uppercase, lowercase, mixed).

            static string Bomb(string txt)
            {
                if (txt.ToLower().Contains("bomb"))
                {
                    return "Duck!!!";
                }
                else
                    return "There is no bomb, relax.";
            }



            //Find the nth Tetrahedral Number 58

            //Create a function that takes an integer n and returns the nth tetrahedral number.

            //Alternative Text

            //Examples
            //Tetra(2) ➞ 4

            //Tetra(5) ➞ 35

            //Tetra(6) ➞ 56
            //Notes
            //There is a formula for the nth tetrahedral number.

            static int Tetra(int n)
            {
                return n * (n + 1) * (n + 2) / 6;
            }



            //Find the Amount of Potatoes 59

            //Create a function to return the amount of potatoes there are in a string.

            //Examples
            //Potatoes("potato") ➞ 1

            //Potatoes("potatopotato") ➞ 2

            //Potatoes("potatoapple") ➞ 1
            //Notes
            //N / A

            static int Potatoes(string potato)
            {
                return Regex.Matches(potato, "potato").Count;
            }



            //Scottish Screaming 60

            //A strong Scottish accent makes every vowel similar to an "e", so you should replace every vowel with an "e".Additionally, it is being screamed, so it should be in block capitals.

            //Create a function that takes a string and returns a string.

            //Examples
            //ToScottishScreaming("hello world") ➞ "HELLE WERLD"

            //ToScottishScreaming("Mr. Fox was very naughty") ➞ "MR. FEX WES VERY NEEGHTY"

            //ToScottishScreaming("Butterflies are beautiful!") ➞ "BETTERFLEES ERE BEEETEFEL!"
            //Notes
            //Make sure to include all punctuation that is in the original string.
            //You don't need any more namespaces than are already given.

            static string ToScottishScreaming(string str)
            {
                return str.ToLower()
                          .Replace("a", "e")
                          .Replace("i", "e")
                          .Replace("o", "e")
                          .Replace("u", "e")
                          .ToUpper();
            }



            //Testing K^K == N ? 61

            //Write a function that returns true if k ^ k == n for input(n, k) and return false otherwise.

            //Examples
            //KToK("4", 2) ➞ true

            //KToK("387420489", 9) ➞ true
            //# 9^9 == 387420489

            //KToK("3124", 5) ➞ false

            //KToK("17", 3) ➞ false
            //Notes
            //The ^ operator refers to exponentiation operation, not the bitwise XOR operation.

            static bool KTok(string n, int k)
            {
                if (double.Parse(n) == Math.Pow(k, k))
                {
                    return true;
                }
                else
                    return false;
            }



            //Is the Average of All Elements a Whole Number ? 62

            //Create a function that takes an array as an argument and returns true or false depending on whether the average of all elements in the array is a whole number or not.

            //Examples
            //IsAvgWhole([1, 3]) ➞ true

            //IsAvgWhole([1, 2, 3, 4]) ➞ false

            //IsAvgWhole([1, 5, 6]) ➞ true

            //IsAvgWhole([1, 1, 1]) ➞ true

            //IsAvgWhole([9, 2, 2, 5]) ➞ false
            //Notes
            //N / A

            static bool IsAvgWhole(int[] arr)
            {
                return arr.Average() % 1 == 0;
            }



            //Algorithms: Binary Search 63

            //Create a function that finds a target number in a list of prime numbers.Implement a binary search algorithm in your function. The target number will be from 2 through 97.If the target is prime then return "yes" else return "no".

            //Examples
            //int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 }


            //IsPrime(primes, 3) ➞ "yes"

            //IsPrime(primes, 4) ➞ "no"

            //IsPrime(primes, 67) ➞ "yes"

            //IsPrime(primes, 36) ➞ "no"
            //Notes
            //You could use built -in functions to solve this, but the point of this challenge is to see if you understand the binary search algorithm.
            //The solution is in the Resources tab.

            static string IsPrime(int[] primes, int num)
            {
                {
                    bool is_prime = true;
                    for (int i = 2; i < num; i++)
                    {
                        if (num % i == 0) is_prime = false;
                    }
                    return is_prime ? "yes" : "no";
                }
            }



            //Solve the Equation 64

            //Create a function that takes an equation(e.g. "1+1"), and returns the answer.

            //Examples
            //Equation("1+1") ➞ 2

            //Equation("7*4-2") ➞ 26

            //Equation("1+1+1+1+1") ➞ 5
            //Notes
            //N / A

            static int Equation(string s)
            {
                DataTable dt = new DataTable();
                return (int)dt.Compute(s, "");
            }



            //Count the Letters and Digits 65

            //Write a function that takes a string and calculates the number of letters and digits within it.Return the result as anonymous type in string format.

            //Examples
            //count_all("Hello World") ➞ " { LETTERS =  10,  DIGITS =  0 }"

            //count_all("H3ll0 Wor1d") ➞ " { LETTERS =  7,  DIGITS =  3 }"

            //count_all("149990") ➞  "{ LETTERS =  0, DIGITS = 6 }"
            //Notes
            //Tests contain only alphanumeric characters.
            //Spaces are not letters.
            //All tests contain valid strings.
            //Return the result as anonymous type.

            static string ount_all(string txt)
            {
                int let = 0, dig = 0;
                foreach (char c in txt)
                {
                    if (char.IsLetter(c)) let++;
                    if (char.IsDigit(c)) dig++;
                }
                return new { LETTERS = let, DIGITS = dig }.ToString();
            }



            //Friday the 13th 66

            //Given the month and year as numbers, return whether that month contains a Friday 13th.

            //Examples
            //HasFriday13th(3, 2020) ➞ True

            //HasFriday13th(10, 2017) ➞ True

            //HasFriday13th(1, 1985) ➞ False
            //Notes
            //January will be given as 1, February as 2, etc...
            //Check Resources for some helpful tutorials on C#'s Datetime struct.

            static bool HasFriday13th(int month, int year)
            {
                return new DateTime(year, month, 13).DayOfWeek == DayOfWeek.Friday;
            }



            //Consecutive Numbers 67

            //Create a function that determines whether elements in an array can be re - arranged to form a consecutive list of numbers where each number appears exactly once.

            //Examples
            //Cons([5, 1, 4, 3, 2]) ➞ true
            //// Can be re-arranged to form [1, 2, 3, 4, 5]

            //Cons([5, 1, 4, 3, 2, 8]) ➞ false

            //Cons([5, 6, 7, 8, 9, 9]) ➞ false
            //// 9 appears twice
            //Notes
            //N / A

            static bool Cons(int[] arr)
            {
                Array.Sort(arr);
                for (int i = 0, j = arr[0]; i < arr.Length; i++, j++)
                {
                    if (arr[i] != j)
                    {
                        return false;
                    }
                }
                return true;
            }



            //Is the Input Factorial of an Integer ? 68

            //Create a function that checks if a given integer is exactly the factorial of an integer or not. true if it is, false otherwise.

            //Examples
            //isFactorial(2) ➞ true
            //// 2 = 2 * 1 = 2!

            //isFactorial(27) ➞ false

            //isFactorial(24) ➞ true
            //// 24 = 4 * 3 * 2 * 1 = 4!
            //Notes
            //No error handling is necessary.Inputs are all positive integers.
            //Alternatively, you can solve this with a recursive approach.

            static bool isFactorial(int n)
            {
                int j = 1;
                for (int i = 1; i < n; i++)
                {
                    j *= i;
                    if (j == n)
                        return true;
                }
                return false;
            }



            //Clear Brackets 69

            //Create a function Brackets() that takes a string and checks that the brackets in the math expression are correct.The function should return true or false.

            //Examples
            //Brackets("(a*(b-c)..... )") ➞ true

            //Brackets(")(a-b-45/7*(a-34))") ➞ false

            //Brackets("sin(90...)+.............cos1)") ➞ false
            //Notes
            //The string may not contain brackets, then return true.
            //String may contain spaces.
            //The string may be empty.

            static bool Brackets(string str)
            {
                char[] arr = str.ToCharArray();
                int count = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == '(')
                    {
                        if (Array.IndexOf(arr, ')', i + 1) == -1) return false;
                        count++;
                    }
                    if (arr[i] == ')')
                    {
                        if (count == 0) return false;
                        count--;
                    }
                }
                return (count == 0) ? true : false;
            }



            //The Karaca's Encryption Algorithm 70

            //Make a function that encrypts a given input with these steps:

            //Input: "apple"

            //Step 1: Reverse the input: "elppa"

            //Step 2: Replace all vowels using the following chart:

            //a => 0
            //e => 1
            //i => 2
            //o => 2
            //u => 3

            //// "1lpp0"
            //Step 3: Add "aca" to the end of the word: "1lpp0aca"

            //Output: "1lpp0aca"

            //Examples
            //Encrypt("banana") ➞ "0n0n0baca"

            //Encrypt("karaca") ➞ "0c0r0kaca"

            //Encrypt("burak") ➞ "k0r3baca"

            //Encrypt("alpaca") ➞ "0c0pl0aca"
            //Notes
            //All inputs are strings, no uppercases and all output must be strings.

            static string Encrypt(string word)
            {
                string vowels = "aeiou";
                string subVowel = "01223";
                string revWord = "";

                foreach (var ch in word.ToCharArray())
                {
                    revWord = (vowels.Contains(ch) ? subVowel[vowels.IndexOf(ch)] : ch) + revWord;
                }

                return revWord + "aca";
            }



            //Check if an Array Contains a Given Number 71

            //Write a method to check if an array contains a particular number.

            //Examples
            //Check([1, 2, 3, 4, 5], 3) ➞ true

            //Check([1, 1, 2, 1, 1], 3) ➞ false

            //Check([5, 5, 5, 6], 5) ➞ true

            //Check([], 5) ➞ false
            //Notes
            //Don't forget to return the result.
            //If you get stuck on a challenge, find help in the Resources tab.
            //If you're really stuck, unlock solutions in the Solutions tab.

            static bool Check(int[] arr, int el)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == el)
                    {
                        return true;
                    }
                }
                return false;
            }



            //Nth Fibonacci Number 72

            //Create a function to return the Nth number in the Fibonacci sequence as a string.

            //Examples
            //Fibonacci(10) ➞ "55"

            //Fibonacci(20) ➞ "6765"

            //Fibonacci(30) ➞ "832040"

            //Fibonacci(40) ➞ "102334155"

            //Fibonacci(50) ➞ "12586269025"

            //Fibonacci(60) ➞ "1548008755920"
            //Notes
            //Your function is expected to calculate numbers greater than UInt64.MaxValue where n can be as large as but not greater than 200.

            static string Fibonacci(int n)
            {
                BigInteger result = 0;
                BigInteger first = 0;
                BigInteger second = 1;

                if (n == 0) return 0.ToString();
                if (n == 1) return 1.ToString();

                for (var i = 2; i <= n; i++)
                {
                    result = first + second;
                    first = second;
                    second = result;
                }
                return result.ToString();
            }



            //Longest Common Ending 73

            //Write a function that returns the longest common ending between two strings.

            //Examples
            //LongestCommonEnding("multiplication", "ration") ➞ "ation"

            //LongestCommonEnding("potent", "tent") ➞ "tent"

            //LongestCommonEnding("skyscraper", "carnivore") ➞ ""
            //Notes
            //Return an empty string if there exists no common ending.

            static string LongestCommonEnding(string str1, string str2)
            {
                int i = 0;
                while (i < str1.Length && i < str2.Length && str1[str1.Length - i - 1] == str2[str2.Length - i - 1])
                {
                    i++;
                }
                return str1.Substring(str1.Length - i, i);
            }



            //Find the Index(Part #2) 74

            //Find the Index(Part #2)
            //Create a function that searches for the index of a given item in an array using recursion.If the item is present, it should return the index, otherwise, it should return -1.

            //Examples
            //Search([1, 2, 3, 4], 3) ➞ 2

            //Search([2, 4, 6, 8, 10], 8) ➞ 3

            //Search([1, 3, 5, 7, 9], 11) ➞ -1
            //Notes
            //Use recursion.
            //Avoid using Linq.
            //If the item is not present, return -1.
            //The given array is ordered.

            static int Search(int[] arr, int item)
            {
                return Array.IndexOf(arr, item);
            }



            //Find the Vertex of a Quadratic 75

            //Every quadratic curve y = a x² +b x + c has a vertex point: the turning point where the curve stops heading down and starts going up.

            //Given the values a, b and c, you need to return the coordinates of the vertex. Return your answers rounded to 2 decimal places.

            //Examples
            //FindVertex(1, 0, 25)  ➞ [0, 25]
            //// The vertex of y=x²+25 is at (0, 25).

            //FindVertex(-1, 0, 25) ➞ [0, 25]
            //// The vertex of y=-x²+25 is at (0, 25).

            //FindVertex(1, 10, 4) ➞ [-5, -21]
            //// The vertex of y=x²+10x+4 is at (-5, -21).
            //Notes
            //See Resources if you're not sure how to find the x or y coordinates of the vertex.
            //a will always be non - zero.

            static double[] FindVertex(int a, int b, int c)
            {
                double h = Math.Round((double)-b / (2 * a), 2);
                double k = Math.Round(a * h * h + b * h + c, 2);
                return new[] { h, k };
            }



            //C* ns*r * d Str* ngs 76

            //Someone has attempted to censor my strings by replacing every vowel with a *, l* k*th * s.Luckily, I've been able to find the vowels that were removed.

            //Given a censored string and a string of the censored vowels, return the original uncensored string.

            //Example
            //uncensor("Wh*r* d*d my v*w*ls g*?", "eeioeo") ➞ "Where did my vowels go?"

            //uncensor("abcd", "") ➞ "abcd"

            //uncensor("*PP*RC*S*", "UEAE") ➞ "UPPERCASE"
            //Notes
            //The vowels are given in the correct order.
            //The number of vowels will match the number of* characters in the censored string.

            static string Uncensor(string str, string chrStr)
            {
                int alt = 0;

                string res = null;

                foreach (char chr in str)
                {
                    if (chr == '*')
                    {
                        res = res + chrStr[alt];

                        alt++;
                    }
                    else res = res + chr;
                }
                return res;
            }



            //Word Endings 77

            //Create a function that adds a string ending to each member in an array.

            //Examples
            //AddEnding(["clever", "meek", "hurried", "nice"], "ly")
            //➞ ["cleverly", "meekly", "hurriedly", "nicely"]

            //AddEnding(["new", "pander", "scoop"], "er")
            //➞ ["newer", "panderer", "scooper"]

            //AddEnding(["bend", "sharpen", "mean"], "ing")
            //➞ ["bending", "sharpening", "meaning"]
            //Notes
            //Don't forget to return the result.
            //If you get stuck on a challenge, find help in the Resources tab.
            //If you're really stuck, unlock solutions in the Solutions tab.

            static string[] AddEnding(string[] arr, string ending)
            {
                for (int i = 0; i < arr.Length; i++)
                    arr[i] += ending;
                return arr;
            }



            //Sum of Prime Numbers 78

            //Create a function that takes a list of numbers and returns the sum of all prime numbers in the list.

            //Examples
            //SumPrimes(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }) ➞ 17

            //SumPrimes(new int[] { 2, 3, 4, 11, 20, 50, 71 }) ➞ 87

            //SumPrimes(new int[] { }) ➞ 0
            //Notes
            //Given numbers won't exceed 101.
            //A prime number is a number which has exactly two divisors(1 and itself).

            static bool _IsPrime(int n)
            {
                //Lé awesome comment
                //hvis n = 3, så kigger den på statementet (i < (int)Math.Sqrt(n) + 1)...
                //som er..: 3 < 2(2 fordi det er kvadratroden af 3 afrundet til et helt tal(som er 1), +1 til sidst)
                if (n < 3) return n > 1;
                if (n % 2 == 0) return false;
                for (var i = 3; i < (int)Math.Sqrt(n) + 1; i += 2)
                {
                    if (n % i == 0) return false;
                }
                return true;
            }



            //Find the Index(Part 1) 79

            //Create a function that finds the index of a given item.

            //Examples
            //Search([1, 5, 3], 5) ➞ 1

            //Search([9, 8, 3], 3) ➞ 2

            //Search([1, 2, 3], 4) ➞ -1
            //Notes
            //If the item is not present, return -1.

            static int NewSearch(int[] arr, int item)
            {
                int count = -1;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == item)
                    {
                        count = i;
                    }
                }

                return count;

            }



            //Reverse Coding Challenge #1 80

            //This is a reverse coding challenge. Normally you're given explicit directions with how to create a function. Here, you must generate your own function to satisfy the relationship between the inputs and outputs.

            //Your task is to create a function that, when fed the inputs below, produce the sample outputs shown.

            //Examples
            //"A4B5C2" ➞ "AAAABBBBBCC"

            //"C2F1E5" ➞ "CCFEEEEE"

            //"T4S2V2" ➞ "TTTTSSVV"

            //"A1B2C3D4" ➞ "ABBCCCDDDD"
            //Notes
            //If you get stuck, check the Comments for help.

            static string MysteryFunc1(string str)
            {
                string str2 = "";

                for (int i = 0; i < str2.Length; i = i + 2)
                {
                    str2 += new string(str2[i], int.Parse((str2[i]).ToString()));
                }

                return str2;

            }



            //Reverse Coding Challenge 81

            //This is a reverse coding challenge. Normally you're given explicit directions with how to create a function. Here, you must generate your own function to satisfy the relationship between the inputs and outputs.

            //Your task is to create a function that, when fed the inputs below, produce the sample outputs shown.

            //Examples
            //832 ➞ 594

            //51 ➞ 36

            //7977 ➞ 198

            //1 ➞ 0

            //665 ➞ 99

            //149 ➞ 0
            //Notes
            //If you get stuck, see Comments for a hint.

            static int MysteryFunc2(int num)
            {
                char[] arr = num.ToString().ToCharArray();
                Array.Sort(arr);

                return num - Int32.Parse(new string(arr));

            }



            //Count the Number of Duplicate Characters 82

            //Create a function that takes a string and returns the number of alphanumeric characters that occur more than once.

            //Examples
            //DuplicateCount("abcde") ➞ 0

            //DuplicateCount("aabbcde") ➞ 2

            //DuplicateCount("Indivisibilities") ➞ 2

            //DuplicateCount("Aa") ➞ 0
            //// Case sensitive
            //Notes
            //Duplicate characters are case sensitive.
            //The input string will contain only alphanumeric characters.

            static int DuplicateCount(string str)
            {
                int count = 0;
                char[] unique = str.Distinct().ToArray();
                foreach (char c in unique)
                {
                    if (str.Count(x => x == c) > 1)
                    {
                        count++;
                    }
                }
                return count;
            }



            //Parseltongue 83

            //Hermione has come up with a precise formula for determining whether or not a phrase was ssspoken by a parssseltongue(a reference from the Harry Potter universe; the language of ssserpents and those who can converse with them).

            //Each word in a sssentence must contain either:

            //            Exactly two instances of the letter "s"(i.e.must be together ss), or...
            //Zero instances of the letter "s" by itself.
            //Examples
            //IsParselTongue("Sshe ssselects to eat that apple. ") ➞ true

            //IsParselTongue("She ssselects to eat that apple. ") ➞ false
            //// "She" only contains one "s".
            //// "ssselects" has three instances of "s" together (is not exactly two).

            //            IsParselTongue("Beatrice samples lemonade") ➞ false
            //// While "samples" has 2 instances of "s", they are not together.

            //IsParselTongue("You ssseldom sssspeak sso boldly, ssso messmerizingly.") ➞ true
            //Notes
            //N / A

            static bool IsParselTongue(string sentence)
            {
                string[] arr = sentence.Split(' ');

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i].ToLower().Contains("s"))
                        if (!arr[i].ToLower().Contains("ss"))
                            return false;
                }
                return true;
            }



            //Reverse Coding Challenge #2 84

            //This is a reverse coding challenge.

            //Your task is to create a function that, when fed the inputs below, produce the sample outputs shown.

            //Examples
            //3 ➞ 21

            //9 ➞ 2221

            //17 ➞ 22221

            //24 ➞ 22228
            //Notes
            //If you get stuck, check the Comments for help.

            static int MysteryFunc(int num)
            {
                int total = 2;
                int ret = 0;
                while (num >= total)
                {
                    total *= 2;
                    ret = ret * 10 + 2;
                }
                return ret * 10 + (num % (total / 2));
            }

            //The Major Sum 85

            //Create a function that takes an integer array and return the biggest between positive sum, negative sum, or 0s count. The major is understood as the greatest absolute.

            //arr = { 1,2,3,4,0,0,-3,-2}, the function has to return 10, because:

            //            Positive sum = 1 + 2 + 3 + 4 = 10
            //Negative sum = (-3) + (-2) = -5
            //0s count = 2(there are two zeros in array)
            //Examples
            //MajorSum(1, 2, 3, 4, 0, 0, -3, -2) ➞ 10

            //MajorSum(-4, -8, -12, -3, 4, 7, 1, 3, 0, 0, 0, 0) ➞ -27

            //MajorSum(0, 0, 0, 0, 0, 1, 2, -3) ➞ 5
            //// Because -3 < 1+2 < 0sCount = 5
            //Notes
            //All numbers are integers.
            //There aren't empty arrays.
            //All tests are made to return only one value.

            static int BridgesII(string str)
            {
                string[] arr = str.Split('/');
                int counter = arr.Where(x => !x.Contains(' ')).Count();
                for (int i = 0; i < arr.Length; i++)
                    if (arr.All(x => x[i] == '#'))
                        counter++;
                return counter;
            }



            //Wrap Around 86

            //Create a function to reproduce the wrap around effect shown:

            //Examples
            //WrapAround("Hello, World!", 2) ➞ "llo, World!He"

            //WrapAround("From what I gathered", -4) ➞ "eredFrom what I gath"

            //WrapAround("Excelsior", 30) ➞ "elsiorExc"

            //WrapAround("Nonscience", -116) ➞ "cienceNons"
            //Notes
            //The offset can be negative.
            //The offset can be greater than string.

            static string WrapAround(string input, int offset)
            {
                if (offset < 0)
                    while (offset < 0)
                        offset = offset + input.Length;
                else if (offset > input.Length)
                    while (offset > input.Length)
                        offset = offset - input.Length;
                return (input + input.Substring(0, offset)).Remove(0, offset);
            }



            //Perfect Square Patch 87

            //Create a function that takes an integer and outputs an n x n square solely consisting of the integer n.

            //Examples
            //SquarePatch(3) ➞ [
            //  [3, 3, 3],
            //  [3, 3, 3],
            //  [3, 3, 3]
            //]

            //SquarePatch(5) ➞ [
            //  [5, 5, 5, 5, 5],
            //  [5, 5, 5, 5, 5],
            //  [5, 5, 5, 5, 5],
            //  [5, 5, 5, 5, 5],
            //  [5, 5, 5, 5, 5]
            //]

            //SquarePatch(1) ➞ [
            //  [1]
            //]

            //SquarePatch(0) ➞ []
            //            Notes
            //n >= 0.
            //If n = 0, return an empty array.

            static int[,] SquarePatch(int n)
            {
                if (n == 0)
                {
                    int[,] zeroArray = new int[0, 0];
                    return zeroArray;
                }
                else
                {
                    int[,] nArray = new int[n, n];

                    for (int i = 0; i < n; i++)
                    {
                        for (int y = 0; y < n; y++)
                        {
                            nArray[i, y] = n;
                        }
                    }
                    return nArray;

                }
            }



            //Wrap Around 88

            //Create a function to reproduce the wrap around effect shown:

            //Examples
            //WrapAround("Hello, World!", 2) ➞ "llo, World!He"

            //WrapAround("From what I gathered", -4) ➞ "eredFrom what I gath"

            //WrapAround("Excelsior", 30) ➞ "elsiorExc"

            //WrapAround("Nonscience", -116) ➞ "cienceNons"
            //Notes
            //The offset can be negative.
            //The offset can be greater than string.

            static string wrapAround(string input, int offset)
            {
                offset = offset % input.Length;
                if (offset < 0)
                {
                    offset = input.Length + offset;
                }
                return input.Substring(offset) + input.Substring(0, offset);
            }



            //Recursion: Sum 89

            //Write a function that recursively finds the sum of the first n natural numbers.

            //Examples
            //Sum(5) ➞ 15
            //// 1 + 2 + 3 + 4 + 5 = 15

            //Sum(1) ➞ 1

            //Sum(12) ➞ 78
            //Notes
            //Assume the input number is always positive.
            //Check the Resources tab for info on recursion.

            static int Sum(int n)
            {
                if (n > 0)
                {
                    return n + Sum(n - 1);
                }
                return 0;
            }



            //Creating a Picture Frame 90

            //Create a function that takes the width, height and character and returns a picture frame as an array of strings(string[]).

            //Examples
            //get_frame(4, 5, "#") ➞ [
            //  "####",
            //  "#  #",
            //  "#  #",
            //  "#  #",
            //  "####"
            //]
            //// Frame is 4 characters wide and 5 characters tall.


            //get_frame(10, 3, "*") ➞ [
            //  "**********",
            //  "*        *",
            //  "**********"
            //]
            //// Frame is 10 characters and wide and 3 characters tall.


            //get_frame(2, 5, "0") ➞ "invalid"
            //// Frame"s width is less than 3.
            //Notes
            //Remember the gap.
            //Return["invalid"] if width or height is less than 3(can't put anything inside).

            static string[] GetFrame(int w, int h, char ch)
            {
                string[] frame = new string[h];
                if (w > 2 && h > 2)
                {
                    for (int i = 0; i < h; i++)
                    {
                        string row = "";
                        if (i == 0 || i == h - 1)
                        {
                            for (int y = 0; y < w; y++)
                            {
                                row += ch.ToString();
                            }
                        }
                        else
                        {
                            row += ch.ToString();
                            for (int y = 0; y < w - 2; y++)
                            {
                                row += " ";
                            }
                            row += ch.ToString();
                        }
                        frame[i] = row;
                    }
                }
                else
                {
                    frame[0] = "invalid";
                }
                return frame;
            }

            //Moran Numbers 91

            //A Harshad number is a number which is divisible by the sum of its digits.For example, 132 is divisible by 6(1 + 3 + 2).

            //A subset of the Harshad numbers are the Moran numbers. Moran numbers yield a prime when divided by the sum of their digits.For example, 133 divided by 7(1 + 3 + 3) yields 19, a prime.

            //Create a function that takes a number and returns "M" if the number is a Moran number, "H" if it is a(non - Moran) Harshad number, or "Neither".

            //Examples
            //Moran(132) ➞ "H"

            //Moran(133) ➞ "M"

            //Moran(134) ➞ "Neither"
            //Notes
            //N / A

            static string Moran(int n)
            {
                int number = n.ToString().Sum(x => x - '0');
                int number2;
                if (n % number == 0)
                {
                    number2 = n / number;
                    if (number2 <= 1)
                        return "H";

                    if (number2 == 2)
                        return "M";

                    if (number2 % 2 == 0)
                        return "H";

                    for (int i = 3; i <= (int)Math.Floor(Math.Sqrt(number2)); i += 2)
                    {
                        if (number2 % i == 0)
                            return "H";
                    }

                    return "M";
                }

                return "Neither";
            }



            //Split the String into N Cases of Equal Length 92

            //Create a function that accepts string input and int cases as parameters where the string is split into N distinct cases of equal length as shown:

            //Examples
            //SplitNCases("Strengthened", 6) ➞ { "St", "re", "ng", "th", "en", "ed" }

            //SplitNCases("Unscrupulous", 2) ➞ { "Unscru", "pulous" }

            //SplitNCases("Flavorless", 1) ➞ { "Flavorless" }
            //Notes
            //If it's not possible to split the string as described, return { "Error" }.

            static string[] SplitNCases(string input, int cases)
            {
                List<string> final = new List<string>();
                char[] arr = input.ToCharArray();

                if (input.Length % cases != 0)
                {
                    final.Add("Error");
                }

                else
                {
                    for (int j = 0; j < input.Length; j = j + (input.Length / cases))
                    {
                        string s = string.Empty;

                        for (int i = j; i < (j + (input.Length / cases)); i++)
                        {
                            s = s + arr[i];
                        }

                        final.Add(s);
                    }
                }

                return (final.ToArray());

            }



            //Mangle the String 93

            //Create a function that takes a string and replaces every letter with the letter following it in the alphabet("c" becomes "d", "z" becomes "a", "b" becomes "c", etc). Then capitalize every vowel(a, e, i, o, u) and return the new modified string.

            //Examples
            //Mangle("Fun times!") ➞ "GvO Ujnft!"

            //Mangle("The quick brown fox.") ➞ "UIf rvjdl cspxO gpy."

            //Mangle("Omega") ➞ "Pnfhb"
            //Notes
            //If a letter is already uppercase, return it as uppercase (regardless of being a vowel).
            //"y" is not considered a vowel.

            static string Mangle(string str)
            {
                StringBuilder sb = new StringBuilder();
                var nextLetter = ' ';
                for (int i = 0; i < str.Length; i++)
                {
                    if (!char.IsLetterOrDigit(str[i]))
                        nextLetter = str[i];
                    else if (str[i] == 'z')
                        nextLetter = 'a';
                    else if (str[i] == 'Z')
                        nextLetter = 'A';

                    else nextLetter = (char)(((int)str[i]) + 1);
                    sb.Append(nextLetter);
                }

                for (int i = 0; i < sb.Length; i++)
                {
                    if (sb[i] == 'a' || sb[i] == 'e' || sb[i] == 'i' || sb[i] == 'o' || sb[i] == 'u')
                    {
                        sb[i] = char.ToUpper(sb[i]);
                    }
                }
                return sb.ToString();
            }



            //Rolling Cipher 94

            //rite a function that accepts a string and an n and returns a cipher by rolling each character forward(n > 0) or backward(n< 0) n times.

            //Note: Think of the letters as a connected loop, so rolling a backwards once will yield z, and rolling z forward once will yield a. If you roll 26 times in either direction, you should end up back where you started.

            //Examples
            //RollingCipher("abcd", 1) ➞ "bcde"

            //RollingCipher("abcd", -1) ➞ "zabc"

            //RollingCipher("abcd", 3) ➞ "defg"

            //RollingCipher("abcd", 26) ➞ "abcd"
            //Notes
            //All letters are lower cased.
            //No spacing.
            //Each character is rotated the same number of times.

            static string RollingCipher(string str, int n)
            {
                char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
                string result = "";
                int index = Array.IndexOf(alphabet, str[0]);
                index = index + n;
                if (index < 0)
                {
                    index = 26 + n;
                }
                for (int i = index; i < index + 4; i++)
                {
                    int index2 = i;
                    if (index2 > 25)
                    {
                        index2 = index2 - 26;
                    }
                    result += alphabet[index2];
                }
                return result;
            }



            //12 vs 24 Hours 95

            //Create a function that converts 12 - hour time to 24 - hour time or vice versa. Return the output as a string.

            //Examples
            //ConvertTime("12:00 am") ➞ "0:00"

            //ConvertTime("6:20 pm") ➞ "18:20"

            //ConvertTime("21:00") ➞ "9:00 pm"

            //ConvertTime("5:05") ➞ "5:05 am"
            //Notes
            //A 12 - hour time input will be denoted with an am or pm suffix.
            //  A 24 - hour input time contains no suffix.

            static string ConvertTime(string time)
            {
                string[] arr = time.Split(':');
                int hours = int.Parse(arr[0]);
                if (time.Length <= 5)
                {
                    if (hours < 12)
                    {
                        return time + " am";
                    }
                    else
                    {
                        hours = hours - 12;

                        return hours.ToString() + ":" + arr[1] + " pm";
                    }
                }
                else
                {

                    if (arr[1].Substring(3, 1) == "a")
                    {
                        hours = hours - 12;
                        return hours.ToString() + ":" + arr[1].Substring(0, 2);
                    }
                    else
                    {
                        hours = hours + 12;
                        return hours.ToString() + ":" + arr[1].Substring(0, 2);
                    }
                }
            }



            //Correct Inequality Signs 96

            //Create a function that returns true if a given inequality expression is correct and false otherwise.

            //Examples
            //CorrectSigns("3 < 7 < 11") ➞ true

            //CorrectSigns("13 > 44 > 33 > 1") ➞ false

            //CorrectSigns("1 < 2 < 6 < 9 > 3") ➞ true
            //Notes
            //N / A

            static bool CorrectSigns(string str)
            {
                string[] nums = str.Split(' ');
                bool isRight = false;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == ">")
                    {
                        if (Int32.Parse(nums[i - 1]) > Int32.Parse(nums[i + 1]))
                        {
                            isRight = true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else if (nums[i] == "<")
                    {
                        if (Int32.Parse(nums[i - 1]) < Int32.Parse(nums[i + 1]))
                        {
                            isRight = true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }

                return isRight;

            }



            //Difference Cipher 97

            //It's time to send and receive secret messages.

            //Create two functions that take a string and an array and returns a coded or decoded message.

            //The first letter of the string, or the first element of the array represents the Character Code of that letter.The next elements are the differences between the characters: e.g.A + 3-- > C or z -1-- > y.

            //Examples
            //Encrypt("Hello") ➞ [72, 29, 7, 0, 3]
            //// H = 72, the difference between the H and e is 29 (upper- and lowercase).
            //// The difference between the two l's is obviously 0.

            //Decrypt([72, 33, -73, 84, -12, -3, 13, -13, -68]) ➞ "Hi there!"

            //Encrypt("Sunshine") ➞ [83, 34, -7, 5, -11, 1, 5, -9]
            //Notes
            //The input of the encrypt function will always be a string.
            //The input of the decrypt function will always be an array with numbers.

            static int[] EncryptCipher(string str)
            {
                List<int> nums = new List<int>();

                foreach (char character in str)
                {
                    if (nums.Count == 0) nums.Add((int)character);
                    else nums.Add(character - nums.Sum());
                }

                return nums.ToArray();

            }

            static string DecryptCipher(int[] arr)
            {
                StringBuilder builder = new StringBuilder();
                char currentChar = (char)0;

                foreach (int item in arr)
                {
                    if (currentChar == (char)0) currentChar = (char)item;
                    else currentChar = (char)(currentChar + item);
                    builder.Append(currentChar);
                }

                return builder.ToString();

            }



            //Count the Arguments 98

            //Create a method that returns the number of arguments it was called with.

            //Examples
            //NumArgs() ➞ 0

            //NumArgs("foo") ➞ 1

            //NumArgs("foo", "bar") ➞ 2

            //NumArgs(true, false) ➞ 2

            //NumArgs({ }) ➞ 1
            //Notes
            //If you get stuck on a challenge, find help in the Resources tab.
            //If you're really stuck, unlock solutions in the Solutions tab.

            static int NumArgs(params object[] p)
            {
                return p.Length;
            }



            //Convert Age to Days 99

            //Create a function that takes an age in years and returns the age in days.

            //Examples
            //CalcAge(65) ➞ 23725

            //CalcAge(0) ➞ 0

            //CalcAge(20) ➞ 7300
            //Notes
            //Use 365 days as the length of a year for this challenge.
            //Ignore leap years and days between last birthday and now.
            //Expect only positive integer inputs.

            static int CalcAge(int age)
            {
                return age * 365;
            }



            //Perfect Square Patch 100

            //Create a function that takes an integer and outputs an n x n square solely consisting of the integer n.

            //Examples
            //SquarePatch(3) ➞ [
            //  [3, 3, 3],
            //  [3, 3, 3],
            //  [3, 3, 3]
            //]

            //SquarePatch(5) ➞ [
            //  [5, 5, 5, 5, 5],
            //  [5, 5, 5, 5, 5],
            //  [5, 5, 5, 5, 5],
            //  [5, 5, 5, 5, 5],
            //  [5, 5, 5, 5, 5]
            //]

            //SquarePatch(1) ➞ [
            //  [1]
            //]

            //SquarePatch(0) ➞ []
            //            Notes
            //n >= 0.
            //If n = 0, return an empty array.

            static int[,] SquarePatchs(int n)
            {
                if (n == 0)
                {
                    int[,] zeroArray = new int[0, 0];
                    return zeroArray;
                }
                else
                {
                    int[,] nArray = new int[n, n];

                    for (int i = 0; i < n; i++)
                    {
                        for (int y = 0; y < n; y++)
                        {
                            nArray[i, y] = n;
                        }
                    }
                    return nArray;

                }
            }



            //Possible Palindrome 101

            //Create a function that determines whether it is possible to build a palindrome from the characters in a string.

            //Examples
            //PossiblePalindrome("acabbaa") ➞ true
            //// Can make the following palindrome: "aabcbaa"

            //PossiblePalindrome("aacbdbc") ➞ true
            //// Can make the following palindrome: "abcdcba"

            //PossiblePalindrome("aacbdb") ➞ false

            //PossiblePalindrome("abacbb") ➞ false
            //Notes
            //N / A

            static bool PossiblePalindrome(string str)
            {
                int count = 0;
                while (str.Length != 0)
                {
                    string result = str[0] + "";
                    str = str.Remove(0, 1);
                    if (str.Contains(result))
                    {
                        str = str.Remove(str.IndexOf(result), 1);
                    }
                    else
                    {
                        count++;
                        if (count == 2) return false;
                    }
                }
                return true;
            }



            //Average Word Length 102

            //Create a function that takes in a sentence and returns the average length of each word in that sentence. Round your result to two decimal places.

            //Examples
            //AverageWordLength("A B C.") ➞ 1.00

            //AverageWordLength("What a gorgeous day.") ➞ 4.00

            //AverageWordLength("Dude, this is so awesome!") ➞ 3.80
            //Notes
            //Ignore punctuation when counting the length of a word.

            static double AverageWordLength(string str)
            {
                string newstr = Regex.Replace(str, "[^A-Za-z ]", "");
                double average = newstr.Split(' ').Select(x => x.Length).Average();

                return Math.Round(average, 2);
            }



            //Rhyme Time 103

            //Create a function that returns true if two lines rhyme and false otherwise.For the purposes of this exercise, two lines rhyme if the last word from each sentence contains the same vowels.

            //Examples
            //DoesRhyme("Sam I am!", "Green eggs and ham.") ➞ true

            //DoesRhyme("Sam I am!", "Green eggs and HAM.") ➞ true
            //// Capitalization and punctuation should not matter.

            //DoesRhyme("You are off to the races", "a splendid day.") ➞ false

            //DoesRhyme("and frequently do?", "you gotta move.") ➞ false
            //Notes
            //Case insensitive.
            //Here we are disregarding cases like "thyme" and "lime".
            //We are also disregarding cases like "away" and "today"(which technically rhyme, even though they contain different vowels).

            static bool DoesRhyme(string str1, string str2)
            {
                string[] vowels = { "a", "e", "i", "o", "u" };
                bool result = false;
                foreach (string v in vowels)
                {
                    if (str1.Split(' ').Last().ToLower().Contains(v) || str2.Split(' ').Last().ToLower().Contains(v))
                    {
                        result = (str1.Split(' ').Last().ToLower().Contains(v) && str2.Split(' ').Last().ToLower().Contains(v));
                        if (!result)
                            break;
                    }
                }

                return (result);
            }



            //Recursion: Sum 104

            //Write a function that recursively finds the sum of the first n natural numbers.

            //Examples
            //Sum(5) ➞ 15
            //// 1 + 2 + 3 + 4 + 5 = 15

            //Sum(1) ➞ 1

            //Sum(12) ➞ 78
            //Notes
            //Assume the input number is always positive.
            //Check the Resources tab for info on recursion.

            static int Sum2(int n)
            {
                if (n == 1)
                {
                    return 1;
                }
                return n + Sum(n - 1);
            }



            //Power Calculator 105

            //Create a function that takes voltage and current and returns the calculated power.

            //Examples
            //CircuitPower(230, 10) ➞ 2300

            //CircuitPower(110, 3) ➞ 330

            //CircuitPower(480, 20) ➞ 9600
            //Notes
            //N / A

            static int CircuitPower(int voltage, int current)
            {
                return voltage * current;
            }



            //Next Number Greater Than A and B and Divisible by B 106

            //You are given two numbers a and b. Create a function that returns the next number greater than a and b and divisible by b.

            //Examples
            //DivisibleByB(17, 8) ➞ 24

            //DivisibleByB(98, 3) ➞ 99

            //DivisibleByB(14, 11) ➞ 22
            //Notes
            //a will always be greater than b.

            static int DivisibleByB(int a, int b)
            {
                int result = a;

                while (true)
                {
                    if (result % b == 0)
                    {
                        return result;
                    }
                    else
                    {
                        result++;
                    }
                }
            }



            //Break Point 107

            //A number has a breakpoint if it can be split in a way where the digits on the left side and the digits on the right side sum to the same number.

            //For instance, the number 35190 can be sliced between the digits 351 and 90, since 3 + 5 + 1 = 9 and 9 + 0 = 9.On the other hand, the number 555 does not have a breakpoint(you must split between digits).

            //Create a function that returns true if a number has a breakpoint, and false otherwise.

            //Examples
            //BreakPoint(159780) ➞ true

            //BreakPoint(112) ➞ true

            //BreakPoint(1034) ➞ true

            //BreakPoint(10) ➞ false

            //BreakPoint(343)  ➞ false
            //Notes
            //Read each digit as only one number.
            //Check the resources tab for a hint.

            static bool BreakPoint(int num)
            {
                char[] nums = num.ToString().ToCharArray();
                int suma = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    suma += int.Parse(nums[i].ToString());
                }
                int sumb = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    sumb += int.Parse(nums[i].ToString());
                    suma -= int.Parse(nums[i].ToString());
                    if (sumb == suma) { return true; }
                }
                return false;
            }



            //Fix the Error: Check Whether a Given Number Is Odd 108

            //Éowyn has written the function IsOdd() to check if a given number is odd or not.Unfortunately, the function does not return the correct result for all the inputs.Help her fix the error.


            //Examples
            //IsOdd(-5) ➞ true


            //IsOdd(25) ➞ true


            //IsOdd(0) ➞ false
            //Notes
            //All the inputs will only be integers.

            static bool IsOdd(int num)
            {
                if (num % 2 == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }



            //Is One String in the Other? 109

            //Create a function that takes two strings and returns true if either of the strings appears at the very end of the other string.Return false otherwise.The character * is a wildcard, so it can take the place of any character.

            //Examples
            //Overlap("ABC", "Ican'tsingmyABC") ➞ true

            //Overlap("abc", "Ican'tsingmyABC") ➞ true

            //Overlap("Ican'tsingmyABC", "abc") ➞ true

            //Overlap("hello world", "hello") ➞ false

            //Overlap("+=", "this should work too +=") ➞ true

            //Overlap("hey", "*********") ➞ true
            //Notes
            //Your function should NOT be case sensitive(see example #2).

            static bool Overlap(string str1, string str2)
            {
                int i = 0, j = 0;
                if (str1.Length < str2.Length)
                {
                    j = str2.Length - str1.Length;
                }
                else
                {
                    i = str1.Length - str2.Length;
                }
                while (i < str1.Length)
                {
                    if (str1[i] != '*' && str2[j] != '*' && char.ToLower(str1[i]) != char.ToLower(str2[j]))
                    {
                        return false;
                    }

                    i++; j++;

                }

                return true;
            }



            //Need Help With Your Packing ? 110

            //You arrive at the supermarket checkout and you've only got a limited number of shopping bags with you. Miser that you are, you hate buying extra bags when you've got dozens at home that you forgot to bring with you!!Can you fit all your shopping into the bags you've got with you?

            //Each bag can carry a maximum of 10kg and each item you've purchased weighs between 1 and 10kg.

            //Create a function that takes two parameters, a list of the weights of each item and the number of bags you are carrying. Return True if there are enough bags to contain all the items, otherwise False.

            //Example
            //CanFit(new int[] { 2, 1, 2, 5, 4, 3, 6, 1, 1, 9, 3, 2 }, 4) ➞ True
            //// Bag 1 = [2, 1, 2, 5] (10kg)
            //// Bag 2 = [4, 3, 3] (10kg)
            //// Bag 3 = [6, 2, 1, 1] (10kg)
            //// Bag 4 = [9] (9kg)

            //            CanFit(new int[] { 2, 7, 1, 3, 3, 4, 7, 4, 1, 8, 2 ], 4) ➞ False
            //// Bag 1 = [2, 8] (10kg)
            //// Bag 2 = [3, 7] (10kg)
            //// Bag 3 = [2, 4, 4] (10kg)
            //// Bag 4 = [7, 3] (10kg)
            //// two 1kg items left over!
            //Notes
            //All weights will be integers between 1 and 10kg inclusive
            //Items can be packed in any order
            //There may be more than one way to fit all the items in the available bags
            //Based on an easier challenge How Many Boxes? by @zatoichi49.

            static bool CanFit(int[] weights, int bags)
            {
                int capacity = bags * 10;
                int weight = 0;
                for (int i = 0; i < weights.Length; i++)
                {
                    weight = weight + weights[i];
                }

                return (weight > capacity) ? false : true;
            }



            //Smallest Transform 111

            //Create a function that returns the smallest number of changes it takes to transform one number into one with identical digits.A step is incrementing or decrementing a digit by one.

            //Examples
            //SmallestTransform(399) ➞ 6
            //// 399 transformed to 999 in 6 steps.

            //SmallestTransform(1234) ➞ 4
            //// 1234 can be transformed to either 2222 or 3333 using 4 steps.

            //SmallestTransform(153) ➞ 4

            //SmallestTransform(33338) ➞ 5

            //SmallestTransform(7777) ➞ 0
            //Notes
            //If a number already has identical digits, return 0.

            static int SmallestTransform(int num)
            {
                int steps;
                int i = 0;
                int maxSteps = 999;
                string numStr = num.ToString();
                int[] digits = new int[numStr.Length];

                while (num != 0)
                {
                    digits[i] = num % 10;
                    num /= 10;
                    i++;
                }

                for (int j = 0; j < digits.Length; j++)
                {
                    steps = 0;
                    for (int k = 0; k < digits.Length; k++)
                    {
                        steps += Math.Abs(digits[k] - digits[j]);
                    }
                    if (steps < maxSteps)
                    {
                        maxSteps = steps;
                    }
                }
                return maxSteps;
            }



            //Briefcase Lock 112

            //A briefcase has a 4 - digit rolling -lock.Each digit is a number from 0 - 9 that can be rolled either forwards or backwards.

            //Create a function that returns the smallest number of turns it takes to transform the lock from the current combination to the target combination. One turn is equivalent to rolling a number forwards or backwards by one.

            //To illustrate:

            //current -lock: 4089
            //target -lock: 5672
            //What is the minimum number of turns it takes to transform 4089 to 5672 ?

            //4 ➞ 5
            //4 ➞ 5  // Forward Turns: 1 <- Min
            //4 ➞ 3 ➞ 2 ➞ 1 ➞ 0 ➞ 9 ➞ 8 ➞ 7 ➞ 6 ➞ 5  // Backward Turns: 9

            //0 ➞ 6
            //0 ➞ 1 ➞ 2 ➞ 3 ➞ 4 ➞ 5 ➞ 6  // Forward Turns: 6
            //0 ➞ 9 ➞ 8 ➞ 7 ➞ 6  // Backward Turns: 4  <- Min

            //8 ➞ 7
            //8 ➞ 9 ➞ 0 ➞ 1 ➞ 2 ➞ 3 ➞ 4 ➞ 5 ➞ 6 ➞ 7  // Forward Turns: 9
            //8 ➞ 7  // Backward Turns: 1  <- Min

            //9 ➞ 2
            //9 ➞ 0 ➞ 1 ➞ 2  // Forward Turns: 3  <- Min
            //9 ➞ 8 ➞ 7 ➞ 6 ➞ 5 ➞ 4 ➞ 3 ➞ 2  // Backward Turns: 7
            //It takes 1 + 4 + 1 + 3 = 9 minimum turns to change the lock from 4089 to 5672.

            //Examples
            //MinTurns("4089", "5672") ➞ 9

            //MinTurns("1111", "1100") ➞ 2

            //MinTurns("2391", "4984") ➞ 10
            //Notes
            //Both locks are in string format.
            //A 9 rolls forward to 0, and a 0 rolls backwards to a 9.

            static int MinTurns(string current, string target)
            {
                int total = 0;

                for (int index = 0; index < 4; index += 1)
                {
                    int largest = Math.Max(current[index], target[index]);
                    int smallest = Math.Min(current[index], target[index]);

                    total += Math.Min(
                            Math.Abs(largest - smallest),
                            Math.Abs(largest - (smallest + 10)));
                }

                return total;

            }



            //Encode Morse 113

            //Create a function that takes a string as an argument and returns the Morse code equivalent.

            //Examples
            //EncodeMorse("EDABBIT CHALLENGE") ➞ ". -.. .- -... -... .. -   -.-. .... .- .-.. .-.. . -. --. ."

            //EncodeMorse("HELP ME !") ➞ ".... . .-.. .--.   -- .   -.-.--"
            //Notes
            //Ouput should be International Morse Code, and use the standard conventions for symbols not defined inside the ITU recommendation(see Resources).
            //Input value can be lower or upper case.
            //Input string can have digits.
            //Input string can have some special characters(e.g.comma, colon, apostrophe, period, question mark, exclamation mark).
            //One space " " is expected after each character.

            static string EncodeMorse(string str)
            {
                var morse = new Dictionary<char, string>()
                {
                  {'a', ".-"},
                  {'b', "-..."},
                  {'c', "-.-."},
                  {'d', "-.."},
                  {'e', "."},
                  {'f', "..-."},
                  {'g', "--."},
                  {'h', "...."},
                  {'i', ".."},
                  {'j', ".---"},
                  {'k', "-.-"},
                  {'l', ".-.."},
                  {'m', "--"},
                  {'n', "-."},
                  {'o', "---"},
                  {'p', ".--."},
                  {'q', "--.-"},
                  {'r', ".-."},
                  {'s', "..."},
                  {'t', "-"},
                  {'u', "..-"},
                  {'v', "...-"},
                  {'w', ".--"},
                  {'x', "-..-"},
                  {'y', "-.--"},
                  {'z', "--.."},
                  {'0', "-----"},
                  {'1', ".----"},
                  {'2', "..---"},
                  {'3', "...--"},
                  {'4', "....-"},
                  {'5', "....."},
                  {'6', "-...."},
                  {'7', "--..."},
                  {'8', "---.."},
                  {'9', "----."},
                  {' ', " "},
                  {':', "---..."},
                  {'!', "-.-.--"},
                  {'?', "..--.."},
                  {',', "--..--"},
                  {'.', ".-.-.-"},
                  {'\'', ".----."}
                };

                var parts = new List<string>();

                foreach (char c in str.ToLower())
                {
                    parts.Add(morse[c]);
                }

                return string.Join(" ", parts);
            }



            //Knights on a Board 114

            //Write a function that returns true if the knights are placed on a chessboard such that no knight can capture another knight. Here, 0s represent empty squares and 1s represent knights.

            //Examples
            //CannotCapture(new int[,] {
            //  { 0, 0, 0, 1, 0, 0, 0, 0 },
            //  { 0, 0, 0, 0, 0, 0, 0, 0 },
            //  { 0, 1, 0, 0, 0, 1, 0, 0 },
            //  { 0, 0, 0, 0, 1, 0, 1, 0 },
            //  { 0, 1, 0, 0, 0, 1, 0, 0 },
            //  { 0, 0, 0, 0, 0, 0, 0, 0 },
            //  { 0, 1, 0, 0, 0, 0, 0, 1 },
            //  { 0, 0, 0, 0, 1, 0, 0, 0 }
            //}) ➞ True

            //CannotCapture(new int[,] {
            //  {1, 0, 1, 0, 1, 0, 1, 0},
            //  {0, 1, 0, 1, 0, 1, 0, 1},
            //  {1, 0, 1, 0, 1, 0, 1, 0},
            //  {0, 0, 0, 1, 0, 1, 0, 1},
            //  {1, 0, 0, 0, 1, 0, 1, 0},
            //  {0, 0, 0, 0, 0, 1, 0, 1},
            //  {1, 0, 1, 0, 1, 0, 1, 0},
            //  {1, 0, 0, 1, 0, 0, 0, 1}
            //}) ➞ False
            //Notes
            //Knights can be present in any of the 64 squares.
            //No other pieces except knights exist.

            static bool CannotCapture(int[,] board)
            {
                for (int column = 0; column < 8; ++column)
                {
                    for (int row = 0; row < 8; ++row)
                    {
                        if (board[column, row] == 1)
                        {
                            if (LandedOnOne(column, row, board))
                                return false;
                        }
                    }
                }

                return true;

            }


            static bool LandedOnOne(int column, int row, int[,] board)
            {
                if ((column - 1 >= 0 && row - 2 >= 0) && board[column - 1, row - 2] == 1)
                    return true;
                if ((column - 2 >= 0 && row - 1 >= 0) && board[column - 2, row - 1] == 1)
                    return true;
                if ((column - 2 >= 0 && row + 1 <= 7) && board[column - 2, row + 1] == 1)
                    return true;
                if ((column - 1 >= 0 && row + 2 <= 7) && board[column - 1, row + 2] == 1)
                    return true;
                if ((column + 1 <= 7 && row + 2 <= 7) && board[column + 1, row + 2] == 1)
                    return true;
                if ((column + 2 <= 7 && row + 1 <= 7) && board[column + 2, row + 1] == 1)
                    return true;
                if ((column + 2 <= 7 && row - 1 >= 0) && board[column + 2, row - 1] == 1)
                    return true;
                if ((column + 1 <= 7 && row - 2 >= 0) && board[column + 1, row - 2] == 1)
                    return true;

                return false;
            }



            //IPv4 Validation 115

            //Create a function that takes a string(IPv4 address in standard dot - decimal format) and returns true if the IP is valid or false if it's not. For information on IPv4 formatting, please refer to the resources in the Resources tab.

            //Examples
            //IsValidIP("1.2.3.4") ➞ true

            //IsValidIP("1.2.3") ➞ false

            //IsValidIP("1.2.3.4.5") ➞ false

            //IsValidIP("123.45.67.89") ➞ true

            //IsValidIP("123.456.78.90") ➞ false

            //IsValidIP("123.045.067.089") ➞ false
            //Notes
            //IPv6 addresses are not valid.
            //Leading zeros are not valid("123.045.067.089" should return false).
            //You can expect a single string for every test case.
            //Numbers may only be between 1 and 255.
            //The last digit may not be zero, but any other might.

            static bool IsValidIP(string IP)
            {
                string[] nums = IP.Split('.');

                if (nums.Length != 4)
                    return false;


                string digits = "0123456789";

                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = 0; j < nums[i].Length; j++)
                    {

                        //first digit
                        if (i != 0 && j == 0 && nums[i][j] == '0')
                            return false;

                        //last digit
                        if (i == 3 && j == nums[i].Length - 1 && nums[i][j] == '0')
                            return false;


                        if (!digits.Contains(nums[i][j].ToString()))
                            return false;

                    }
                }

                return true;

            }



            //Among Us Imposter Formula 116

            //Matt wants you to create a function that calculates the chance of being an imposter.The formula for the chances of being an imposter is 100 × (i / p) where i is the imposter count and p is the player count.Make sure to round the value to the nearest integer and return the value as a percentage.

            //Examples
            //ImposterFormula(1, 10) ➞ "10%"

            //ImposterFormula(2, 5) ➞ "40%"

            //ImposterFormula(1, 8) ➞ "13%"
            //Notes
            //The player limit is 10 and the imposter count can only go up to 3.

            static string ImposterFormula(int i, int p)
            {
                return Math.Round(((double)i / p) * 100).ToString() + "%";
            }



            //Find an Anagram of a String in Another String 117

            //Create a function that takes two strings and determines if an anagram of the first string is in the second string.Anagrams of "bag" are "bag", "bga", "abg", "agb", "gab", "gba".Since none of those anagrams are in "grab", the answer is false.A "g", "a", and "b" are in the string "grab", but they're split up by the "r".

            //Examples
            //AnagramStrStr("car", "race") ➞ true

            //AnagramStrStr("nod", "done") ➞ true

            //AnagramStrStr("bag", "grab") ➞ false
            //Notes
            //Inputs will be valid strings in all lowercase letters.
            //There exists a linear time algorithm for this.

            static bool AnagramStrStr(string needle, string haystack)
            {
                int c;
                for (int h = 0; h < haystack.Length - needle.Length; h++)
                {
                    c = 0;
                    for (int n = 0; n < needle.Length; n++)
                    {
                        if (!needle.Contains(haystack[h + n]))
                            break;

                        c++;
                    }

                    if (c == needle.Length)
                        return true;

                }

                return false;

            }



            //Contact List 117

            //Write a sorting function that takes in an array of names and sorts them by last name either alphabetically(ASC) or reverse-alphabetically(DESC).

            //Examples
            //SortContacts(new string[] {
            //  "John Locke",
            //  "Thomas Aquinas",
            //  "David Hume",
            //  "Rene Descartes"
            //}, "ASC") ➞ {
            //                "Thomas Aquinas",
            //  "Rene Descartes",
            //  "David Hume",
            //  "John Locke"
            //}

            //// Aquinas (A) < Descartes (D) < Hume (H) < Locke (L)

            //  SortContacts(new string[] {
            //  "Paul Erdos",
            //  "Leonhard Euler",
            //  "Carl Gauss"
            //}, "DESC") ➞ {
            //                "Carl Gauss",
            //  "Leonhard Euler",
            //  "Paul Erdos"
            //}

            //// Gauss (G) > Erdos (ER) > Euler (EU)

            //SortContacts([], "DESC") ➞ { }

            //SortContacts(null, "DESC") ➞ { }
            //Notes
            //An array with a single name should be trivially returned.
            //An empty array, or an input of null should return an empty array.

            static string[] SortContacts(string[] names, string sort)
            {
                if (names == null)
                {
                    return new string[0];
                }

                if (sort == "ASC")
                {
                    return names.OrderBy(c => c.Split().Last()).ToArray();
                }

                else if (sort == "DESC")
                {
                    return names.OrderByDescending(c => c.Split().Last()).ToArray();
                }

                return names;

            }



            //Complete the Word 118

            //An input string can be completed if additional letters can be added and no letters need to be taken away to match the word. Furthermore, the order of the letters in the input string must be the same as the order of letters in the final word.

            //Create a function that, given an input string, determines if the word can be completed.

            //Examples
            //CanComplete("butl", "beautiful") ➞ true
            //// We can add "ea" between "b" and "u", and "ifu" between "t" and "l".

            //CanComplete("butlz", "beautiful") ➞ false
            //// "z" does not exist in the word beautiful.

            //CanComplete("tulb", "beautiful") ➞ false
            //// Although "t", "u", "l" and "b" all exist in "beautiful", they are incorrectly ordered.

            //CanComplete("bbutl", "beautiful") ➞ false
            //// Too many "b"s, beautiful has only 1.
            //Notes
            //Both string input and word will be lowercased.

            static bool CanComplete(string initial, string word)
            {
                bool canComplete = true;

                int counter = 0;

                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i].Equals(initial[counter])) counter++;
                }

                if (counter != initial.Length) canComplete = false;

                return canComplete;
            }



            //Find Number of Repetitions of Substring 119

            //Create a function that takes a string as an argument and returns the number of repitions of a substring. This the opposite of creating a string by repeating a smaller string n times.For example "abc" repeated4 times would be "abcabcabcabc"

            //In this challenge, we do the opposite. Given the final string, and ask the number of times the substring is repeated.

            //Examples
            //NumberOfRepeats("abcabcabcabc") ➞ 4

            //NumberOfRepeats("bcbcbc") ➞ 3

            //NumberOfRepeats("llbllbllbllbllbllb") ➞ 6

            //NumberOfRepeats("kc") ➞ 1
            //Notes
            //Assume that the substring length is always greater than 1.
            //Assume that the string length is always greater than 1.
            //Assume that the substring is not always the same.

            static int NumberOfRepeats(string str)
            {
                string substring = FindSubstring(str);
                return str.Length / substring.Length;
            }

            static string FindSubstring(string str)
            {
                for (int i = 2; i <= str.Length / 2; i++)
                {
                    if (str.Length % i != 0)
                    {
                        continue;
                    }

                    string first = str.Substring(0, i);
                    string second = str.Substring(i, i);
                    string last = str.Substring(str.Length - i);

                    if (first == second && second == last)
                    {
                        return first;
                    }
                }

                return str;
            }



            //Simplified Fractions 120

            //Create a function that returns the simplified version of a fraction.

            //Examples
            //Simplify("4/6") ➞ "2/3"

            //Simplify("10/11") ➞ "10/11"

            //Simplify("100/400") ➞ "1/4"

            //Simplify("8/4") ➞ "2"
            //Notes
            //A fraction is simplified if there are no common factors(except 1) between the numerator and the denominator. For example, 4 / 6 is not simplified, since 4 and 6 both share 2 as a factor.
            //If improper fractions can be transformed into integers, do so in your code(see example #4).

            static string Simplify(string str)
            {
                string[] splited = str.Split('/');
                string result = "";
                int first = int.Parse(splited[0]);
                int second = int.Parse(splited[1]);
                int divideby = first <= second ? first : second;

                if (first % second == 0)
                {
                    result = (first / second).ToString();
                }
                else
                {
                    for (int i = 2; i <= divideby; i++)
                    {
                        if (first % i == 0 && second % i == 0)
                        {
                            first = first / i;
                            second = second / i;
                        }
                    }
                    result = (first + "/" + second).ToString();
                }

                return result;

            }



            //Amazing Edabit! 121

            //Create a function that takes a string and changes the word amazing to not amazing.Return the string without any change if the word edabit is part of the string.

            //Examples
            //AmazingEdabit("edabit is amazing.") ➞ "edabit is amazing."

            //AmazingEdabit("Mubashir is amazing.") ➞ "Mubashir is not amazing."

            //AmazingEdabit("Infinity is amazing.") ➞ "Infinity is not amazing."
            //Notes
            //Edabit is amazing :)

            static string AmazingEdabit(string str)
            {
                if (!str.Contains("edabit"))
                {
                    return str.Replace("amazing", "not amazing");
                }

                return str;

            }



            //Amount of Unique Fractions 122

            //Create a function double UniqueFract(), which should sum all irreducible regular fractions between 0 and 1, in the numerator and denominator of which there are only single-digit numbers: 1 / 2, 1 / 3, 1 / 4, ... 2 / 3, 2 / 4, ... 8 / 9.

            //Task
            //UniqueFract() ➞ sum
            //Notes
            //Of the fractions 1 / 2 2 / 4 3 / 6 4 / 8, only 1 / 2 is included in the sum.
            //Don't include any values >= 1.
            //Both the numerator and denominator are single digit.

            static double UniqueFract()
            {
                var parts = new List<double>();

                for (var i = 2; i <= 9; i++)
                {
                    for (var j = 1; j < i; j++)
                    {
                        if (!parts.Contains((double)j / i))
                            parts.Add((double)j / i);
                    }
                }

                return parts.Sum();

            }



            //Password Validation 123

            //Create a function that validates a password to conform to the following rules:

            //            Length between 6 and 24 characters.
            //At least one uppercase letter(A - Z).
            //At least one lowercase letter(a - z).
            //At least one digit(0 - 9).
            //Maximum of 2 repeated characters.
            //"aa" is OK
            //"aaa" is NOT OK
            //Supported special characters:
            //            ! @ # $ % ^ & * ( ) + = _ - { } [ ] : ; " ' ? < > , .
            //Examples
            //ValidatePassword("P1zz@") ➞ false
            //// Too short.

            //ValidatePassword("iLoveYou") ➞ false
            //// Missing a number.

            //ValidatePassword("Fhg93@") ➞ true
            //// OK!
            //Notes
            //N / A

            static bool ValidatePassword(string password)
            {
                var paswordRegex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{6,24}$");

                if (!paswordRegex.IsMatch(password))
                {
                    return false;
                }

                if (password.IndexOf("è") > 0)
                {
                    return false;
                }

                int repeatingNumber = 0;
                for (int i = 0; i < password.Length - 1; i++)
                {
                    if (password[i] == password[i + 1])
                    {
                        repeatingNumber++;
                    }
                    else
                    {
                        repeatingNumber = 0;
                    }

                    if (repeatingNumber > 1)
                    {
                        return false;
                    }
                }

                return true;
            }



            //Meme Sum :) 124

            //For this challenge, forget how to add two numbers together.The best explanation on what to do for this function is this meme:

            //            Examples
            //MemeSum(26, 39) ➞ 515
            //// 2+3 = 5, 6+9 = 15
            //// 26 + 39 = 515

            //MemeSum(122, 81) ➞ 1103
            //// 1+0 = 1, 2+8 = 10, 2+1 = 3
            //// 122 + 81 = 1103

            //MemeSum(1222, 30277) ➞ 31499
            //Notes
            //N / A

            static int MemeSum(int a, int b)
            {
                if (b >= a)
                {
                    int Tal = a;
                    a = b;
                    b = Tal;
                }

                string stra = a.ToString();
                string strb = b.ToString();

                for (int i = strb.Length; i < stra.Length; i++)
                {
                    strb = "0" + strb;
                }

                string result = "";

                for (int i = 0; i <= a.ToString().Length - 1; i++)
                {
                    result += (int.Parse(stra[i].ToString()) + int.Parse(strb[i].ToString())).ToString();
                }

                return int.Parse(result);
            }



            //String Incrementer 125

            //Write a function which increments a string to create a new string.

            //If the string ends with a number, the number should be incremented by 1.
            //If the string doesn't end with a number, 1 should be added to the new string.
            //If the number has leading zeros, the amount of digits should be considered.
            //Examples
            //IncrementString("foo") ➞ "foo1"

            //IncrementString("foobar0009") ➞ "foobar0010"

            //IncrementString("foo099") ➞ "foo100"

            //IncrementString("foo9") ➞ "foo10"
            //Notes
            //N / A

            static string IncrementString(string txt)
            {
                
            }

        }
    }
}

