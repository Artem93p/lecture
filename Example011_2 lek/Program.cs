// 1 вид
/*void Method1()
{
    Console.WriteLine ("Автор...");
}
Method1();*/
//Метод 2 
/*void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2(msg: "Сообщение текст");
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21(msg:"Сообщение текст", count:4);
Method21( count:4, msg:"Новый текст");*/

//Метод 3 
/*int Method3()
{
    return DateTime.Now.Year;
}
int Year = Method3();
Console.WriteLine(Year);*/

//Метод 4 

/*string Method4(int count, string c)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + c;
        i++;
    }
    return result;
}*/

string Method4(int count, string c)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + c;
    }
    return result;
}
string res = Method4(10, "z");
Console.WriteLine(res);