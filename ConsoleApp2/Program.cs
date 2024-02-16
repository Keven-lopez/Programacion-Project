int choice, ent1, ent2,x,y, iRes;
decimal dec1, dec2, dRes;
float flo1, flo2, fRes;
double dob,dobRes;
char c;
char[] rev;
string cadena;
Console.WriteLine(@"1. Conversion de Tipos
2. Operaciones con tipos de datos
3. Uso de char y string
4. Uso de tipos de datos numericos:");
choice = int.Parse(Console.ReadLine());
switch (choice)
{
    case 1:
        Console.Clear();
        Console.WriteLine(@"1. Entero a decmial
2. Decimal a flotante
3. Flotante a entero
4. Caracter a entero
5. Entero a caracter");
        choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1: 
                Console.WriteLine("Ingrese un numero entero: ");
                ent1= int.Parse(Console.ReadLine());
                dec1 = ent1;
                Console.WriteLine("Entero a decmial: " + dec1);
                break;
            case 2:
                Console.WriteLine("Ingrese un decimal");
                dec1 = decimal.Parse(Console.ReadLine());
                flo1 = (float)dec1;
                Console.WriteLine("Decimal a flotante: " + flo1);
                break;
            case 3:
                Console.WriteLine("Ingrese un flotante");
                flo1 = float.Parse(Console.ReadLine());
                ent1 = (int)flo1;
                Console.WriteLine("Flotante a entero: " + ent1);
                break;
            case 4:
                Console.WriteLine("Ingrese un caracter");
                c = char.Parse(Console.ReadLine());
                ent1 = (int)c;
                Console.WriteLine("Caracter a entero: " + ent1);
                break;
            case 5:
                Console.WriteLine("Ingrese un numero entero");
                ent1 = int.Parse(Console.ReadLine());
                c=(char)ent1;
                Console.WriteLine("Entero a caracter: " + c);
                break;
        }
        break;
    case 2:
        Console.Clear();
        Console.WriteLine(@"1. Suma de dos enteros
2. Resta de dos decimales
3. Mult de dos flotantes
4. Div de dos enteros
5. Mod de dos enteros");
        choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.WriteLine("Ingrese un numero");
                ent1=int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese otro numero");
                ent2 =int.Parse(Console.ReadLine());
                iRes = ent1 + ent2;
                Console.WriteLine("El resultado es: " + iRes);
                break;
            case 2:
                Console.WriteLine("Ingrese un numero");
                dec1 = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese otro numero");
                dec2 = decimal.Parse(Console.ReadLine());
                dRes = dec1 - dec2;
                Console.WriteLine("El resultado es: " + dRes);
                break;
            case 3:
                Console.WriteLine("Ingrese un numero");
                flo1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese otro numero");
                flo2 = float.Parse(Console.ReadLine());
                fRes = flo1*flo2;
                Console.WriteLine("El resultado es: " + fRes);
                break;
            case 4:
                Console.WriteLine("Ingrese un numero");
                ent1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese otro numero");
                ent2 = int.Parse(Console.ReadLine());
                iRes = ent1 / ent2;
                Console.WriteLine("El resultado es: " + iRes);
                break;
            case 5:
                Console.WriteLine("Ingrese un numero");
                ent1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese otro numero");
                ent2 = int.Parse(Console.ReadLine());
                iRes = ent1 % ent2;
                Console.WriteLine("El resultado es: " + iRes);
                break;
        }
        break;
    case 3:
        Console.Clear();
        Console.WriteLine(@"1. Texto a mayuscula
2. Texto a minuscula
3. Texto al reves
4. Buscar una palabra
5. Numero de vocales");
        choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.WriteLine("Ingrese una cadena de texto");
                cadena=Console.ReadLine();
                cadena=cadena.ToUpper();
                Console.WriteLine("Texto a mayuscula: " + cadena);
                break;
            case 2:
                Console.WriteLine("Ingrese una cadena de texto");
                cadena = Console.ReadLine();
                cadena = cadena.ToLower();
                Console.WriteLine("Texto a minusucla: " + cadena);
                break;
            case 3:
                Console.WriteLine("Ingrese una cadena de texto");
                cadena = Console.ReadLine();
                rev = cadena.ToCharArray();
                Array.Reverse(rev);
                cadena= new string(rev);
                Console.WriteLine("Texto al reves: " + cadena);
                break;
            case 4:
                Console.WriteLine("Ingrese una cadena de texto (Palabra a buscar: perro)");
                cadena= Console.ReadLine();
                if (cadena.Contains("perro")==true)
                {
                    Console.WriteLine("La cadena si tiene la palabra");
                }
                else 
                {
                    Console.WriteLine("La cadena no tiene la palabra");
                }
                break;
            case 5:
                ent1 = 0;
                Console.WriteLine("Ingrese una cadena de texto");
                cadena = Console.ReadLine();
                string vowels = "aeiouAEIOU";
                foreach (var a in cadena)
                {
                    if (vowels.Contains(a))
                    {
                        ent1++;
                    }
                }
                Console.WriteLine("Numero de vocales: " + ent1);
                break;
        }
        break;
    case 4:
        Console.Clear();
        Console.WriteLine(@"1. Area de Triangulo
2. Volumen de esfera
3. Distancia de dos puntos
4. Temperatura en Fahrenheit
5. Temperatura en Celsius");
        choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.WriteLine("Ingrese base de triangulo");
                dec1=decimal.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese altura de triangulo");
                dec2 = decimal.Parse(Console.ReadLine());
                dRes = (dec1 * dec2) / 2;
                Console.WriteLine("El resultado es: " + dRes);
                break;
            case 2:
                Console.WriteLine("Ingrese radio");
                dob = double.Parse(Console.ReadLine());
                dobRes = (Math.Pow(dob, 3) * Math.PI) * (4 / 3);
                Console.WriteLine("El resultado es: " + dobRes);
                break;
            case 3:
                Console.WriteLine("Ingrese x1");
                ent1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese y1");
                ent2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese x2");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese y2");
                y = int.Parse(Console.ReadLine());
                iRes = (int)Math.Sqrt((Math.Pow((x - ent1), 2)) + Math.Pow((y-ent2),2));
                Console.WriteLine("El resultado es: " + iRes);
                break;
            case 4:
                Console.WriteLine("Ingrese temperatura en fahrenehiet");
                ent1= int.Parse(Console.ReadLine());
                iRes = (((ent1 - 32) * 5) / 9);
                Console.WriteLine("Temperatura en celsius: " + iRes);
                break;
            case 5:
                Console.WriteLine("Ingrese temperatura en celsius");
                ent1 = int.Parse(Console.ReadLine());
                iRes = (int)(ent1 * 1.8) + 32;
                Console.WriteLine("Temperatura en fahrenheit: " + iRes);
                break;
        }
        break;
}