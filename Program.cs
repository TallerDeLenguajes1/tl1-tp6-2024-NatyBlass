// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*int a;
int b;

a = 10; 
b = a;

Console.WriteLine("valor de a: "+a);
Console.WriteLine("valor de b: "+b);
*/

string a;
int num, aux;
int numInv;
int i;

numInv = 0;
i = 0;

Console.WriteLine("Ingrese un numero: ");
a = Console.ReadLine();
num = int.Parse(a);


while (num != 0)
{
    aux = num % 10;
    num = (int)num / 10;

    if (i == 0)
    {
        numInv = aux;

    }
    else{
        numInv = numInv * 10 + aux;
        
    }
    i++;
}

Console.WriteLine("Numero Invertido: " +numInv);

