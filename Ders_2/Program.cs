//veriable yazma qaydalari
//1. qayda
var intMin = byte.MinValue;
var intMax = byte.MaxValue;
Console.WriteLine("Bu araliqda yaza bilersiz  " + intMin + "--" + intMax);
byte a1 = 33; /*Convert.ToByte(Console.ReadLine());*/
byte a2 = 33; /*Convert.ToByte(Console.ReadLine());*/
Console.WriteLine(a1 + a2);
//2.qayda
byte b1 = 45, b2 = 36;
Console.WriteLine(b1 + b2);
//3. qayda
byte c1 = 45, c2;
c2 = 36;
Console.WriteLine(c1 + c2);

//integral numeric types
int num1 = 13;
uint num2 = 13;
long num3 = 13;
byte num4 = 13;
ulong num5 = 13;
short num6 = 13;
ushort num7 = 13;
sbyte num8 = 13;

//floating numeric stypes
float fnum1 = 13.9f;
double fnum2 = 13.9; //or 13.9d, 13.9D
decimal fnum3 = 13.9m;

//boolean types
bool bool1 = false; //or 5>9
bool bool2 = true;  //or 5<9
bool bool3 = (9 < 3) && (4 > 5);
Console.WriteLine(bool3);

//char types
char char1 = 'A'; /*Convert.ToChar(Console.ReadLine());*/
char char2 = 'B';
var concat = char1 + char2;
var concat2 = char1.ToString() + char2.ToString();
Console.WriteLine(concat);
Console.WriteLine(concat2);

var control1 = char.IsLower(char1);
if(control1 == true)
{
    Console.WriteLine(char1 + " -- Boyuk Herifdi");
}
else
{
    Console.WriteLine(char1 + " -- Kicik Herifdi");
}

//string types
string str1 = "Hello Azerbaijan";
var a = str1.Length;
Console.WriteLine("("+str1.ToUpper()+")"+" yazinin uzunlugu -- "+a);
