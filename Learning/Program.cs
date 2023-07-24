// See https://aka.ms/new-console-template for more information
using Learning;
using System.Collections;
using static Learning._StaticCls_N_Interface;



#region Property

clsPropety objProperty = new clsPropety();

Console.WriteLine(objProperty.name);
Console.WriteLine(objProperty.InternalPro);
Console.WriteLine(clsPropety.StaticPro);
Console.WriteLine(objProperty.PublicPro);
#endregion



#region Constructor

var GetPrivateConstructor = typeof(ClsPrivateConstructor).GetConstructor(System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance, null, new Type[0], null);

var Instance = (ClsPrivateConstructor)GetPrivateConstructor.Invoke(null);


ChildConstructor objChildCon = new ChildConstructor();


MissedLearing objmissed = new MissedLearing();

objmissed = new MissedLearing("Parameter constructor");

MissedLearing objMis = new MissedLearing(objmissed);

#endregion





//ClsExceptionMech objExce = new ClsExceptionMech();
//objExce.Divison(5);

//GenericClass<int> objGeneric = new GenericClass<int>();
//objGeneric.Add(1);

//List<int> lst = new List<int>() { 3, 7, 12, 7 };

//List<List<int>>  a = CProgram.groupSort(lst);
//string s1 = String.Join("\n", a.Select(x => String.Join(" ", x)));

//sample s = new(8, 2.5);

sample objs = new sample(2, 2.5);

Console.ReadLine();

//int val = 10;

//try
//{
//    int i;
//    for(i = -1;i<3;++i)
//        val = (val/i);

//}
//catch(ArithmeticException e)
//{
//    Console.WriteLine("0");
//}

//Console.WriteLine(val);
//Console.ReadLine();

//try
//{
//    Console.WriteLine("Exception:" + " " + 1 / Convert.ToInt32(0));
//}
//catch(ArithmeticException e)
//{
//    Console.WriteLine("Divide by ZER error");
//}


//Stack st = new Stack();

//st.Push("hello");
//st.Push(8.2);
//st.Push(5);
//st.Push('b');
//st.Push(true);

//Class2 c2 = new Class2();

//foreach(int j in c2)
//{
//    Console.WriteLine(j + " ");
//    Console.WriteLine();
//}

//#region Property

//    Console.WriteLine("---------------Start Property Initializer------------------");

//    ClsProperty objProperty = new ClsProperty();

//    Console.WriteLine(objProperty._publicPro);
//    Console.WriteLine(ClsProperty._StaticPro);
//    Console.WriteLine(objProperty._Public_Private_Pro);

//    ClsCallProtectProperty objCallProtect = new ClsCallProtectProperty();

//    Console.WriteLine(objCallProtect._ProptectedPro);

//ClsVirtualProperty objVirtualPro = new ClsVirtualProperty();

//Console.WriteLine(objVirtualPro._VirtualProperty);
//Console.WriteLine(objVirtualPro._VirtualProNoDeclare);
//Console.WriteLine(objVirtualPro._DeclareVirtualProperty);

//ClsCallVirtualProperty objCallVirtual = new ClsCallVirtualProperty();

//Console.WriteLine(objCallVirtual._VirtualProperty);
//Console.WriteLine(objCallVirtual._VirtualProNoDeclare);
//Console.WriteLine(objCallVirtual._DeclareVirtualProperty);

//Console.WriteLine("---------------End Property Initializer------------------");

//#endregion




//_NonStaticCls objStatic = new _NonStaticCls();

//objStatic.Print();



//string _StrEncrypt = Class1.Encrypt("10145");


//string _StrDecrypt = Class1.Decrypt(_StrEncrypt);

//// int i = Convert.ToInt32(Console.ReadLine());

//int[] arr = new int[] { 2, 3, 4, 1, 4, 5, 6, 7 };
//// for (int k = 0; k < i; i++)
//// {
////      arr[k] = Convert.ToInt32(Console.ReadLine());
////  }

//List<int> lst = new List<int>();
//int nextPos = 0;
//for (int j = 0; j <= arr.Length - 1; j++)
//{

//    int currentPos = arr[j];
//    if (j + 1 <= arr.Length - 1)
//    {
//        nextPos = arr[j + 1];
//    }
//    if (currentPos < nextPos)
//    {
//        // Console.WriteLine(currentPos);
//        lst.Add(currentPos);
//    }
//    else
//    {
//        foreach (int el in lst)
//        {
//            Console.WriteLine(el);
//        }
//        Console.WriteLine("/n");

//        lst.Clear();
//    }
//}


