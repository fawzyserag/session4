namespace Session03
{

    internal class Program
    {
        /// <summary>
        /// this function return the sum of two int numbers
        /// </summary>
        /// <param name="num1">this is the first number</param>
        /// <param name="num2">this is the second number</param>
        /// <returns>the result will be the sum of num1 + num2</returns>
        //static int sum(int num1,int num2)
        //{
        //    return (num1 + num2) ;
        //}
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        //static void Print(int x)
        //{
        //    Console.WriteLine(x);
        //}
        static void Main(string[] args)
        {
            #region Comments and regions
            // this is my first comment [single line comment]
            //int x = 5 ; 
            //int y = 10;

            /*
             this is my first multible line comment
             int x = 5 ;
             int y = 10 ;
            */
            #endregion

            #region Question1
            //int x = 10;
            //int y = 20;
            //Console.WriteLine(x + y);
            //Console.WriteLine("Hello");
            #endregion

            #region comments

            #endregion

            //int x = 5; // 4 bytes this is unused variable

            #region variables declaration and naming conviention
            // PascalCase [c# code [project name , solution name]]
            // FawzySerag

            // camelCase [js] [variables]
            // fawzySerag

            // kabab-case [Angular]
            // fawzy-serag

            // Snake_Case
            // Fawzy_Serag

            //int studentAge = 20; // 4 bytes in stack [value = 20]
            //Console.WriteLine(studentAge);
            // Datatype    Name[camelCase]      value

            //int 9number = 10; //invalid

            //int _number = 10; //valid

            //int @class = 20;
            //int @struct = 200;
            //Console.WriteLine(@class);


            //int number = 20, number02 = 200;
            //int x, y;
            //Console.WriteLine(number);

            //string myName = "Fawzy"; // syntax sugar

            //String myName02 = new String("fawzy");

            //Int32 x = 29;
            //Int16 s = 10;
            //int x = 32 ; alias C# keyword
            //String name = "fawzy";
            //string Name = "fawzy";
            #endregion

            #region value types
            //string name = "mariam"; // alias [C# keyword]
            //String myName = "mariam"; // [BCL]

            //Single number = 10;
            //float myNumber = 10;

            //int x;
            // alocate 4 bytes in stack [uninitialized]
            //x = 5;
            // Assign value into variable 
            //Console.WriteLine(x);
            //int y = 10;
            //Console.WriteLine(y);
            //Console.WriteLine();
            //y = x; // y = x = 5
            //Console.WriteLine(x);
            //Console.WriteLine(y);

            //y++; // y = y + 1
            //Console.WriteLine();
            //Console.WriteLine(x);
            //Console.WriteLine(y);

            //int x = 10; 
            //string name = " Hello";
            //Console.Write(x);
            //Console.WriteLine(name);
            #endregion

            #region refernce types
            //Point p1;
            //Allocate 4 bytes in stack 
            //Allocate 0 bytes in heap
            //p1 = new Point();
            // Allocate required bytes in heap [8 bytes] 
            // intialize each field with the defualt value based on datatype
            // call user-defined constructor if exist
            // Assign reference to the object in the heap
            //Console.WriteLine(p1.x);
            //Console.WriteLine(p1.y);
            //Console.WriteLine();
            //Point p2 = new Point() { x = 5 , y =10 };
            //Console.WriteLine(p2.x);
            //Console.WriteLine(p2.y);
            //Console.WriteLine();

            //p1 = p2;
            //Console.WriteLine(p1.x);
            //Console.WriteLine(p1.y);
            //Console.WriteLine(p2.x);
            //Console.WriteLine(p2.y);

            //p1.x = 100;
            //Console.WriteLine(p1.x);
            //Console.WriteLine(p2.x);
            #endregion

            Console.WriteLine("push");
        }
    }

}
