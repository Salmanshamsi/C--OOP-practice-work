using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConsoleApplications
{
    class Program
    {

        //class Circle {
        //    public double radius = 1.0d;
        //    public string color = "red";
        //}
        //class Rectangle {
        //   public float length = 1.0f;
        //   public float Width = 1.0f;
        //}
        //class Author {
        //   public string name;
        //   public string email;
        //   public string gender;
        //}

                    //public class Car
                    //{
                    //    public int model;
                    //    public string manufacturer;
                    //    public int fuel;
                    //    public int distance;

                    //    public Car(int model, string manufacturer, int fuel, int distance)
                    //    {
                    //        this.model = model;
                    //        this.manufacturer = manufacturer;
                    //        this.fuel = fuel;
                    //        this.distance = distance;
                    //    }

                    //    public void engineWork()
                    //    {
                    //        distance += 1;
                    //        fuel += 2;
                    //        Console.WriteLine("Model: " + model);
                    //        Console.WriteLine("Manufacturer: " + manufacturer);
                    //        Console.WriteLine("Fuel: " + fuel);
                    //        Console.WriteLine("Distance: " + distance);
                    //    }

                    //    public void setFuel(int value)
                    //    {
                    //        fuel = value;
                    //        Console.WriteLine("Fuel set to: " + fuel);
                    //    }

                    //    public int getModel()
                    //    {
                    //        return model;
                    //    }
                    //}


        class employee {

            private string _Name;
            private int _Age;


            public employee(employee emp) {
            // declear copy constructor

                this._Name = emp._Name;
                this._Age = emp._Age;
            }

            public employee(string name, int age) { 
            // instance constructor

                this._Name = name;
                this._Age = age;

            }

            public string PrintData() {

                return "the age of   " + _Name + " is " + _Age.ToString();

            }
        
        }


        //************************************Q-1*******************************************************

            public class Student
            {
                public string Name;
                public int RollNo ;
                public int AdmissionYear;
                public string Department;

                public Student(string name, int rollNo, int admissionYear, string department)
                {
                    Name = name;
                    RollNo = rollNo;
                    AdmissionYear = admissionYear;
                    Department = department;
                }

                public void PrintData()
                {
                    Console.WriteLine("Admission done sucessfully");
                    Console.WriteLine(" name :"+ this.Name +"  roll number :"+ this.RollNo +"  admission year :"+ this.AdmissionYear +"  department  :"+ this.Department);
                }

            }


            //***************************************Q-2****************************************************


            public class Programming
            {
                public Programming()
                {
                    Console.WriteLine("Love programming languages");
                }

                public Programming(string language)
                {
                    Console.WriteLine("Love " + language);
                }
            }

            //*******************************************************************************************


            //***************************************Q-3****************************************************


            public class Rectangle
            {
                private int length;
                private int breadth;

                public Rectangle()
                {
                    length = 0;
                    breadth = 0;
                }

                public Rectangle(int l, int b)
                {
                    length = l;
                    breadth = b;
                }

                public Rectangle(int lb)
                {
                    length = lb;
                    breadth = lb;
                }

                public int CalculateArea()
                {
                    return length * breadth;
                }
            }



            //******************************Q-4***********************************************************

            public class Area
            {
                private int length;
                private int breadth;

                public Area(int l, int b)
                {
                    length = l;
                    breadth = b;
                }

                public int ReturnArea()
                {
                    return length * breadth;
                }
            }

        
            //**************************************7.2***************************************************

            public class Employee {

                public string is_active;
                
                public bool AuthorizeMe(EmployeeCard obj) {

                    if (obj.AuthorizeManager(this) == true){
                        return true;
                    }
                    else {return false;}
                }

            }
            public class Project
            {
                public string Proj_title;
                public string Proj_desc;
                public double Proj_cost;
                public double Proj_completion;

                public Project(string title,string desc,double cost)
                {
                    this.Proj_title = title;
                    this.Proj_desc = desc;
                    this.Proj_cost = cost;
                }

                public void projSucess(HoD hod) {
                    this.Proj_completion += 1;
                        hod.performance += 1;
                }
                public void projFail(HoD hod)
                {
                    hod.performance -= 1;
                }

            }
                public class HoD : Employee {
                public int ID;
                public string name;
                public int performance = 0;
                Project project;

                List<Teacher> FacultyMembers = new List<Teacher>();

                public HoD(string name, int id, string title, string desc, double cost)
                {
                this.ID = id;
                this.name = name ;
                project = new Project(title,desc,cost);
                }
                public void WorkingOnProj(string value) {
                    if (value == "Good")
                    {
                        project.projSucess(this);
                    }
                    else {
                        project.projFail(this);
                    }
                }
                public void AddMember(Teacher T) {
                    FacultyMembers.Add(T);
                }
                public void HoDDetails() {
                    Console.WriteLine("HOD ID is : " + ID);
                    Console.WriteLine("HOD Dep name is : " + name);
                    Console.WriteLine("Proj_title is : " + project.Proj_title);
                    Console.WriteLine("Proj_disc is : " + project.Proj_desc);
                    Console.WriteLine("Proj_cost is : " + project.Proj_cost);
                    Console.WriteLine("Proj_creator name is : " + this.name);
                    Console.WriteLine("Proj_creator performance is : " + this.performance);
                    Console.WriteLine("Total % of proj comp  : " + project.Proj_completion);
                   
                    Console.WriteLine("faculty who work under him  : ");
                    foreach(Teacher item in FacultyMembers){
                        Console.WriteLine(item.name);
                    }
                }
            }

            public class Driver : Employee { }
            public class Teacher : Employee {
                public string name;
                public Teacher(string N) {
                    this.name = N;
                }
            }

            public class EmployeeCard {

                public bool AuthorizeManager(Employee obj) {

                    if (obj.is_active == "y")
                    {
                        return true;
                    }else { return false;}

                }

            }

            //public class Driver : Employee {

            //    public string DriverName;
            //    public string DriverId;

            //    public Driver(string name, string iD) {

            //        this.DriverName = name;
            //        this.DriverId = iD;
            //    }

            //    public void Drive(vehical v)
            //    {

            //        Console.WriteLine("driver name : " + DriverName + " driver ID : " + DriverId + " is_Driving : " + v.vehicalType + " vehical number is :  " + v.vehicalNumber);

            //    }

            //}
            public class vehical {

                public string vehicalNumber;
                public string vehicalType;

                public vehical(string num , string type) { 
                
                    this.vehicalNumber = num;
                    this.vehicalType = type;

                }

            }

            //********************************composition************************************************

            public class Body{ 
                public string hands;
                public string legs;

                public Body (string hands, string legs){
                    this.hands = hands;
                    this.legs = legs;
                } 

            }

            public class human { 
                public string names;
                public int age;
                Body body;
                public human(string name, int age, string hand , string leg) {
                    this.names = name ;
                    this.age = age;
                    body = new Body(hand,leg);
                }
                public void details() 
                {
                    Console.WriteLine("name : " + this.names);
                    Console.WriteLine("age : " + this.age);
                    Console.WriteLine(body.hands);
                    Console.WriteLine(body.legs);
                }
            }        

            //********************************LAB - 9*************************************************

             public static class TemperatureConverter {
                        public static double CelsiusToFahrenheit(string temperatureCelsius)
                        {   
                            // Convert argument to double for calculations.
                                double celsius = Double.Parse(temperatureCelsius); 

                            // Convert Celsius to Fahrenheit.
                                double fahrenheit = (celsius * 9 / 5) + 32;

                                return fahrenheit;
                        }
                        public static double FahrenheitToCelsius (string temperatureFahrenheit)
                        {
                            // Convert argument to double for calculations.
                                double fahrenheit = Double.Parse(temperatureFahrenheit);

                            // Convert Fahrenheit to Celsius.
                                double celsius = (fahrenheit - 32) * 5 / 9;

                            return celsius;
                        }
                 }



             public static class Product
             {
                 public static int productId = 10;
                 public static double price = 156.32;

                 static Product()
                 {
                     productId = 10;
                     price = 156.32;
                 }

                 public static void Display()
                 {
                     Console.WriteLine("Product ID: " + productId);
                     Console.WriteLine("Price: " + price);
                 }
             }


             public static class Calculate
             {
                 public static int Addition(int a, int b)
                 {
                     return a + b;
                 }
             }


             //public static class A { 
             //    public static int Avalue1 = 10;
             //    public static double AValue2 = 156.32;

             //    static A()
             //    {
             //        Avalue1 = 10;
             //        AValue2 = 156.32;
             //    }
             //    public static void  Methd (int a,int b) {

             //        Console.WriteLine("the sum is" + a + b);
             //    }
             //}

             //public  class B
             //{
             //    public int Bvalue1 = 10;
             //    public double BValue2 = 156.32; 

                 

             //}

             //public class c
             //{
                    public static class DataSharing {
                        public static string SharedData { get; set; }
                    }

                    public class ClassA {
                        public void AccessSharedData() {
                            Console.WriteLine("ClassA: Accessing shared data - " + DataSharing.SharedData);
                        }
                    }

                    public class ClassB {
                        public void ModifySharedData(string newData) {
                            DataSharing.SharedData = newData;
                            Console.WriteLine("ClassB: Modifying shared data - " + DataSharing.SharedData);
                        }
                    }

                    public class ClassC {
                        public void AccessSharedData() {
                            Console.WriteLine("ClassC: Accessing shared data - " + DataSharing.SharedData);
                        }
                    }
     

             //public static class StaticMethods
             //{
             //    public static void Main()
             //    {
             //        int result = Calculate.Addition(5, 3);
             //        Console.WriteLine("Result: " + result);
             //    }
             //

            //********************************LAB - 9*************************************************



                    public class facebook {

                        private string password;
                        private bool loggedIn;

                        public string Password
                        {
                            set
                            {
                                if (loggedIn && ValidatePassword(value))
                                {
                                    password = value;
                                }
                            }
                        }

                        public bool LoggedIn
                        {
                            get { 
                                return loggedIn;
                            }

                            set {

                                loggedIn = value; 
                            }
                        }

                        private bool ValidatePassword(string value)
                        {
                            bool containsLetter = false;
                            bool containsNumber = false;

                            foreach (char c in value)
                            {
                                if (char.IsLetter(c))
                                {
                                    containsLetter = true;
                                }
                                else if (char.IsDigit(c))
                                {
                                    containsNumber = true;
                                }
                            }

                            return containsLetter && containsNumber;
                        }
                    
                    }

                   

            //********************************LAB - 10*************************************************
           
        
        static void Main(string[] args)
                        {

            //********************************LAB - 10*************************************************


                         facebook obj = new facebook();

                          obj.LoggedIn = true;
                          obj.Password = "helloworld2";

                            
             
           //********************************LAB - 10*************************************************
                           
            
            
            
            
            //Product.Display();

                            //int result = Calculate.Addition(5, 3);
                            //Console.WriteLine("Result: " + result);


                            //ClassA classA = new ClassA();
                            //ClassB classB = new ClassB();
                            //ClassC classC = new ClassC();
                           
                            //classA.AccessSharedData(); 

                            //classB.ModifySharedData("New shared data");

                            //classA.AccessSharedData(); 
                            //classC.AccessSharedData(); 
                          

            //********************************LAB - 9*************************************************

                        //Console.WriteLine("Please select the convertor direction");
                        //Console.WriteLine("1. From Celsius to Fahrenheit.");
                        //Console.WriteLine("2. From Fahrenheit to Celsius.");
                        //Console.Write(":");

                        //string selection = Console.ReadLine();
                        //double F, C = 0;
   
                        // switch (selection)
                        //{
                        //    case "1":
                        //            Console.Write("Please enter the Celsius temperature: ");
                        //            F = TemperatureConverter.CelsiusToFahrenheit(Console.ReadLine());
                        //            Console.WriteLine("Temperature in Fahrenheit: {0:F2}", F);
                        //            break;
                        //    case "2":
                        //            Console.Write("Please enter the Fahrenheit temperature: ");
                        //            C = TemperatureConverter.FahrenheitToCelsius(Console.ReadLine());
                        //            Console.WriteLine("Temperature in Celsius: (0:F2}", C);
                        //            break;
                        //    default:
                        //            Console.WriteLine("Please select a convertor.");
                        //            break;
                        //    // Keep the console window open in debug mode.
                        //    Console.WriteLine("Press any key to exit."); Console.ReadKey();
                        //}



            //********************************LAB - 9*************************************************


         

            //human obj = new human("salman", 22, "this is my hands", "this is my legs");
            //obj.details();

            //HoD obj = new HoD("salman imran",222,"Control env polution","txt",1203);
            //obj.WorkingOnProj("Good");
            //obj.WorkingOnProj("Good");
            //obj.WorkingOnProj("Good");
            //obj.HoDDetails();


            //********************************Association 7.2*************************************************


            //HoD Kashif = new HoD();
            //EmployeeCard objCard = new EmployeeCard();
            //Kashif.is_active = "y";

            //if (Kashif.AuthorizeMe(objCard) == true)
            //{
            //    Console.WriteLine("Emplyee has been enter in the company");
            //}
            //else { Console.WriteLine("Emplyee has not been enter in the company"); }

            //********************************Association 7.3*************************************************

            //Driver driver = new Driver("salman", "001");
            //vehical Vehical = new vehical("HCL-5223","Bike");
            //driver.Drive(Vehical);

            //********************************Association 7.5*************************************************

            //HoD Salman = new HoD("salman imran",1234);
            //Teacher t1 = new Teacher("hunain junaid");
            //Teacher t2 = new Teacher("Adnan Ahmed");
            //Teacher t3 = new Teacher("Aman Ali");
            //Salman.AddMember(t1);
            //Salman.AddMember(t2);
            //Salman.AddMember(t3);
            //Salman.HoDDetails();
            
            //************************************************************************************************

            //********************************lab-7***********************************************************

            //employee emp1 = new employee("furqan",26);

            //employee emp2 = new employee(emp1);

            //Console.WriteLine(emp2.PrintData());


            //************************************Q-1*******************************************************

            //Console.WriteLine("**********************Q-1**********************************");

            //Student st1 = new Student("salman",2634,2001,"science");
            //st1.PrintData();

            //*******************************************************************************************

            //************************************Q-2*******************************************************

            //Console.WriteLine("**********************Q-2**********************************");

            //Programming prg1 = new Programming();
            //Programming prg2 = new Programming("hello-world");
           
            //*******************************************************************************************


            //************************************Q-3*******************************************************

            //Console.WriteLine("**********************Q-3**********************************");

            //Rectangle r1 = new Rectangle();
            //Console.WriteLine("Area of rectangle with no parameters: " + r1.CalculateArea());

            //Rectangle r2 = new Rectangle(5);
            //Console.WriteLine("Area of square with one parameter: " + r2.CalculateArea());

            //Rectangle r3 = new Rectangle(4, 6);
            //Console.WriteLine("Area of rectangle with two parameters: " + r3.CalculateArea());

            //*********************************************************************************************

            //************************************Q-4*******************************************************

            //Console.WriteLine("**********************Q-4**********************************");

            //Console.WriteLine("Enter length and breadth of rectangle:");
            //int l = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());

            //Area a = new Area(l, b);
            //Console.WriteLine("Area of rectangle: " + a.ReturnArea());


            //*********************************************************************************************


            //Car obj = new Car(2008, "mustang", 10, 20);

            //obj.getModel();
            //obj.engineWork();
            //obj.setFuel(12);
            //obj.engineWork();

            //*******************************************************************************************


            //Circle c1 = new Circle();
            //c1. radius = 2.0;
            //c1.color= "green";

            //Circle c2= new Circle();
            //c2.radius = 10.0;
            //c2.color="yellow";

            //Console.WriteLine("************************************1st class****************************************");

            //Console.WriteLine("Radius for object c1 is " + c1. radius);
            //Console.WriteLine("Color for object c1 is :"+c1.color);
            //Console.WriteLine("Radius for object c2 is " + c2.radius);
            //Console.WriteLine("Color for object c2 is " + c2.color) ;
            
            
            //Console.WriteLine("Interchanging the Object References in opposite Reference Holders");
            //Circle temp = c1;
            //c1 = c2;
            //c2 = temp;
            //Console.WriteLine("Radius for object c1 is :" +c1. radius);
            //Console.WriteLine("Color for object c1 is :" + c1.color);
            //Console.WriteLine("Radius for object c2 is " + c2. radius) ; Console.WriteLine("Color for object c2 is :" + c2.color);

            ////*********************************2nd Class*********************************************

            //Rectangle c2_Obj_1 = new Rectangle();
            //c2_Obj_1.length = 2.0f;
            //c2_Obj_1.Width = 9.1f;

            //Rectangle c2_Obj_2 = new Rectangle();
            //c2_Obj_2.length = 10.0f;
            //c2_Obj_2.Width = 21.2f;

            //Console.WriteLine("************************************2nd class****************************************");

            //Console.WriteLine("length for object 1 c2  is " + c2_Obj_1.length);
            //Console.WriteLine("width for object  1 c2 is :" + c2_Obj_1.Width);
            //Console.WriteLine("length for object 2 c2 is " + c2_Obj_2.length);
            //Console.WriteLine("width for object  2 c2 is " + c2_Obj_2.Width);


            //Console.WriteLine("Interchanging the Object References in opposite Reference Holders");
           
            //Rectangle temp2 = c2_Obj_1;
            //c2_Obj_1 = c2_Obj_2;
            //c2_Obj_2 = temp2;

            //Console.WriteLine("length for object 1 c2 is :" + c2_Obj_1.length);
            //Console.WriteLine("width for object  1 c2 is :" + c2_Obj_1.Width);
            //Console.WriteLine("length for object 2 c2 is " +  c2_Obj_2.length);
            //Console.WriteLine("width for object  2 c2 is :" + c2_Obj_2.Width);

            ////*******************************************************************************************

            ////*********************************3rd Class*********************************************

            //Author c3_Obj_1 = new Author();
            //c3_Obj_1.name = "salman";
            //c3_Obj_1.email = "test@gmail.com";
            //c3_Obj_1.gender = "male";

            //Author c3_Obj_2 = new Author();
            //c3_Obj_2.name = "abdulbari";
            //c3_Obj_2.email = "test2@gmail.com";
            //c3_Obj_2.gender = "male";

            //Console.WriteLine("************************************3rd class****************************************");

            //Console.WriteLine("name for object   1 c3 is " + c3_Obj_1.name);
            //Console.WriteLine("email for object  1 c3 is :" + c3_Obj_1.email);
            //Console.WriteLine("gender for object 1 c3 is :" + c3_Obj_1.gender);
            //Console.WriteLine("name for object   2 c3 is " + c3_Obj_2.name);
            //Console.WriteLine("email for object  2 c3 is :" + c3_Obj_2.email);
            //Console.WriteLine("gender for object 2 c3 is :" + c3_Obj_2.gender);


            //Console.WriteLine("Interchanging the Object References in opposite Reference Holders");
            //Circle temp3 = c1;
            //c1 = c2;
            //c2 = temp3;
            //Console.WriteLine("name for object      1 c3 is :" + c3_Obj_1.name);
            //Console.WriteLine("email for object     1 c3 is :" + c3_Obj_1.email);
            //Console.WriteLine("gender for object    1 c3 is " + c3_Obj_1.gender);
            //Console.WriteLine("name for object      2 c3 is :" + c3_Obj_2.name);
            //Console.WriteLine("email for object     2 c3 is :" + c3_Obj_2.email);
            //Console.WriteLine("gender for object    2 c3 is :" + c3_Obj_2.gender);

            //*******************************************************************************************

            //***********************************lab-4********************************************************

            //SqlConnection obj = new SqlConnection(@"Data Source=(localdb)\Projects;Initial Catalog=My-Data-Base;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False");

            //string query = "Select * from myData";
            //SqlCommand Command = new SqlCommand(query, obj);
            //DataSet DS = new DataSet();

            //SqlDataAdapter DataAddapt = new SqlDataAdapter(Command);
            //DataAddapt.Fill(DS);
            //obj.Close();

            //foreach (DataTable DT in DS.Tables)
            //{
            //    foreach (DataRow DR in DT.Rows)
            //    {
            //        foreach (DataColumn DC in DT.Columns)
            //        {
            //            Console.WriteLine(DR[DC] + "\t");
            //        }
            //        Console.WriteLine();

            //    }
            //    Console.WriteLine();
            //}
            //*******************************************************************************************


            Console.ReadKey();
        }
    }
}
