using System.Collections;



ArrayList teklist = new ArrayList();
ArrayList ciftlist = new ArrayList();
ArrayList list = new ArrayList();
int gelensayi;
int toplam = 0;
int tektoplam = 0;
int cifttoplam = 0;

for (int i = 0; i < 4; i++)
{
    Console.Write(i + 1 + ". sayıyı giriniz : ");
    gelensayi = int.Parse(Console.ReadLine());
    list.Add(gelensayi);

    if (gelensayi % 2 == 0)
    {
        ciftlist.Add(gelensayi);
        cifttoplam += gelensayi;
    }
    else
    {
        teklist.Add(gelensayi);
        tektoplam += gelensayi;
    }
    toplam += gelensayi;
}
Console.WriteLine("Tek Sayılar  : " + teklist.Count + " Tane");
Console.WriteLine("Çift Sayılar : " + ciftlist.Count + " Tane");

Console.Write("Tek Sayılar : ");
foreach (object tekyazdir in teklist)
{
    Console.Write(tekyazdir + ",");
}
Console.WriteLine();

Console.Write("Çift Sayılar : ");
foreach (object ciftyazdir in ciftlist)
{
    Console.Write(ciftyazdir + ",");
}
Console.WriteLine();

Console.Write("Tüm Sayılar : ");
foreach (object listyazdir in list)
{
    Console.Write(listyazdir + ",");
}
Console.WriteLine();

Console.WriteLine("Toplam : " + toplam);
Console.WriteLine("Çiftlerin Toplamı : " + cifttoplam);
Console.WriteLine("Teklerin toplamı : " + tektoplam);
