// Улитка ползет по шесту.
int h, a, b, s, n;
h = 10;
a = 3;
b = 2;
s = 0;
n = 0;
while (s < h)
{
   n++;
   s = n * a - (n - 1) * b;
}
Console.WriteLine(n);