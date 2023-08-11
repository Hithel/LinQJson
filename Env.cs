using System.Dynamic;
using LinQJson.Entities;

namespace LinQJson;
public static class Env
{
    private static string fileName = "tiendaCampus.json";
    private static TiendaCampus tiendaCampus = new TiendaCampus();

    public static string FileName
    {
        get => fileName;
        set => fileName = value;
    }

    public static TiendaCampus TiendaCampus
    {
        get => tiendaCampus;
        set => tiendaCampus = value;
    }

    public static void LoadDataProductos(string nombreArchivo)
    {
        using (StreamReader reader = new StreamReader(nombreArchivo))
        {
            string json = reader.ReadToEnd();
            Env.TiendaCampus = System.Text.Json.JsonSerializer.Deserialize<TiendaCampus>(json, new System.Text.Json.JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true
            }) ?? new TiendaCampus();
        }
    }
    public static bool ValidarFile(string fileName)
    {
        if (!File.Exists(fileName))
        {
            return false;
        }
        return true;
    }

    public static void ImprimirData<T>(string titulo, IEnumerable<T> lista)
    {
        Console.WriteLine("{0,-30}", titulo);
        foreach (var item in lista)
        {
            Type tipoClase = item.GetType();
            var propiedades = tipoClase.GetProperties();

            foreach (var prop in propiedades)
            {
                Console.WriteLine($"{prop.Name}: {prop.GetValue(item)}");
            }
            Console.ForegroundColor = ConsoleColor.Blue;
        }
        Console.ReadKey();
    }
}
