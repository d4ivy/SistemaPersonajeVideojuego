# Sistema de Personajes de Videojuego

Ejercicio de Programación Orientada a Objetos en C#. Una clase `Personaje` representa a los personajes de un videojuego de combate, y el programa principal simula una batalla breve entre ellos.

## Requisitos

- [.NET SDK 8](https://dotnet.microsoft.com/download) o superior

## Cómo ejecutarlo

```bash
dotnet run
```

## Estructura

| Archivo | Contenido |
|---|---|
| `Personaje.cs` | Clase con los atributos nombre, vida, nivel y ataque; tres constructores y los métodos `MostrarInformacion`, `RecibirDanio`, `Curar`, `SubirNivel`, `Atacar`, `ObtenerVida` y `EstaVivo`. |
| `Program.cs` | Crea cinco personajes con los tres constructores, simula la batalla y comprueba con `EstaVivo()` quién sigue con vida. |

## Conceptos aplicados

Clases, objetos, atributos, métodos con parámetros y con retorno, sobrecarga de constructores, `this`, creación de objetos con `new` y cambio del estado de un objeto.

## Autor

Jesus David Castro Buelvas
