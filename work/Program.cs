string[] array1={"Hello","2","world","Kazan","354"};
int n=3;
string[] array2 = new string[array1.Length] ;
int i=0;
for( int j=0; j< array1.Length; j++)
{
    if(array1[j].Length <= n)
    {
        array2[i]=array1[j];
        Console.Write($"{array2[i]}, ");
        i++;
       
    }
}
if (i==0)
{
Console.WriteLine("Элементов удовлетворяющих условию не найдено");
}
