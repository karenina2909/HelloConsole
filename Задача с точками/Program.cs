 //Console.Clear();
 //Console.SetCursorPosition(1,4);
 //Console.WriteLine("+");
  
int xa = 40, ya = 1,
    xb = 1, yb = 30,
    xc = 60, yc =30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int count =0;
while(count < 10)
{
    int what = new Random().Next(0,3);//012
    if (what ==0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }

    
}