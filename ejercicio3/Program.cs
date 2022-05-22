
Console.WriteLine("Por favor ingrese diez numeros");
int[] numeros = new int[10];

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Ingrese el numero {i +1}");
    numeros[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Los valores son:");
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine(numeros[i]);
}

//Obtener el mayor y menor
int mayor = numeros[0];
int menor = numeros[0]; 
for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] > mayor)
    {
        mayor = numeros[i]; 
    } else
    {
        menor = numeros[i];
    }
}
Console.WriteLine($"El numero mayor es: {mayor}");
Console.WriteLine($"El numero menor es: {menor}");

//Calcular suma y promedio
double suma = 0;
double promedio = 0;
for (int i = 0; i < numeros.Length; i++)
{
    suma += numeros[i];
}
promedio = suma / numeros.Length;

Console.WriteLine($"La suma total es: {suma}");
Console.WriteLine($"El promedio de los numeros ingresados es de: {promedio}");







