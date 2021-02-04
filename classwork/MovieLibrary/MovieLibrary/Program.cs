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
        static void Main ()  // sring[] args)
        {
            bool done = false;
            do
            {
                char option = DisplayMainMenu();

                if (option =='A')
                    AddMovie();

                else if (option == 'V')
                    ViewMovie();
                else if (option == 'Q')
                    done = true;

                else
                    DisplayError("Unknown command"); 



            } while (!done);
        }
        
        
        
        
        // [modifiers* T identifer ( [paremeters] )  { S* }
        // function declarations - function signature that tells sompiler a function exists
        // function signature     T identifer (paremeter)
        // function definition - function declaration + implementation
        private static char DisplayMainMenu ()
        {
            //console .write(); does not  go new line
            //same as cout
            Console.WriteLine("Movie Library");   // string literal in dbl quotes
            Console.WriteLine("----------");

            Console.WriteLine("A) dd Movie");
            Console.WriteLine("V) iew Movie");
            Console.WriteLine("Q) uit");
           
            
            do
            {
                string input = Console.ReadLine();

                if (input == "A" || input == "a")
                    return 'A';
                else if (input == "Q" || input == "q")
                    return 'Q';
                else if (input == "V" || input == "v")
                    return 'V';
                DisplayError("Invalid option");
            } while (true);


            //console input
            //string input = Console.ReadLine();


             /// variable declaration   , local scope

             //assignment statement  ::= T id = E ;
             // id - must be an lvalue (left value
             // E any rvalue (right value)  provided it is type compatible
             //operator precedence - order in which operators are evaluated 
             // operator associativity - which  operand evaluates first  ( left ,right) - assignment is right associative
             
             //TODO: validate input
             //TODO: return selected option 
        }

        static void AddMovie ()

        

        {
            //title,release year , run length min  desc rating

            Console.Write("Enter a title: ");
             title = Console.ReadLine();

            Console.Write("enter a  option description:");
             description = Console.ReadLine();

            Console.Write("Enter a release year: ");
             releaseYear = Readint32(1900);

            Console.Write("enter a time in minutes: ");
             runLength = Readint32(0);

            Console.Write("enter a rating: ");
             rating = Console.ReadLine();

            Console.Write("is this a classic (Y/N)? ");
             isClassic = ReadBoolean();

            ViewMovie();
        }
        static string title;
        static string description;
        static int releaseYear;
        static int runLength;
        static string rating;
        static bool isClassic;
        static void ViewMovie ()
        {

            //TODO: format
            Console.WriteLine(title);
            Console.WriteLine(description);
            Console.WriteLine(releaseYear);
            Console.WriteLine(runLength);
            Console.WriteLine(rating);
            Console.WriteLine(isClassic);

        }
        static bool ReadBoolean ()
        {
            do
            {
                // ConsoleKeyInfo key = Console.ReadKey();
                string input = Console.ReadLine();
                //TODO: case does not matter 
                if (input == "Y" || input == "y")
                    return true;
                else if (input == "N" || input =="n")
                    return false;
                //TODO: handle key value
                DisplayError("Please enter either Y or N");
            } while (true);
            

        }



        // read value 
        static int Readint32 ( )
        {
            return Readint32(Int32.MinValue);
        }
        static int Readint32(int minimumValue )
        {  //todo  prompt to valid
            //todo handle min val


            // while statement 
            // executes 0 or more times(pretest)
            // break statement 
            // only valid in loops
            // exits loop 
            // continue
            //exits current interation but checks the loop again 

            do
            {

                string input = Console.ReadLine();
                // converts string to int
                // todo fix if not int
                // int value = Int32.Parse(input);      prefer tryparse

                //if (t or f) S;
                // if(eb)
                // st 
                // else 
                //    sf;
               //int result;
              //if (Int32.TryParse(input, out result))

                int result;
                if (Int32.TryParse(input, out result)) // inline vaiable declaration
                {
                    // make sure at leas min val
                    if (result >= minimumValue)
                        return result;
                    else
                        DisplayError("Value musrt be at least " + minimumValue);


                }else 

                DisplayError("Value must be numeric");
            } while (true);
        }

        private static void DisplayError ( string message)

        {
            Console.WriteLine(message);
        }


        #region Demo Code

        void DemoExpressions ()

        {
            // arthrithmedic  
            int result = 4 + 5;
            result  = 5 - 45;
            result = 5 - 45;
            result = 8 * 5;
            result  = 8 % 5;

            //logical ( bool op bool --> bool_
            bool logicalResult = true && true; // logical and 
            logicalResult = true || true;   // logical or
            logicalResult = !true;     // logical!

            //relational (always return bool)
            bool relationalResult = 10 > 20;
            relationalResult  = 10 < 20;
            relationalResult  = 10 >= 20;
            relationalResult  = 10 <= 20;
            relationalResult  = 10 != 20;
            relationalResult  = 10 == 20;


            //> greater than 
            //< less than 
            //>= greater than equal too
            //<= less than equam too
            //!= not eqyal 
            // == equal

            // conditional
            // e?  et : ef
            // et
            //else 
            // ef


            //misc  
            // right associative 
            logicalResult  = relationalResult = false;
            // pre and postfix
            result = 5;
            int postfixinc = result++;  // result +1
            int prefixinc = ++result;   // get back current result 
            int postfixdec = result--;
            int prefixdec = --result;

            //function calls 
            // parameter = variable in side definition used to store value 
            // arguement = expression used to assign a value to parameter 
            // kinds of parameters --- foo(x)
            //  input (pass by value) - copies the argument value into thee parameters memory location  2 seperate copies
            // input/output - (pass by ref) - c++ or java not universal - temp share same mem loc for 2 diff variables


            result = Readint32();
            result = Int32.Parse("123");
        }  

            // input parameter - tname 
            // input/output parameter - ref T name 
            // output  - function caller provides space but the functrion provides the value
            void foo ( int inputParemeter, ref double ioParameter, out bool result )
        {
            result = false;
        }
        

            //TODO: handle min value 

            //TODO: keep prompting till valid

            //string input = Console.ReadLine();

            //convert string to int 
            //int value =Int32.Parse(input);  //atoi
            
            //return value;
            // function 
            


        void DemoTypes()
        {
            //primative types - types known by compiler 

            //intergrals - signed
            //sbyte | i byte | -128 to 127 (SByte.TryParse/Parse)
            // short | 2bytes | +- 32k     (Int16.TryParse/Parse)
            // int | 4 bytes | +- 2 billion | default    (int32
            // long  | 8 bytes | really large  | only for over 2 billion   (int64)

            // unsigned interals 

            //byte | 1 byte | 0 to 255       (Byte.TryParse/Parse)
            // ushort | 2bytes | 0 to 64k     (UInt16.
            // uint | 4 bytes | 0 to 4 bill   (UInt32
            // ulong  | 8 bytes | really large (UInt64.
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

            float delta = 4.5F;  // float literal   (Single.TryParse/Parse)
            double taxRate = 8.75;   // 8E-10       (Double.
            decimal  payRate = 12.50M;    // decimal always put M after  (Decimal.



            //texual
            // char  |2bytes | single character 
            //string |* | text
            char letter = 'A';  //char single quote 
            string className = "ITSE 1430";   //string double quote


            //miscellaneous
            //bool |1bit  | true or false 
            bool isPassing = true; //false     (Boolean.TryParse/Parse)

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
            // title, genre, release year,genre,actors,tuntime,director ,rating
            #endregion 
        }
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


// function calls 
// parameter  is variable inside function definition  used to store temp value
  // foo(12);
  // foo(ref arg);
// argurement  is expression used to assign a value to parameter 

// kinds of parameters    ::= foo(x)
// input ( pass by value ) - copies  arguerment intoi the memory location , two seperate  copies
// input/ output (pass by reference)- temporarily share same mem location for 2 diff variables
// output - funtion  caller provides space but the function provides the value
// foo (out arg);

//input parameter - T name

// input/output para,aeter - ref t name
// output parameter - out T name

// void foo (int inputParameter, ref double io parameter, pit bool result)
//{

//}
