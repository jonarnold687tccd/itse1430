/*
 * *ITSE 1430
 * spring 2021  
 * sample Implementation
 * */

using System;

namespace MovieLibrary
{
    class Program
    {
        static void Main()  // sring[] args)
        {
            AddMovie();
            DisplayMainMenu();
        }
        // [modifiers* T identifer ( [paremeters] )  { S* }
        // function declarations - function signature that tells sompiler a function exists
        // function signature     T identifer (paremeter)
        // function definition - function declaration + implementation
        private static void DisplayMainMenu ()
        {
            //console .write(); does not  go new line
            //same as cout
            Console.WriteLine("Movie Library");   // string literal in dbl quotes
            Console.WriteLine("----------");

            Console.WriteLine("A) dd Movie");
            Console.WriteLine("Q) uit");

            //console input
            //string input = Console.ReadLine();
            
              
             /// variable declaration   , local scope

            //assignment statement  ::= T id = E ;
            // id - must be an lvalue (left value
            // E any rvalue (right value)  provided it is type compatible
            //operator precedence - order in which operators are evaluated 
            // operator associativity - which  operand evaluates first  ( left ,right) - assignment is right associative
             string input = Console.ReadLine();
             //TODO: validate input
             //TODO: return selected option 
        }

        static void AddMovie ()
        {
            //title,release year , run length min  desc rating

            Console.Write("Enter a title: ");
            string title = Console.ReadLine();

            Console.Write("enter a  option description:");
            string description = Console.ReadLine();

            Console.Write("Enter a release year: ");
            int releaseYear = Readint32();

            Console.Write("enter a time in minutes: ");
            int runLength = Readint32();

            Console.Write("enter a rating: ");
            string rating = Console.ReadLine();

            Console.Write("is this a classic (Y/N)? ");
            bool isClassic = ReadBoolean();
        }
        static bool ReadBoolean ()
        {
            ConsoleKeyInfo key = Console.ReadKey();

            //TODO: handle key value

            return true;

        }
        
        
        
        // read value 
        static int Readint32 ()
            

        {

            //TODO: handle min value 

            //TODO: keep prompting till valid

            string input = Console.ReadLine();

            //convert string to int 
            int value =Int32.Parse(input);  //atoi
            
            return value;
        }
        void DemoTypes()
        {
            //primative types - types known by compiler 

            //intergrals - signed
            //sbyte | i byte | -128 to 127
            // short | 2bytes | +- 32k
            // int | 4 bytes | +- 2 billion | default
            // long  | 8 bytes | really large  | only for over 2 billion 

            // unsigned interals 

            //byte | 1 byte | 0 to 255
            // ushort | 2bytes | 0 to 64k
            // uint | 4 bytes | 0 to 4 bill
            // ulong  | 8 bytes | really large 
            sbyte sbyteValue = 10;
            short shortValue = 10;
            int hours = 20;
            long starsinGalaxy = 1_000_000_000;  // can use underscores as commas
            long anotherLong = 10L;
            ulong ulongCode = 10UL; //ulong literal 

            byte byteCode = 0xAF;
            ushort shortCode = 0x1045;  /// hex 
            uint hourCode = 0x145678;
            ulong longCode = 0b0010_1010_1111;  // binary 


            //floating points IEEE
            // float | 4 bytes | +- E38 | 7-9 precision  123.456789
            // double  | 8bytes |+- E308 | 15-17 precision  | default 
            // decimal | 80 bytes | currency (money)

            float delta = 4.5F;  // float literal 
            double taxRate = 8.75;
            decimal  payRate = 12.50M;    // decimal always put M after 



            //texual
            // char  |2bytes | single character 
            //string |* | text
            char letter = 'A';  //char single quote 
            string className = "ITSE 1430";   //string double quote


            //miscellaneous
            //bool |1bit  | true or false 
            bool isPassing = true; //false

            // don not use 0 and 1   use true or false 

            //other (not primitives) 
            //DateTime | date time value
            //TimeSpan | time of day or duration
            // Guid | unique value 
            DateTime today;
            TimeSpan duration;
            Guid uniqueId;
        }



        void DemoVariables ()



        // variable-declaration ::= T id;
        // block style declarations put all declarations at top of function   grouped together 
        // inline style declaration    declares variables as needed 
        {
            string textInput = " ";


            // textInput = "Hello";

            // all reads of vriables must be definately assigned
            // compiler must be able to verify all possible code paths to the read ensure that 
            // variable is written to 
            string textinput2 = textInput;

            int x = 10, y = 12;
          // data to collect 
          // title, genre, release year,genre,actors,tuntime,director ,rating
        }  // title, genre, release year,genre,actors,tuntime,director ,rating
    }
}
// identifier rules 
// start with letter or underscore
// consists of didgets or underscores
//must be unique in scope
// cannot be keyword

// variable guidelines 
//nouns descriptive 
// usually less than 15 charachters long 
// never single letters 

// use camel casing      eg   firstName, payRate, hours


//function name guidlines 
// descriptive verbs 
//use pascal casing 
// no abbrviations unless well known 

// data to collect
// title, genre, release year,genre,actors,tuntime,director ,rating
// title, genre, release year,genre,actors,tuntime,director ,rating
// not abbreviations or acronyms  well known


