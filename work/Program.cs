string[] arry1={“Hello”, “2”, “world”, “Kazan”};
int n=3;
string[] arry2;
int M= arry1.Length;
//m - индекс arry1, i - индекс arry2
for( int m=0; m<=M; m++)
{
    if (arry1[m].Length<=n)
    {
        arry2[i]=arry1[m];
        i++;
    }
}
if (i>0)
Console.WriteLine(arry1);
else
Console.WriteLine("Элементов удовлетворяющих условию не найдено");