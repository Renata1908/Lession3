// Вид 1 Ничего не принимае и ничего не возврщает
// void Method1()
// {
//     Console.WriteLine("Автор...");
// }
// Method1();

// Вид 2 Принимает, но ничего не возвращает

// void Method2(string msg)
// void Method21(string msg, int count)
// {
//     int i = 0;
//     while(i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }

// }
// Method21(msg:"Текст сообщения", count: 4);

// Вид 3 ничего не приниает, но возвращает

// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);


// Вид 4 и принимают, и возвращают

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "za ");
Console.WriteLine(res);




