// See https://aka.ms/new-console-template for more information


Animal animal1Persona1 = new Animal("perro", "Firulais");
Animal animal2Persona1 = new Animal("gato", "Garfiel");
Persona persona1 = new Persona(20, "Jose", "correo1@gmail.com", new List<Array>());

Persona persona2 = new Persona(21, "Luis", "correo2@gmail.com", new List<Array>());

Persona persona3 = new Persona(16, "Carlos", "correo3@gmail.com", new List<Array>());

persona2.gardarCorreo("nuevocorreo@gmail.com");
List<Persona> ListaPersonas = new List<Persona>()
{
    persona1, persona2, persona3
};

persona Persona4 = new persona(23, "Pepe", "prueba1@gmail.com", new List<Array>());

ListaPersonas.Add(Persona4);

ListaPersonas.RemoveAt(3);
ListaPersonas.Remove(Persona4);

foreach (Persona item in ListaPersonas)
{
    Console.WriteLine("===============================================");
    Console.WriteLine(item.obtenerDescripcion());

    try
    {
        char letra = item.obtenerNombre()[4];
        int.Parse(letra.ToString());
        Console.WriteLine($"La 5 letras es: {letra}");
    }
}


//Propiedades de metodos por defecto
/*List<int> listaNumeros = new List<int>(){
 * 4,
 * 3,
 * 5,
 * }
 
--Agregar elementos
listaNumeros.Add(1);

--Eliminar elemento por su indice
listaNumeros.RemoveAt(2);

--Eliminar elementos
listaNumeros.Remove(4);
 
 */