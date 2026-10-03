public class Personaje
{
    private string nombre;
    private int vida;
    private int nivel;
    private int ataque;

    public Personaje()
    {
        this.nombre = "Personaje por defecto";
        this.vida = 100;
        this.nivel = 1;
        this.ataque = 10;
    }

    public Personaje(string nombre)
    {
        this.nombre = nombre;
        this.vida = 100;
        this.nivel = 1;
        this.ataque = 10;
    }

    public Personaje(string nombre, int vida, int nivel, int ataque)
    {
        this.nombre = nombre;
        this.vida = vida;
        this.nivel = nivel;
        this.ataque = ataque;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine(nombre);
        Console.WriteLine($"Vida: {vida}");
        Console.WriteLine($"Nivel: {nivel}");
        Console.WriteLine($"Ataque: {ataque}");
        Console.WriteLine();
    }

    public void RecibirDanio(int cantidad)
    {
        vida = vida - cantidad;

        if (vida < 0)
        {
            vida = 0;
        }

        Console.WriteLine($"{nombre} recibió {cantidad} puntos de daño.");
    }

    public void Curar(int cantidad)
    {
        vida = vida + cantidad;
        Console.WriteLine($"{nombre} recuperó {cantidad} puntos de vida.");
    }

    public void SubirNivel()
    {
        nivel = nivel + 1;
        ataque = ataque + 5;
        Console.WriteLine($"{nombre} subió de nivel.");
    }

    public void Atacar(Personaje enemigo)
    {
        Console.WriteLine($"{this.nombre} atacó a {enemigo.nombre}.");
        enemigo.RecibirDanio(this.ataque);
    }

    public int ObtenerVida()
    {
        return vida;
    }

    public bool EstaVivo()
    {
        if (vida > 0)
        {
            return true;
        }

        return false;
    }
}
