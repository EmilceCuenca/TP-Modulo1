bool continuar = true;
do
{
    Titulo();
    Console.WriteLine("Por favor, introduce la temperatura actual (en grados celsius) ");
    bool temp_valida = double.TryParse(Console.ReadLine(), out double temperatura);
    while (!temp_valida)
    {
        Console.WriteLine("Por favor, ingrese un número válido. ");
        temp_valida = double.TryParse(Console.ReadLine(), out temperatura);
    }
    Console.Clear();
    Titulo();
    Console.WriteLine(" Temperatura de " + temperatura + "°C");
    Console.WriteLine();
    switch (temperatura)
    {
        case < 0:
            Console.WriteLine("Hace mucho frío afuera, asegúrate de abrigarte bien. ");
            break;
        case <= 20:
            Console.WriteLine("El clima está fresco, una chaqueta ligera sería perfecta.");
            break;
        case > 20:
            Console.WriteLine("Hace calor afuera, no necesitas una chaqueta. ");
            break;
    }
    Console.WriteLine();
    Console.WriteLine("Para consultar otra temperatura, presione 1. ");
    Console.WriteLine("Para conocer el pronóstico de los próximos 5 días, presione 2.");
    Console.WriteLine();
    Console.WriteLine("Para finalizar, presione cualquier otra tecla ");
    var desicion_1 = Console.ReadKey().KeyChar.ToString();
    Console.Clear();
    if (desicion_1 != "1" && desicion_1 != "2")
    {
        Titulo();
        Despedida();
        continuar = false;
    }
    else if (desicion_1 == "2")
    {
        Titulo();
        Console.WriteLine("Pronóstico para los próximos 5 días:");
        Console.WriteLine();
        Pronostico_5dias(temperatura);
        Console.WriteLine();
        Console.WriteLine("Para consultar otra temperatura, presione 1. ");
        Console.WriteLine();
        Console.WriteLine("Para finalizar, presione cualquier otra tecla. ");
        var desicion_2= Console.ReadKey().KeyChar.ToString();
        if (desicion_2 != "1")
        {

            continuar = false;
        }
        Console.Clear();
    }
}
while (continuar == true);
Titulo();
Despedida();
void Titulo()
{
    Console.WriteLine("PRONÓSTICO DEL TIEMPO");
    Console.WriteLine();
}
void Despedida()
{
    Console.WriteLine("Gracias por utilizar nuestro servicio.");
    Console.WriteLine("¡Hasta pronto! ");
}
void Pronostico_5dias(double temperatura)
{
    string?[] dias = { "Mañana", "Pasado mañana", "Dentro de tres días", "Dentro de cuatro días", "Dentro de cinco días" };
    Random random = new Random();
    int min = Convert.ToInt32(temperatura-5);
    int max = Convert.ToInt32(temperatura+5);
    for(int i = 0; i < dias.Length; i++)
    {
        int temp_aleatoria = random.Next(min, max);
        Console.WriteLine(dias[i]+": temperatura de " +temp_aleatoria+"°C .");
    }
}