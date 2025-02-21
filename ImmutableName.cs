public class ImmutableName
{
    public string Name { get; }

    public ImmutableName(string name)
    {
        Name = name;
    }
}
/*
    How would you make name inmutable?:

    Propiedad de solo lectura: La propiedad Name está definida 
    con solo un get, lo que significa que no tiene un set y, 
    por lo tanto, no puede ser modificada después de ser asignada.

    Constructor: El valor de Name se asigna en el constructor de 
    la clase. Una vez que se crea una instancia de ImmutableName, 
    el valor de Name no puede cambiar.

    var immutableName = new ImmutableName("John");
    Console.WriteLine(immutableName.Name); > Salida: John

    immutableName.Name = "Doe"; > Esto causaría un error de compilación porque Name es de solo lectura
*/