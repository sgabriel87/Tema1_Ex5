/*
Se citesc doua numere de la tastatura, x, y. Scrieti un program care va afisa cele
doua valori in ordine crescatoare.
• Exemplu: citim 9,0 Afisam : 0 9*/

Console.WriteLine("Introduceti primul numar:");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Introduceti al doilea numar:");
int y = Convert.ToInt32(Console.ReadLine());


if (x > y)
{   //valoare temporara de sotcare
    int temp = x;
    //x devine y
    x = y;
    //y devine valoare temp x
    y = temp;
}

Console.WriteLine("Cele doua numere in ordine crescatoare:");
Console.WriteLine(x + " " + y);