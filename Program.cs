Personaje kratos = new Personaje("Kratos", 100, 1, 20);
Personaje masterChief = new Personaje("Master Chief", 120, 2, 15);
Personaje doomSlayer = new Personaje("Doom Slayer", 150, 5, 120);
Personaje link = new Personaje("Link");
Personaje porDefecto = new Personaje();

Console.WriteLine("=== ESTADO INICIAL ===");
Console.WriteLine();
kratos.MostrarInformacion();
masterChief.MostrarInformacion();
doomSlayer.MostrarInformacion();
link.MostrarInformacion();
porDefecto.MostrarInformacion();

Console.WriteLine("=== COMBATE ===");
Console.WriteLine();
kratos.Atacar(masterChief);
masterChief.Atacar(kratos);
kratos.Curar(10);
masterChief.SubirNivel();
link.Atacar(porDefecto);
doomSlayer.Atacar(porDefecto);

// El daño (120) supera la vida que le quedaba (90), pero la vida no baja de 0.
Console.WriteLine($"Vida del Personaje por defecto tras el ataque: {porDefecto.ObtenerVida()}");
Console.WriteLine();

Console.WriteLine("=== ESTADO FINAL ===");
Console.WriteLine();
kratos.MostrarInformacion();
masterChief.MostrarInformacion();
doomSlayer.MostrarInformacion();
link.MostrarInformacion();
porDefecto.MostrarInformacion();

Console.WriteLine("=== ¿SIGUEN CON VIDA? ===");
Console.WriteLine();

if (kratos.EstaVivo())
{
    Console.WriteLine("Kratos sigue con vida.");
}
else
{
    Console.WriteLine("Kratos fue derrotado.");
}

if (masterChief.EstaVivo())
{
    Console.WriteLine("Master Chief sigue con vida.");
}
else
{
    Console.WriteLine("Master Chief fue derrotado.");
}

if (doomSlayer.EstaVivo())
{
    Console.WriteLine("Doom Slayer sigue con vida.");
}
else
{
    Console.WriteLine("Doom Slayer fue derrotado.");
}

if (link.EstaVivo())
{
    Console.WriteLine("Link sigue con vida.");
}
else
{
    Console.WriteLine("Link fue derrotado.");
}

if (porDefecto.EstaVivo())
{
    Console.WriteLine("Personaje por defecto sigue con vida.");
}
else
{
    Console.WriteLine("Personaje por defecto fue derrotado.");
}
