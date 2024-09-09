
using MyApplication;
using MyTest;
using System;
using System.ComponentModel.Design;
namespace HelloWorld
{
    class Test: Car // derived class child 
    {
        static void Main(string[] Args)


        {



            Program Test=new Program();

            //Console.WriteLine(Test);

            /*// this is test writen 
             Console.WriteLine("hi Martha"); // this is test write
             string name = "MArtha";
             Console.WriteLine(name);
             int Mynum = 7;
             Console.WriteLine(Mynum);
             int Mynum2 = 15;
             Mynum2 = 1;
             Console.WriteLine(Mynum2);
             const int Mynum3 = 2;
             // Mynum3 = 20; // error
             Console.WriteLine(Mynum3);
             string Firstname = "Srikanth";
             string lastname = "martha";
             string Fullname = Firstname + lastname;
             Console.WriteLine(Fullname);
             int x = 5;
             int y = 3;
             Console.WriteLine(x + y);
             int f = 5, g = 4, z = 6;
             Console.WriteLine(x + z + y + f + g);
             int myNum4 = 10000;
             Console.WriteLine(myNum4);
             long muNum5 = 150000000000000000L;
             Console.WriteLine(muNum5);
             float myNum6 = 6.99f;
             Console.WriteLine(myNum6);
             float f1 = 35e3F;
             Console.WriteLine(f1);
             double d1 = 12E4D;
             Console.WriteLine(d1);
             bool isCsharp = true;
             Console.WriteLine(isCsharp);
             bool isfishtast = false;
             Console.WriteLine(isfishtast);
             // char data type is used for single character text the charcter  must be in single quotes like 'A' or 'c':
             char mygrade= 'A';
             Console.WriteLine(mygrade);

             int myint = 15;
             double mydouble=myint; // this is called implicit casting for small to big converter
             Console.WriteLine(mydouble);


             double mydouble2 = 9.5;
             int myint2=(int)mydouble2;
             Console.WriteLine(myint2);
             Console.WriteLine(mydouble2);

             // type convwersion methods 

             int sri = 15;
             double sri2 = 5.25;
             bool mybool=false;
            Console.WriteLine(Convert.ToString(sri)); // here we converted int to string
             Console.WriteLine(Convert.ToDouble(sri));// here we converted int to double
             Console.WriteLine(Convert.ToInt32(sri2));// here we are conveted double to int32
             Console.WriteLine(Convert.ToString(mybool));// here we converted bool to string

             //now we are learning user input types alredy we are console.writeline(); for display the value now we are going leanring how take input from users
             Console.WriteLine("user firstName");
             string userFirstname = Console.ReadLine();
             Console.WriteLine("user name is: " + userFirstname);

             Console.WriteLine("userlastname");
             string userlastname= Console.ReadLine();
             Console.WriteLine("user last name is"+userlastname);

             string userfullname = userFirstname + userlastname;
             Console.WriteLine("user full Name is:" + userfullname);


             // now i am trying to do same how fro int data type lets result
             /*Console.WriteLine("Enter your Age");
             int Myage=Console.ReadLine():
                 Console.WriteLine("my age is:" + Myage); */
            // we are geting error her because Console.ReadLine() methd is a string > therfore ,you canot  get information from another data types like int the follow [rogram cause an error


            //we  learned before in casting convert 
            /* Console.WriteLine("Enter your Age");
             int Myage = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("my age is:" + Myage);


             // we have concepts called operators
             // those 4 types
             /* 
              1) aritmetic Operator
              2) assignment operator
              3) comparison operator
              4) Logical Operator
             */
            // lets see arithmetic opertor



            /* int sum = 50 + 100;
             int sum2 = sum + 500;
             int sum3 = sum2 + 100;

             Console.WriteLine(sum3);



             int a1 = 5;
             int a2 = 5;
             Console.WriteLine( a1 + a2);
             */

            //  int p = 10;
            //Console.WriteLine(!(p>3 && p<10));
            //  Console.WriteLine(Math.Max(5, 20));

            // what is the diffrence between + usage in Cshrap is adding number we use + and coneting the strings ex: 1+1=2 ,string 10+20 =1020 if its firstname+lastname =fullname



            /* int x = 15;
             Console.WriteLine(x == 10);

             int y = 10;

             if (x == 15)
             {

                 Console.WriteLine(" yes its true");

             }else
             {
                 Console.WriteLine("not true");
             } */
            // int myage = 102;
            /*int votingage = 18;
            int voteyear = votingage - myage;
           
            if (myage >= 18 && myage <=100)
            {
                Console.WriteLine("old enough to vote");

            }
            else if (myage>=100)
            {
                Console.WriteLine("you vote is exprired");
            }
            else
            {
                Console.WriteLine("not old enough to vote");
                Console.WriteLine(" you will get vote after "+voteyear + "years");
                
            }*/

            /*  string result = (myage >= 18) ? "old enough to vote" : "not old enough to vote";
              Console.WriteLine(result);




              int[,] numbers = { { 1, 4, 2 }, { 3, 5, 6 } };
              for (int i = 0; i < numbers.GetLength(0); i++)
              {
                  for (int j = 0; j < numbers.GetLength(1); j++)
                  {
                      Console.WriteLine(numbers[i, j]);
                  }
              }

              {
                 */


            string[] cars = { " volvo'", " bmw,", " Ford" };
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }



            Mymethod();

            int myint = Mymethod1(5, 3);

            Console.WriteLine(myint);



            // here i am calling the class name called  car

            Car myObj = new Car();
            myObj.fullThrottle();  // Call the method
           Car myObj2 = new Car();
            myObj2.color = "red";
            Console.WriteLine(myObj2.color);



           Car myObj3 = new Car();
            myObj3.Model = "tesla";
            Console.WriteLine(myObj3.Model);


            // created an object of the mycar class here i am calling the constructor of mycar class
            testcar mycar= new testcar();
            mycar.Model = "cadalaic";
            Console.WriteLine(mycar.Model);



            testcar properties= new testcar();
            properties.Name = "srikanth";
            Console.WriteLine(properties.Name);


            // interface 
            testcar mydetails = new testcar();
            mydetails.Myfullname();
            mydetails.GetMyAddress();



        }
       
       static void Mymethod()
        {
            Console.WriteLine("i am calling the method in other class");
        }




       static int Mymethod1(int x, int y)
        {
            return x + y;
        }
      // removed 2 comments





    }
    }




    
        

    



           
 