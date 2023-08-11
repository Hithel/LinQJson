namespace LinQJson.View;
    public class MenusView
    {
        public static int MenuPrincipal(){
            Console.Clear();

            Console.WriteLine("1. Registro de productos");
            Console.WriteLine("2. Registro de categorias");
            Console.WriteLine("3. salir");
            return int.Parse(Console.ReadLine()!);
        }
    }
