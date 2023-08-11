namespace LinQJson.Entities;
    public class Categoria
    {
        private int id;
        private string descripcion;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Descripcion 
        {
            get { return descripcion; }
            set { descripcion = value;}
        }

        public static void AddCategoria(){
            
            Categoria categoria= new Categoria();

            Console.WriteLine("Ingrese el Id de la categoria: ");
            categoria.Id = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Ingrese la descripcion de la categoria: ");
            categoria.Descripcion = Console.ReadLine()!;

            Console.WriteLine(categoria);

            Env.TiendaCampus.Categorias.Add(categoria);
        }
        public IEnumerable<Categoria> listaCategorias(){
            return from categoria in Env.TiendaCampus.Categorias
            select categoria;
        }
    }
