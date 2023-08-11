namespace LinQJson.Entities;
    public class Producto
    {
        private string idProducto;
        private string nombreProducto;
        private int stock;
        private int stockMin;
        private int stockMax;
        private double valorVenta;
        private double valorCompra;
        private int idCategorias;

        public Producto(){
            if(!File.Exists(Env.FileName)){
                File.WriteAllText(Env.FileName, "");
            }
        }

        public string IdProducto 
        {
            get{return idProducto;}
            set{idProducto = value;}
        }
        public string NombreProducto
        {
            get{return nombreProducto;}
            set{nombreProducto = value;}
        }
        public int Stock
        {
            get{return stock;}
            set{stock = value;}
        }
        public int StockMin
        {
            get{return stockMin;}
            set{stockMin = value;}
        }
        public int StockMax
        {
            get{return stockMax;}
            set{stockMax = value;}
        }
        public double ValorVenta
        {
            get{return valorVenta;}
            set{valorVenta = value;}
        }
        public double ValorCompra
        {
            get{return valorCompra;}
            set{valorCompra = value;}
        }
        public int IdCategorias
        {
            get{return idCategorias;}
            set{idCategorias = value;}
        }

        public void AddProducto(){

            Producto producto= new Producto();

            Console.WriteLine("Ingrese Id del producto: ");
            producto.IdProducto = Console.ReadLine()!;

            Console.WriteLine("Ingrese nombre del producto: ");
            producto.NombreProducto = Console.ReadLine()!;

            Console.WriteLine("Ingrese stock del producto: ");
            producto.Stock = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Ingrese el stock minimo del producto: ");
            producto.StockMin = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Ingrese el stock maximo del producto: ");
            producto.StockMax = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Ingrese el valor de venta del producto: ");
            producto.ValorVenta = double.Parse(Console.ReadLine()!);

            Console.WriteLine("Ingrese el valor de compra del producto: ");
            producto.ValorCompra = double.Parse(Console.ReadLine()!);

            Console.WriteLine("Ingrese la categoria del producto: ");
            producto.IdCategorias = int.Parse(Console.ReadLine()!);            
        }
    }
