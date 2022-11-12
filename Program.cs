// See https://aka.ms/new-console-template for more information.
//Console.Write("enter you name:");
//String name = Console.ReadLine();
//Console.WriteLine("hello " + name);
//string s = "hello \r\n world";
//Console.WriteLine(s);
//Console.WriteLine(s.Length);

//String firstName = "john";
//String lastName = "doe";
//String res = String.Format("{0} {1}",firstName,lastName);
//Console.WriteLine(res);
//int x =1;
//int y =2 ;
//String res = $"{x} + {y} = {x + y} ";
//Console.WriteLine(res);
//byte b = 5;
//Console.WriteLine(byte.MaxValue);
//Console.WriteLine(byte.MinValue);
//sbyte s = -5;
//Console.WriteLine(sbyte.MinValue);
//Console.WriteLine(sbyte.MaxValue);
//long l = 5;
//Console.WriteLine(long.MaxValue);
//Console.WriteLine(long.MinValue);
//
//Console.WriteLine(3600 * 24*365);
//Console.WriteLine(9223372036854775807 / 31536000000);

//Console.Write("enter the first no:");
//int n1 = int.Parse(Console.ReadLine());
//
//Console.Write("enter second no:");
//int n2 = int.Parse(Console.ReadLine());
//
//Console.WriteLine(n1 + n2);
//Console.Write("enter your mail ID ");
//string email = Console.ReadLine();
//Console.WriteLine(email.Split("@")[0]);

//Console.WriteLine("enter a no:");
//int a = int.Parse(Console.ReadLine());
//for (int i = 1; i < 12; i++){
//    Console.WriteLine($"{a} * {i} =  {a*i}");
//}



using ConsoleAppcore;
using System.ComponentModel.DataAnnotations;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

//var numbers = new object [5];
//Console.WriteLine(numbers.Length);
//numbers[0] = 10;
//numbers[1]= 20;
//numbers[2]= 30;
//numbers[3] = 40;
//numbers[4] = "hello";
//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine(numbers[i]);
//}
//foreach(var item in numbers)
//{
//    Console.WriteLine(item);
//}
//var numbers = new int[10];
//for (int i = 0; i<numbers.Length; i++)
//{
//    Console.WriteLine("enter the no:");
//    numbers[i] = int.Parse(Console.ReadLine());
//}   
//foreach(var number in numbers)
//{
//    if(number % 2 == 0)
//        Console.WriteLine(number);
//}
//int i = 100;
//int j = 10;
//if(i>j){
//    Console.WriteLine("I");
//}
//else
//{
//    Console.WriteLine("J");
//
//}
//string res = i > j ? "I" : "J";
//Console.WriteLine(res);
//int i = 4;
//switch(i)
//{
//    case 1:
//        Console.WriteLine("one");
//        break;
//        case 2: 
//        Console.WriteLine("two");
//        break;
//        default:
//        Console.WriteLine("three");
//        break;
//
//}
//string name = "amala";
//for (int i = name.Length-1; i>=0; i--)
//{
//    Console.Write(name[i]);
//}

//string var = "hello world";
//int count = 0;
//for (int i = 0; i < var.Length; i++)
//{
//    if (var[i] == ' ')
//    {
//        count++;
//    }
//}
//Console.Write(count);
//int[] numbers = { 1, 2, 3, 4, 5, 6, };
//int sum=0;
//for(int i=0; i<numbers.Length; i++)
//{
//    sum=sum+numbers[i];
//}
//Console.Write(sum);
//int[] numbers = {  8, 9, 10, 11, 12,45,67,80,32,54 };
//int max = 0;
//int secmax = 0;
//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i] > max)
//    {
//        max = numbers[i];
//    }
//}
//    for (int i = 0; i < numbers.Length; i++) { 
//    if ((secmax < numbers[i]) && (numbers[i]< max))
//    {
//        secmax = numbers[i];
//    }
//   
//}
//Console.WriteLine(max);
//Console.WriteLine(secmax);
//string s = "this is a string ,that is a string";
//s = s.ToUpper();    
//Console.WriteLine(s.StartsWith("this", StringComparison.InvariantCultureIgnoreCase));
//if (s.EndsWith("this"))
//{
//    Console.WriteLine("yes");
//
//}
//else { Console.WriteLine("no"); }
//Console.WriteLine(s.Replace("a","the"));
//string[] words = s.Split(' ');
//for(int i = 0; i < words.Length; i++)
//{
//    if (words[i] == "a")
//    {
//        words[i] = "aa";
//        
//    }
//}
//Console.WriteLine(string.Join(" ", words));
//Var data = new int?[5];
//
//Foreach (var item in data)
//
//{   Console.WriteLine(item); 
// 
//}
//string data = null;
//
//Console.WriteLine(data?.ToUpper());
//int[] numbers = { 1, 2, 3, 4, 5, 5, 2, 8, 7, 9, 2 };
//int[] duplicates = new int[numbers.Length];
//int k = 0;
//foreach ( var number in numbers)
//{
//    int count = 0;
//    foreach (var item in numbers) {  
//    if(number == item)
//    
//        count++;
//    }
//    if (
//        count >= 2)
//    {
//        bool hasFoundMatch = false;
//        foreach(var num in duplicates)
//        {
//            if (num == number)
//            {
//                hasFoundMatch = true;
//                break;      
//            }
//        }
//    }
//    if(!hasFoundMatch)
//
//   
//}
////int[] number = { 1, 2, 1, 3, 4, 5, 6 };
//var res = number.GroupBy(m => m)
//    .Select(m => m.Key);
//    Console.WriteLine(string.Join(" ", res));
//string data = "malayalam";
//for(int i = 0; i < data.Length-1; i++)
//for(int j =data.Length-1 ; j > data.Length-1; j--)
//        {
//    if (data[i] == data[j])
//    {
//            Console.WriteLine("pallindrome");  
//                }
//        else
//        {
//            Console.WriteLine("not pallindrome");
//        }
//}
//for (int i = 0; i < 10; i++)
//{
//    for (int j = 0; j < 15; j++)
//    {
//        if (i == 0 || i == 9)
//        {
//            Console.Write("*");
//
//        }
//        else if (j == 0 || j == 14)
//        {
//            Console.Write("*");
//
//        }
//        else
//        {
//            Console.Write(" ");
//        }
//
//
//    }
//    Console.WriteLine(" ");
//
//}
//for (int i = 0; i < 10; i++)
//{
//    for(int j = 10;j>i ; j--)
//    {
//        Console.Write("-");
//    }
//    for (int k = 0; k < 2 * i - 1; k++) {
//        
//        Console.Write(" "); 
//}
//for (int j = 10; j > i; j--)
//    {
//        Console.Write("-");
//    }
//    Console.WriteLine();
////}
//void Add(int x, int y) => Console.WriteLine(x + y);
//Add(1,2);
//
//void Add( int x,int y ,params int[] numbers)
//{
//    Console.WriteLine(numbers.Sum()+x+y);
//}
//Add(1,2);
//Add(1,2,3);
//int Add(int x, int y) => x + y;
//int res = Add(1, 2);
//Console.WriteLine(res);
//var lst = new List<int>();
//lst.Add(1);
//lst.Add(2);
//lst.Add(3);
//lst.Insert(lst.Count - 1, 4);
//Console.WriteLine(lst[3]);
//
//var arr1 = new int[] { 1, 2, 3, 4, };
//var arr2 = new int[arr1.Length];
//Array.Copy(arr1, arr2, arr1.Length);
//arr2[0] = 10;
//Console.WriteLine(string.Join(",", arr1));
//Console.WriteLine(string.Join(",", arr2));



