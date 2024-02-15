int choice, ent1, ent2, iRes;
decimal dec1, dec2, dRes;
float flo1, flo2, fRes;
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
}