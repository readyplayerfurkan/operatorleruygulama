// See https://aka.ms/new-console-template for more information

// Atama ve İşlemli Atama

int x = 3;
int y = 4;

x += 3; // x değerini 3 arttırdı.
x -= 2; // x değerini 2 arttırdı. Bu işlemin adı "İşlemli Atama"dır.

Console.WriteLine(x);

y /= 2; // y değerini 2'ye böldü.
y *= 2; // y değerini 2 ile çarptı.

Console.WriteLine(y);

// Mantıksal Operatörler

// ||, &&, ! sırasıyla: veya, ve, eşit değildir

bool isSuccess = true;
bool isCompleted = false;

if (isSuccess && isCompleted)
   Console.WriteLine("Perfect");

if (isSuccess || isCompleted)
    Console.WriteLine("Great");

if (isSuccess && !isCompleted)
    Console.WriteLine("Fine");

// İlişkisel Operatörler

// <, >, ==, !=, <=, >= sırasıyla büyüktür, küçüktür, eşittir, eşit değildir, küçük eşit, büyük eşit

int a = 3;
int b = 4;
bool sonuc = a < b;
Console.WriteLine(sonuc);

sonuc = a > b;
Console.WriteLine(sonuc);

sonuc = a >= b;
Console.WriteLine(sonuc);

sonuc = a <= b;
Console.WriteLine(sonuc);

sonuc = a == b;
Console.WriteLine(sonuc);

sonuc = a != b;
Console.WriteLine(sonuc);

// Aritmetik Operatörler
// /, *, +, - sırasıyla bölme, çarpma, toplama, çıkarma

int sayi1 = 10;
int sayi2 = 5;
int sonuc1 = sayi1 / sayi2;
Console.WriteLine(sonuc1);

sonuc1 = sayi1 * sayi2;
Console.WriteLine(sonuc1);

sonuc1 = sayi1 - sayi2;
Console.WriteLine(sonuc1);

sonuc1 = sayi1 + sayi2;
Console.WriteLine(sonuc1);

// % : mod alır. Yani kalanı verir.

int sonuc2 = 20 % 3;
Console.WriteLine(sonuc2);



