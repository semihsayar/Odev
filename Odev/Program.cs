
Console.WriteLine("REF KEYWORD");
int number1 = 10;
int number2 = 20;

var result = Add(ref number1,number2);

Console.WriteLine(result);
// EĞER REF KEYWORD KULLANMASAYDIK NUMBER1 YUKARIDA VERDİĞİMİZ DEĞERDE KALACAKTI ÇÜNKÜ PROGRAM YUKARIDAN AŞAĞIYA DOĞRU ÇALIŞIR
// NUMBER1'İ DEĞİŞTİRMEK İSTEDİĞİMİZ REF KEYWORD KULLANDIK (DEĞER TİPİNİ REFERANS TİPİNE DEĞİŞTİRDİK)
Console.WriteLine(number1);

static int Add (ref int number1, int number2)
{
    number1 = 40;
    return number1 + number2;
}
Console.WriteLine("------------------");

Console.WriteLine("OUT KEYWORD");


int number3;
int number4 = 20;

var result2 = Add2( out number3, number4);

Console.WriteLine(result2);
// REF VE OUT AYNIDIR OUT UN ÖZELLİĞİ SADECE BİR TANE DEĞER VERMEMİZ GEREKİYOR 
// REF ANAHTAR KELİMESİNDE TEK BİR DEĞER VERDİĞİMİZ ZAMAN HATA ALIYORUZ
Console.WriteLine(number3);

static int Add2(out int number3, int number4)
{
    number3 = 40;
    return number3 + number4;
}