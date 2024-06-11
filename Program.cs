string cadena, cadena2, cadConcatenadas, subCad;
int tamaño;

Console.WriteLine("Ingrese una cadena de caracteres: ");
cadena = Console.ReadLine();

Console.WriteLine("La cadena ingresada es: " +cadena);

tamaño = cadena.Length; //Length me da la longitud de una cadena

Console.WriteLine("La longitud de la cadena es: " +tamaño);

Console.WriteLine("Ingrese otra cadena de caracteres: ");
cadena2 = Console.ReadLine();

cadConcatenadas = cadena + cadena2;  // el operador + concatena cadenas o también se puede usar el método "String.Concat(cad1,cad2)" 

Console.WriteLine("Las cadenas concatenadas formaron: " +cadConcatenadas);

subCad = cadena.Substring(2);

Console.WriteLine("La SubCadena que se formó es: " +subCad);