//string text = null;
//if (string.IsNullOrWhiteSpace(text))
//{
//    Console.WriteLine("yes");
//}
//for (var i = 0; i < 10; i++)
//{
//    var res = new string('*', 15);
//    Console.WriteLine(res);
//}
//char txt = 'b';
//if(txt>'a'&& txt < 'z')
//{
//
// Console.WriteLine("it is in uppercase");
//}
//var person = new Dictionary<string, string>()
//{
//    { "age","23"},
//    
//};
//person.Add("name", "brijesh");
//person.Add("planet", "earth");
//Console.WriteLine($" {person["name"]} is  living 0n {person["planet"]}. he is {person["age"]}");


//var person = new { Name = "alan", height = 180 };
//Console.WriteLine(person.Name);

//var text = "hello";
//if(text.GetType() == typeof(string))
//{
//    Console.WriteLine("its a string");
//}

//int? i = null;
//if (i == default)
//{
//    Console.WriteLine("yes");
//
//}
//var count = 0;
//var info = new Dictionary<string, string>();
//{

//    for (int i = 1; i <= 3; i++)
//    {
//        count++;
//        Console.WriteLine($" Enter the person {count}'s details");
//        Console.WriteLine("Enter the name ");
//        string name = Console.ReadLine();
//        Console.WriteLine("Enter the age ");
//        string age = Console.ReadLine();
//        info["name"] = name;
//        info["age"] = age;



//    }

//    Console.WriteLine(info.Count);
//    foreach (var item in info)
//    {
////        Console.WriteLine($"{item.Key}:{item.Value}");
//
////    }
////}
//var s1 = new Student();
//s1.Name = "Student 1";
//s1.Mark1 = 45;
//s1.Mark2 = 50;
//s1.Average();
//
//var s2 = new Student()
//{ 
//Name = "Student 1",
//Mark1 = 55,
//Mark2 = 60,
//};
//
//s2.Average();
//
//class Student
//{
//    public string Name;
//    public int Mark1;
//    public int Mark2;
//    private int Total() => Mark1 + Mark2;
//    public void Average() => Console.WriteLine(Total() / 2);









//var s1 = new student()
//{
//
//    FullName = "qwerty",
//    Age = 25
//};
//Console.WriteLine(s1.FullName);
//Console.WriteLine(s1.Age);
//s1.GetData();

//
//string t = "abc";
//string r = "abcde";
//Console.WriteLine(t.CompareTo(r));

//var e1 = new Employee()
//{
//    Name = "brijesh",
//    Department = "ESS",
//    Designation = "trainee"
//
//
//};
//var e2 = new Employee()
//{
//    Name = "amala",
//    Department = "DTS",
//    Designation = "senior employee"
//};
//var e3 = new Employee()
//{
//    Name = "aiswarya",
//    Department = "PES",
//    Designation = "manager"
//
//};
//Console.WriteLine(e1.Name);
//Console.WriteLine(e1.Department);
//Console.WriteLine(e1.Designation);
//Console.WriteLine(e1.Salary);

//Q3..
//var an1 = new Animals()
//{
//    Name = "cat",
//    MaxLife = 13,
//    Food = "Fish"
//
//};
//an1.showData();

//q4.

//var f1 = new Furniture();
//var f2 = new Furniture("chair","thekk",2000);
//
//f1.Show();
//f2.Show();

//q5.
var fd1 = new Food() { 

   Name = "biriyani",
   Price = 200
  

};
fd1.ShowData();

//q6.



