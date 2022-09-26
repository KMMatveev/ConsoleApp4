double x, y;
Console.WriteLine("Write X, then Y");
x=double.Parse(Console.ReadLine());
y=double.Parse(Console.ReadLine());

if ((x<=1)&&(x>=-1)&& (y <= 1) && (y >= -1))
{
    if (y<=-Math.Abs(x)+1)
    {
        if (y>=-x*x)
        { Console.WriteLine("True"); }
        else
        { Console.WriteLine("False"); }
    }
    else
    { Console.WriteLine("False"); }
}
else
{ Console.WriteLine("False"); }