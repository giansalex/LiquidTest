using DotLiquid;

namespace LiquidEngine
{
    /// <summary>
    /// Producto.
    /// </summary>
    public class Product : Drop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
