// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// /*int a;
// int b;

// a = 10; 
// b = a;

// Console.WriteLine("valor de a: "+a);
// Console.WriteLine("valor de b: "+b);
// */

// string a;
// int num, aux;
// int numInv;
// int i;

// numInv = 0;
// i = 0;

// Console.WriteLine("Ingrese un numero: ");
// a = Console.ReadLine();
// num = int.Parse(a);


// while (num != 0)
// {
//     aux = num % 10;
//     num = (int)num / 10;

//     if (i == 0)
//     {
//         numInv = aux;

//     }
//     else{
//         numInv = numInv * 10 + aux;
        
//     }
//     i++;
// }

// Console.WriteLine("Numero Invertido: " +numInv);

int opc, cont;
float resultado, num1;
string opcAux, num1Aux, contAux;
opc = 0;
resultado = 0;
cont = 1;

while (cont != 0)
{
    Console.WriteLine("================MENU================");
    Console.WriteLine(" 1 - VALOR ABSOLUTO");
    Console.WriteLine(" 2 - CUADRADO DE UN NUMERO");
    Console.WriteLine(" 3 - RAIZ CUADRADA DE UN NUMERO");
    Console.WriteLine(" 4 - SENO");
    Console.WriteLine(" 5 - COSENO");
    Console.WriteLine(" 6 - ENTERO DE UN FLOAT");
    Console.WriteLine("===================================");
    Console.WriteLine("Ingrese una Opcion : ");
    opcAux = Console.ReadLine();
    opc = int.Parse(opcAux);
    
    Console.WriteLine("Ingrese un Numero: ");
    num1Aux = Console.ReadLine();

    num1 = float.Parse(num1Aux);


    switch (opc)
    {
        case 1: 
            if (num1 < 0)
            {
                resultado = num1 * (-1);
            }
            else
            {
                resultado = num1;
            }
            break;
        
        case 2: 
            resultado = num1 * num1;
            break;

        case 3: 
            resultado = (int)Math.Sqrt(num1);
            break;

        case 4: 
            resultado = (float)Math.Sin(num1);
            break;
        case 5:
            resultado = (float)Math.Cos(num1);
            break;
        case 6: 
            resultado = (int)Math.Floor(num1);
            break;

        default:
            Console.WriteLine("Ingreso una opcion no valida");
            break;
    }
    
    Console.WriteLine($"Resultado de la Operacion: {resultado}"); 

    Console.WriteLine("¿Desea Realizar otra Operacion?");
    Console.WriteLine("0  = NO || 1 = SI");
    contAux = Console.ReadLine();
    cont = int.Parse(contAux);
}

    Console.WriteLine("Saliendo...");
