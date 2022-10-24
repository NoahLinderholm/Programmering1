Random rnd = new Random();
int svar = rnd.Next(1,101);
int i=0;
for(int y = 1; i!=svar; y++)
{
Console.WriteLine("Gissa ett tal mellan 1 och 100");
i = Convert.ToInt32(Console.ReadLine());
if(i > svar)
{
    Console.WriteLine("Du gissade för högt");
}
else if (i < svar)
{
    Console.WriteLine("Du gissade för lågt");
}
else
{
    Console.WriteLine("Du gissade rätt");
}
{
    Console.WriteLine("Du har gjort "+y+" gissningar");
}
}
