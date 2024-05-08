//See https://aka.ms/new-console-template for more information
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

int opc, num1, num2, result, cont;
float resultado;
string opcAux, num1Aux, num2Aux, contAux;
opc = 0;
result = 0;
resultado = 0;
cont = 1;

while (cont != 0)
{
    Console.WriteLine("================MENU================");
    Console.WriteLine(" 1 - SUMA");
    Console.WriteLine(" 2 - RESTA");
    Console.WriteLine(" 3 - PRODUCTO");
    Console.WriteLine(" 4 - DIVISION");
    Console.WriteLine("===================================");
    Console.WriteLine("Ingrese una Opcion : ");
    opcAux = Console.ReadLine();
    opc = int.Parse(opcAux);
    
    Console.WriteLine("Ingrese dos Numeros: ");
    num1Aux = Console.ReadLine();
    num2Aux = Console.ReadLine();

    num1 = int.Parse(num1Aux);
    num2 = int.Parse(num2Aux);

    switch (opc)
    {
        case 1: 
            result = num1 + num2;
            break;
        
        case 2: 
            result = num1 - num2;
            break;

        case 3: 
            result = num1 * num2;
            break;

        case 4: 
            resultado = num1 / num2;
            break;

        default:
            Console.WriteLine("Ingreso una opcion no valida");
            break;
    }

    if (opc == 1 || opc == 2 || opc == 3)
    {
        Console.WriteLine($"Resultado de la Operacion: {result}");
    }
    else
    {
        if (opc == 4)
        {
            Console.WriteLine($"Resultado de la Operacion: {resultado}"); 
        }
    }

    Console.WriteLine("¿Desea Realizar otra Operacion?");
    Console.WriteLine("0  = NO || 1 = SI");
    contAux = Console.ReadLine();
    cont = int.Parse(contAux);
}

    Console.WriteLine("Saliendo...");
