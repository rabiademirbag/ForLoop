Console.WriteLine("1->Konsol ekranına 10 kere \"Kendime inanıyorum, ben bu yazılım işini hallederim!\" yazdırınız.");

for(int i=0; i<10; i++)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
}

Console.WriteLine("---------------------------------------------------------------------------");

Console.WriteLine("2 -> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.");

for(int i=1; i<=20; i++)
{
    Console.Write(i+" ");
    
}
Console.WriteLine("\n");

Console.WriteLine("---------------------------------------------------------------------------");

Console.WriteLine("3-> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.");

for(int i =1; i<=20; i++)
{
    //sayı çift ise ekrana yazdırıyorum
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
    }
}
Console.WriteLine("\n");

Console.WriteLine("---------------------------------------------------------------------------");

Console.WriteLine("4 -> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.");

//toplam değerini tutmak için değişken tanımlayıp başlangıç değerini 0 yapıyorum
int sum=0;
for(int i=50; i<=150; i++)
{
    //her bir i değerini topluyorum
    sum += i;
}
Console.WriteLine(sum);

Console.WriteLine("---------------------------------------------------------------------------");

Console.WriteLine("5-> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.");

//tek sayıların toplamı için başlangıç değeri 0 olan bir değişken tanımlıyorum
int sumOdd = 0;
//çift sayıların toplamı için başlangıç değeri 0 olan bir değişken tanımlıyorum
int sumEven = 0;
for(int i=1; i<=120; i++)
{
    //sayı çift değilse i değerini sumOdd üzerine ekliyorum
    if(i % 2 != 0)
    {
        sumOdd += i;
    }
    else
    {
        //diğer durumda zaten sayı çift olur her bir i değerini sumEven üzerine ekliyorum
        sumEven += i;
    }
}
//Ekrana yazdırıyorum
Console.WriteLine("Tek Sayıların Toplamı: " + sumOdd);
Console.WriteLine("Çift Sayıların Toplamı: " + sumEven);
