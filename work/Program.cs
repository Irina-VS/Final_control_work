string[] array1={"Hello","2","world","Kazan"};
int n=3;
string[] array2 = new string[array1.Length] ;
int i=0;
for( int j=0; j<=array1.Length; j++)
{
    if (array1[j].Length <= n)
    {
        array2[i]=array1[j];
        i++;
    }
}
if (i>0)
Console.WriteLine(array2);
else
Console.WriteLine("Элементов удовлетворяющих условию не найдено");