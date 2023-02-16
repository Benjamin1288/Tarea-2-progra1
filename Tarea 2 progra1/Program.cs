/* ejercio 1.
 */
byte edad;
Console.Write("¿Cual es la edad que tienes actualmente?: ");
edad = byte.Parse(Console.ReadLine());
Console.WriteLine("No aparentas "+edad+" años");
/* Nota: este Console.ReadLine lo puse para hacer pausas en el programa, hasta que no se le de enter
 * el programa no seguira ejecutandose, lo puse al final de los programas o ejercicios
 */
Console.ReadLine();

/* ejercio 2.
 */
byte n1;
byte n2;
ushort m;
Console.WriteLine("Ingrese el primer número de dos cifras: ");
n1= byte.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo número de dos cifras: ");
n2= byte.Parse(Console.ReadLine());
m = (ushort)(n1 * n2);
Console.WriteLine("Resultado de la multiplicacion de los dos numeros ingresados: "+m);
Console.ReadLine();
/* ejercio 3.
 */
long num1;
long num2;
long s;
long r;
long res;
Console.WriteLine("Ingrese su primer número: ");
num1= long.Parse(Console.ReadLine());
Console.WriteLine("Ingrese su segundo número: ");
num2= long.Parse(Console.ReadLine());
s = num1 + num2;
r = num1 - num2;
res = num1 * num2;
Console.WriteLine("El resultado de la suma es: "+s);
Console.WriteLine("El resultado de la resta es: "+r);
Console.WriteLine("El producto de los dos números es: "+res);
Console.WriteLine("----Fin del programa-----");
Console.ReadLine();