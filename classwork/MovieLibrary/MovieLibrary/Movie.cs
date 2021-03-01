using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary
{
    //naming rules
    // Noun,  no abbreviations or acronyms
    // always Pascal Cased


    // this keyword is only usuable inside a type
    // represents the current instancs/object
    // it is used to distinguish class members from local identifiers

    // accessibility = compile time acces given to a (type, member, function) code for somethin 
    // public - usuable by anyone 
    // private - only usable by defining type   -  hides implementation details  default for members of a clas
    //internal - ( default for types)    only usable in definfing assembly

    // class declaration : = [modifies] class identifier {members*}
    // class- members ->  field   \ method | properties | ctor
    // field is a variable declaration    all the static things below
    //field = [modifers] T identifier [ = E];
    // method -->  [modifiers] (T | void) identifier ( [parameters] ) {function body}    T = return type
    //modifies = [public  | internal]

    /// <summary>represents a movie.</summary>
    /// <remarks>
    /// where you put additional comment that may be usefull to someone
    /// </remarks> 





    public class Movie   // now usable by anyone  since it now has public in front of it
    {   
        // constructors not needed here just for demo  

        // constructors -  creat a instance of the type 
        // should only do bear minimal to create a instance 
        // method declaration with no return type and name is always the type name
        // 
        public Movie()   // default constructor
        {
            
            // use a constructor only when a field initializers will not work 
            // 1. non primitive field that requires complex  initialization 
            // 2. on field relies on the value of another field
            //  (deprecialted) allow creating and setting the most common properties 
            // 4. allow setting of properties that are anot writable 

            // initialized  fields that cannot be initialized using the field initializer syntax 
            _description = _title;
        }
        // allows you to create th instance and set a common property all at once 
        public Movie (string title)
        {
            _title = title;
        }




        // methods = provide functionality to a class (functions)
        // sample function below 
        // methods are always verbs because they represent a action 
        // methods are always pascal cased 

        // called by instance name  i.e movie then  dot then function name  (movie.IsBlackAndWhite();
        // this is a reference to the instnace the method is being called
        // can be used to get current instance 
        // will always use this automatically  dont need to type this 

        /// <summary> tells if movie is b/w
        /// 
        /// </summary>
        /// <returns>true if movie is b/w </returns>
        public bool IsBlackAndWhite ( /* Movie this */ )
        {
            var isOld = ReleaseYear < 1940;
            // var isOld = this.releaseYear < 1940;
            // telling if movie is earlier than 1940 meaning it would b/w

            // only case where this is put in by programmer 
            //var title = "";
            // title = this.title;

            var note = "";
            note = Title;

            return isOld;
        }

        /// <summary> Do something complex </summary>

        /// </summary>
        /// <param name="age">the age of the movie when restored</param>
        /// <param name="enable"> detemines if movie has been restored</param>
        private void DoComplex ( int age, bool enable )  // more complex method
        { }

        /// <summary> validates  the movie data is correct </summary>
        /// <param name="error">the error mssg if any </param>
        /// <returns>true if movie is valid</returns>





        // problems with fields 

        // can be read or written at will 
        //  calculated and must be update when variant values are changed 
        // can never change type from int 
        // what happens if negative 

        // problems with fields

        // can be read or written at will
        //must be updated when variant value is changed .
        // can never change type from int 
        // what happens  if it is negative 
        //cannot initialize  to another field
        // public int AgeInYears = DateTime.Today.Year - releaseYear;  // original

        //public int GetAgeInYears ()
        //{
        //     if (DateTime.Now.Year < ReleaseYear)   // handles negative problem
        //       return 0;

        //    return DateTime.Today.Year - ReleaseYear;                  // new with method 
        // }
        public int AgeInYears
        {
            get {
                if (DateTime.Now.Year < ReleaseYear)       // handles negative problem
                    return 0;

                return DateTime.Today.Year - ReleaseYear;  // new with method 
            }
            //set { }                  u dont have to have both get and set  just one 
        }
        //public void SetAgeInYears (int year)    // not implemented doesnt make sense here{}
        public bool Validate ( out string error )



        {

            // title is required
            if (String.IsNullOrEmpty(Title))
            {
                error = "title is required";
                return false;
            };
            // release year  >= 1900 
            if (ReleaseYear  < 1900)
            {
                error = "release year must be >= 1900";
                return false;
            };
            // run length >= 0
            if (RunLength < 0)
            {
                error = "run length must be >= 0";
                return false;
            };


            error = "";
            return true;
        }

        // properties -  expose data using methods  is purpose  ( use simple field syntax to call a method )
        // syntax start  oyt as a field but curly braces liek a method .. no parenthesis 
        // use cases:
        //1) expose a backing field
        // 2) calculated property - does not store data just calcs it 

        // golder rule;
        // string and array properties  never return null 
        public string Title
        {       //getter    must always return a value   always returns value type specitfyed in this case sting 
                // func name is always property name  in this case title
                // neverhas parameters
            get {  // return title if not null  or empty string other wise 
                   //return (_title != null) ? _title : "";
                return _title ?? "";
            }

            //setter    returns void always        ( string value)         
            set {
                // _title = (value != null) ? value.Trim() : null;                  // these 2 are equivilent 
                _title = value?.Trim() ?? "";
            }
        }


        //field - variable that store data
        //fields should always start wih a underscore and be camel cased 
        // fiends are initialized early in the process to 0 can be changed 
        // fitelds are initialized in a undefined order
        // fields cannot be initialiex to another fields value
        // fields should always be preceded by a underscore
        // never expose a field publicly


        // null handling 
        // null colescing operator  =  expression  ?? expression 
        // finds first  non null value
        // equiv to   (expression 1 != null) ? e1 : e2
        // left associative, can be combined   example ( E1 ?? E2 ?? E3)
        // cam still return null
        // null conditional operator =  expression ?. member
        // evaluates expression an if insrtanc is not null, invokes member  or skips if it is 
        // ecprssion is changed to nullabler e   works with all types 
        // exmple    int hours();; instance?.Hours()  -> type of expression is int  or null 



        /// <summary>gets or sets the title.</summary>
        private string _title = "";

        public string Description
        {
           // get { return (_description != null) ? _description : ""; }
            get { return _description ?? ""; }
            set { _description = value; }
        }
        private string _description = "";

        //public int ReleaseYear
        //{
        //    get { return _releaseYear; }
        //    set { _releaseYear = value; }
        //}
        // private int _releaseYear = 1900;
      


        public int ReleaseYear { get; set; } = MinimumReleaseYear;       //1900




        //public int RunLength   // full property syntax
         //{
        // get { return _runLength;}
        // set { _runLength = value;}
        // }
        // private int _runLength;

        public int RunLength { get; set; }
                // auto  property syntax compiler will auto gen full property
                // if you ont need to o anything with get set you cna use auto  otherwise use full
                // doesnt work on strings
        public string Rating
        {
            //get { return (_rating  != null) ? _rating : ""; }
            get { return _rating ?? ""; }
            set { _rating = value; }
        }
           private string _rating = "";
           public bool IsClassic { get; set; }
       // {
        //    get { return _isClassic; }
        //    set { _isClassic = value; }
        //}
    // private bool _isClassic;

        // auto propertis  can be getter or setter only if needed 
        public int Age { get; }  // could say = a number 
        //private readonly int_age;

        // demo of mixed accessability
        // can only be appied to either get ort set not both 
        //  access modifier must be more restrictive than property 
        public int RestrictedProperty
        {
            get;
            private set;
        }

        internal int InternalPropert { get; private set; }
        // allowed to expose a field if const
        // const   glorified named literal baked into usage at compile time 
        //readonly - const named variable value referenced at runtime
        public const int MinimumReleaseYear = 1900;
        public readonly DateTime MinimumReleaseDate = new DateTime(1900, 1, 1);
       //public int Age {set; } 
       /// dont use const on a variable can potentially change use read only 


    // private string _note;
    }  // _ will ensure it doents conflict with local variables or parameters
}
//data to collect  - title, genre, release year, actors, runtime , director, rating
// title, release year, run length in minutes, description, rating 
