/*
 * *ITSE 1430
 * spring 2021  
 * sample Implementation
 * */

using System;//  bring into scope all of the types defined in the  givin namespace 
 
// renamed to match project name
namespace MovieLibrary
{
    namespace ConsoleHost
    { }
}


namespace MovieLibrary.ConsoleHost
{
    class Program  // MovieLibrary.ConsoleHost.Program
    {
        static void Main ()  // sring[] args)

        {
            
            // fully qualified type name  System.Boolean   [namespace] [type]
            //MovieLibrary.ConsoleHost.Boolean ( not foind   moves to 
            //movieLibrary.Boolean (also not found)
            //system.boolean (found)
           bool done = false;  //boolean  wierd error here  when use boolean instead of bool
            do
            {
                char option = DisplayMainMenu();

                // switch statement is equiva;emt tp a seriesd of if else  if with equality check
                // switch-statement -->    switch (E) { case statement* [default-statement ] };
                // case state metn  -->  case E ; S ;
                // default statement  --> defaule : S ;

                // case label  (' ') rules
                // must be constant values    literals or simeple expressions 
                // must be uniwue 
                // can be string

                // falthrough   behaveior  no 
                //
                // every case statement must end with return or break 
                // allowed if case labe has no statement  including semiolon
                // styling rules 

                //single statement excluding break no block statement needed
                // multimple statements excluding reak should use block statement to  avoid errors
              //  switch (10)
              //  {
                 //   case 10: S1; S2; S3; break;
                 //   case 12:
                 //   {
                 //       int x; x=10;
                 //       break;
                 //   };
                 //   case 13: SByte; break;
               // }












           //   if (option =='A')
            //      AddMovie();

          //    else if (option == 'V')
           //       ViewMovie();
           //   else if (option == 'Q')
            //      done = true;

           //   else
            //      DisplayError("Unknown command"); 

                //switch replacves if 
            switch(option)
                {
                    case 'A': AddMovie(); break;
                    case 'V': ViewMovie(); break;
                    case 'Q': done = true; break;

                    default: DisplayError("Unknown command"); break;
                };



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
            //Console.WriteLine("----------");
            Console.WriteLine("".PadLeft(20, ' '));
            

            Console.WriteLine("A) dd Movie");
            Console.WriteLine("V) iew Movie");
            Console.WriteLine("Q) uit");
           
            
            do
            {
                string input = Console.ReadLine();

             // if (input == "A" || input == "a")
                //  return 'A';
             // else if (input == "Q" || input == "q")
              //    return 'Q';
             // else if (input == "V" || input == "v")
              //    return 'V';
              switch (input)
              { // fallthrough allowed only here
                    case "A": 
                    case "a": return 'A';

                    case "Q": 
                    case "q": return 'Q';

                    case "V": 
                    case "v": return 'V';


                }


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
            // object creation 
            // 1. allocates mem to store class fields
            // 2. all fields are initialied to default or field initializer
            // 3. calls constructor 
            // only 1 constructor will ever be called 
            
            // new type();
            // Movie* movie = new Movie
            Movie movie;
            movie = new Movie("Default Title");
            movie = new Movie();


            

            // member access function 
            // member - access  =  E . Member
            

            //title,release year , run length min  desc rating

            Console.Write("Enter a title: ");
             movie.Title = Console.ReadLine();

            Console.Write("enter a  option description:");
             movie.Description = Console.ReadLine();

            Console.Write("Enter a release year: ");
             movie.ReleaseYear = Readint32(Movie.MinimumReleaseYear);

            Console.Write("enter a time in minutes: ");
             movie.RunLength = Readint32(-1);

            Console.Write("enter a rating: ");
             movie.Rating = Console.ReadLine();

            Console.Write("is this a classic (Y/N)? ");
             movie.IsClassic = ReadBoolean();
            // validate movie
            if (!movie.Validate(out var message ))
            {
                DisplayError($"invalid movie: {message}");
                return;
            };
            // hiding the field movie 
            // this.movie = movie;
            _movie = movie;

            var movie2 = new Movie();
            movie2.Title = "Jaws 2";
            movie2.ReleaseYear = 1930;
            movie2.IsBlackAndWhite();
            movie.IsBlackAndWhite();
            //   movie.DoComplex(1970, true);

            //readable not writable doesnt have a setter 
            var age = movie.AgeInYears; 

            // movie.AgeInYears = 10;   cant do this  no setter allowed
            ViewMovie();
        }
      

         // only allowed to use _ in field names 
        static void ViewMovie ()
        {

            //TODO: format
            Console.WriteLine($"{_movie.Title} ({_movie.ReleaseYear})");
            if (_movie.RunLength > 0)
                Console.WriteLine($"Running Time: {_movie.RunLength} minutes");
            if (!String.IsNullOrEmpty(_movie.Rating))
                Console.WriteLine($"MPAA Rating: {_movie.Rating}");
            Console.WriteLine($"Classic? {(_movie.IsClassic ? 'Y' : 'N')}");

            if(!String.IsNullOrEmpty(_movie.Description))
            Console.WriteLine(_movie.Description);            
            
           

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

                // should use switch but will play around with comparison.
                // if (input.ToUpper() == "Y")
                //   return true;
                else if (input == "N" || input == "n")
                    // return false;
                    
                    // compare 3 
                    if (string.Compare(input, "Y", true) == 0)
                        return true;




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
            {// type inferencing (var)compiler  infers type based upon asignment
             // keep prompting till valid value
             //? value = 43.5 + 56; 
              //string input = Console.ReadLine();
              // keyword var can only be used for local variables.  does not change  code
             var input = Console.ReadLine();
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

                
                if (Int32.TryParse(input, out var result))
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
        static Movie _movie;

        #region Demo Code
        void DemoString ()
        {
            //  conversion to string
            // console.Writeline(10);   -->  console.Writeline(10.ToString())
            int hours = 10;
            string hourString = hours.ToString();  // "10"
            hourString = 10.ToString();    //"10"          these 2 lines do the same thing 
            // sting literal ""
            // escape sequence -/? inside literal has special meaning to compiler 
            // \n  newline 
            // \t horizontal tab
            // \\ slash  (e,g  "C;\\temp\\test.txt
            // double quote   (  "hello \"bob\"")
            // /' single quote in character 
            // \x## hex equivilent

            string stringLiteral = "hello" + "world";
            stringLiteral = "Hello\nWorld";
            // verbatim sytax = escape sequence ignored 
            string filepath = "C;\\Temp\\test.txt";
            string filepath2 = @"C:\Temp\test.txt";

            // empty string

            // null and empty string are no the string 

            string emptyString = "";
            string defaultString = null;
            bool areEqual = emptyString == defaultString;   // false 

            string emptystring2 = String.Empty;

            // checking for empty

            bool isEmpty = emptyString == "";
            bool isEmpty2 = emptyString == String.Empty || emptyString == null; // if empty or null 

            bool isEmptyPreferred = String.IsNullOrEmpty(emptyString); // handles both  preferred method 

            // string concatenation 
            string first = "Hello", second = "World";


            // start with 3 strings, (first + " "),(first +" " + second)
            string concatOp = first + " " + second;
            // line above and below do same thing 
            string concaFunction = String.Concat(first, " ", second);
            // also concatenates
            string joinFunction = String.Join(' ', first, second);

            // strings are immutable means values cannot change 
            // 10 + 2 = 12    
            string immutableString = "Hello";
            immutableString += " ";  // two stings  "hello", "hello"
            immutableString += "world"; // three strings   hello , hello , world 
                                        // string formatting 

            // the result of 4 + 5  is 9
            int x = 4, y = 5;

            //1) sting concatenation - ugly and alot to type 
            string format = "The result of " + x + " + " + y + " = " + (x + y);

            //2 string format   // better
            // runtime overload 
            // if missing arguements will crash 

            // format specifiers  follow the ordinal 
            string format2 = String.Format("The result of {0;00} +{1N2} = {2}", x, y, (x + y));

            // many message like functions have overloads tha hav e as string and argguements and call string.format automatically 
            Console.WriteLine(format2);
            Console.WriteLine("The result of {0} + {1} = {2}", x, y, (x + y));

            //3)  string interpolation  let compiler do it for you   // BEST WAY
            // only works with literals 
            // still has runtime overhead

            string format3 = $"The result of {x} + {y} = {x + y}";
            // string format 3  = $ the result of {x:00} + {y;N2} = {x + y));

            string formattedValue = x.ToString("00");

            decimal price = 8500;
            string priceString = price.ToString("C"); // 8500.00



            //common string functions
            //String.<function>
            // <string>.<function>

            int len = priceString.Length;   // gets lenth of string 

            //casing
            var name = "jon";
            string upperName = name.ToUpper();  //upper case string 
            string lowerName = name.ToLower();  // lower case string



            //comparison 
            // "a" == "A" //false
            // int to bool functs 
            // <0   means a < b
            // >0 means a> b
            var areEqualStrings1 = name.CompareTo("bob") == 0;  // 2.sting.compare to (string)   int case sensitive

            // 3 Stiring.Compare (str, str) int
            // String.Compare(str, str, bool )   int 
            var areEqualStrings2 = String.Compare(name, "bob", true) == 0; // case sens



            // padding / trimming 
            // <string>.Trim     string with all whitespace removed from front to back 
            // <string>.Trimstart() / trimend()

            // <string.Padleft(width) / padRight(width)    adds spaces untill givin width
            string trimmedString = name.Trim();

            string trimmedPath = @"C:\Temp\test\folder1".Trim('\\', ' ', '\t');


            string paddedString = name.PadLeft(10);


            //manipulate string 
           string world = "Hello World".Substring(6);
            string wor = "Hello World".Substring(6, 3);
                int index = "Hello World".IndexOf(' ');


            //matching
            bool startswithslash = @"\Temp\test.txt".StartsWith('\\');
            bool endsWithSlash = @"\Temp\test.txt".EndsWith('\\');



        }
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



            //primitive types in .net map to framework types  ( type aliasing)  formal names below 
            //int   -> int 32
            //double -> Double
            //short -> Int16
            //bool   -> Boolean
            //char -> Char

            int int1 = 10;
            Int32 int2 = 20;                   /// these 3 are the same 
            int1 = int2;

           // result = int.Parse("123)");  // Int32.Parse("123");   same thing 
            
        

        }  

            // input parameter - tname 
            // input/output parameter - ref T name 
            // output  - function caller provides space but the functrion provides the value
            void foo ( int inputParmeter, ref double ioParameter, out bool result )
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
            
            
            
        }
        static void DemoTypeChecking ()
        {
            // type checking  - programmer determinign type of expression 
            // type casting = programmer tells compiler type of expression 
            // tyep coercion - cmpiler determines type of expression 

            double payRate = 7.5;
            int pay;
            // type cheking 
            // 1. c style cast  = (type)expression   dont do this 
            // crashes if invalid 
            // always compiler verified

            pay = (int)payRate;   // dont do this 

            // 2. as operator  ->   expression as type 
            // converts an expression to a given type  if valid or null otherwise 
            // only works with classes 
            object m = null;
            Program p;
            //p = (Program)m;
            p = m as Program; // at runtime if m is compatible with program, returns m as a program else returns null
            if (p != null)
            {
                // do somethin with result
            };

             //   3. the is operator  =  expression is tpe   -> bool
             //   type checking not casting 
             //  works with all types 
             if(m is Program)
            {
                p = (Program)m;
            }

             // preferred approave 
             // 4. pattern matching operator -->  expresion is type    identifier on end -> bool ( returns bool value
             //             bool TryParse(out var result)
             if (m is Program prog)
            {
                // prog is program
            }
        }
        #endregion
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