////B objB1 = new B();

////B objB = new B(1);


//Constructor ObjCon = new Constructor();
//ObjCon.i = 1;
//ObjCon.j = 2;

//Constructor ObjCon2 = ObjCon;

//Constructor obj3 = new Constructor();
//obj3.i = 3;
//obj3.j = 4;
//ObjCon2.j = obj3.j;

//InheritSingleToneClass ObjSingleInst =new InheritSingleToneClass();





//NormalClass objInstace = new NormalClass();
////SingletonDesignPattern ObjInstance = InheritSingleToneClass._Instance;

//CreatePDF objPDF =new CreatePDF();
//objPDF.GeneratePDF();
//SecondLargestNumber largestNumber = new SecondLargestNumber();

//largestNumber.RetrunSecondLargestNumber();



//PrivateConstructor PrivateObj = new PrivateConstructor();

//Console.WriteLine("Hello, World!");
//CountOccurance obj = new CountOccurance();
//var GetCount = obj.CountOccurance_("DOTNETWORLD");
//RemoveDuplicateOccurance Obj1 = new RemoveDuplicateOccurance();
//string Output = Obj1._LamboardRemoveDuplicateOccurance("DOTNETWORLD");
//string _Output = Obj1._RemoveDuplicateOccurance("DOTNETWORLD");
//SwapNumber swapNumber = new SwapNumber();
//swapNumber.SwapTwoNumberWithoutUseTemp();
//swapNumber.SwapTwoNumberUsingTemp();
//Singleton1 s1 = Singleton1.Instance;
//Singleton1 s2 = Singleton1.Instance;


//var PatternObject = SingletonDesignPattern._Instance;
//var PatternObject_ = SingletonDesignPattern._Instance;

//IMobileClient nokiamobilephone = new Nokia();

//MobileClient ObjMobileClient = new MobileClient(nokiamobilephone);
//ObjMobileClient.GetSmartMobileDetails();
//ObjMobileClient.GetNormalMobileDetails();



//Console.ReadLine();





////AbstractClass d = new Derived();
////dynamic foo;




////Console.WriteLine("Addition : {0}\nMultiplication :{1}",
////                                  d.AddTwoNumbers(4, 6),
////                            d.MultiplyTwoNumbers(6, 4));
////Test obj = new Test();
////obj.Print();



////List<Employee> employeeList = new List<Employee>(){
////   new Employee() { Id = 1, Name = "Sunny", Department = "Technical" },
////   new Employee() { Id=2, Name="Pinki", Department ="HR"},
////   new Employee() { Id=3, Name="Tensy", Department ="Finance"},
////   new Employee() { Id=4, Name="Bobby", Department ="Technical"},
////   new Employee() { Id=5, Name="Sweety", Department ="HR"}
////};

//////var result = employeeList.First();

//////var result1 = employeeList.First(e => e.Department == "HR");

//////var result2 = employeeList.First(e => e.Id == 8);

//////var result3 = employeeList.FirstOrDefault(e => e.Department == "HR");
////var result5 = employeeList.SingleOrDefault(e => e.Id == 8);
////var result4 = employeeList.FirstOrDefault(e => e.Id == 8);



////class Employee
////{
////    public int Id { get; set; }
////    public string Name { get; set; }
////    public string Department { get; set; }
////}

////public class Test
////{
////    static string foo1 = "bar: 1";



////    public void Print()
////    {

////        var Test = "Data";

////        dynamic dynamic = Test;

////        Console.WriteLine(dynamic);

////        foo1 = "Updated";

////        Print1(ref foo1);

////        Print(out foo1);



////         Console.WriteLine(foo1);
////    }
////    public void Print(out string foo1)
////    {
////        foo1 = "Print";
////    }
////    public void Print1(ref string foo1)
////    {
////    }
////}
////public sealed class CustoMerDetails
////{
////    public CustoMerDetails()
////    {
////        Console.WriteLine("Default Constructor");
////    }

////    public CustoMerDetails(int I)
////    {
////        Console.WriteLine("Paramterize Constructor");
////    }
////    public string AccountIno()
////    {
////        return "Vithal Wadje";
////    }
////}
////abstract class AbstractClass
////{
////    public int AddTwoNumbers(int Num1, int Num2)
////    {
////        return Num1 + Num2;
////    }
////    public abstract int MultiplyTwoNumbers(int Num1, int Num2);

////}

////class Derived : AbstractClass
////{
////    public override int MultiplyTwoNumbers(int Num1, int Num2)
////    {
////        return Num1 * Num2;
////    }
////}


