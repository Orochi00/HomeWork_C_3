int number = 14212;
int a = int.Parse(Convert.ToString(number)[0].ToString());
int b = int.Parse(Convert.ToString(number)[4].ToString());
int c = int.Parse(Convert.ToString(number)[1].ToString());
int d = int.Parse(Convert.ToString(number)[3].ToString());

if ((a == b) | (c == d))
{System.Console.WriteLine("Да, палиндромом ");}
else {System.Console.WriteLine("Нет");}