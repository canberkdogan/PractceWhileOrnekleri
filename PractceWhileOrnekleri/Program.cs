//Bu pratik uygulama 5 aşamadan oluşuyor ve aşağıdaki alıştırmaları while kullanarak yazdım.


int sayac = 1;

while (sayac <= 10) // Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırdım
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim" + sayac);
    sayac++;
}

Console.WriteLine("------------------------------------------");

int deger = 2;

while (deger <= 19) //1 ile 20 arasındaki sayıları konsol ekranına yazdırdım.
{
    Console.WriteLine("sayı" + deger);
    deger++;
}

Console.WriteLine("------------------------------------------");

int sayi = 1;
while (sayi <= 20) // 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.

{
    if (sayi % 2 == 0)
        Console.WriteLine(sayi);
    sayi++;
}

Console.WriteLine("-------------------------------------------");

int sayideger = 0;
int sayideger1 = 51;

while (sayideger1 <= 149) //50 ile 150 arasındaki sayıların toplamını ekrana yazdırdım.
{

    sayideger += sayideger1;
    sayideger1++;
}
Console.WriteLine("sayıların toplarını" + sayideger);

Console.WriteLine("---------------------------------------------");



int toplamTek = 0;
int toplamCift = 0;

int i = 1;

while (i <= 120) //1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırdım.
{
    if (i % 2 == 0)
    {
        toplamCift += i;

    }
    else
    {
        toplamTek += i;
    }
    i++;
}
Console.WriteLine("1 ile 120 arasındaki tek sayıların toplamı:" + toplamTek);
Console.WriteLine("1 ile 120 arasındaki çift sayıların toplamı:" + toplamCift);   


