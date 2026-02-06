using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProdutctAPI.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext(){}
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options){}
        public DbSet<Product> Products { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 5,
                    Name = "Caderno",
                    Price = new decimal(19.90),
                    Description = "Caderno de 100 folhas",
                    CategoryName = "Material Escolar",
                    ImageUrl = "https://m.media-amazon.com/images/I/61n9s+qj8eL._AC_SX679_.jpg"
                },
                new Product
                {
                    Id = 6,
                    Name = "Caneta",
                    Price = new decimal(5.90),
                    Description = "Caneta esferográfica azul",
                    CategoryName = "Material Escolar",
                    ImageUrl = "https://m.media-amazon.com/images/I/61n9s+qj8eL._AC_SX679_.jpg"
                },
                new Product
                {
                    Id = 7,
                    Name = "Mochila",
                    Price = new decimal(99.90),
                    Description = "Mochila resistente para o dia a dia",
                    CategoryName = "Acessórios",
                    ImageUrl = "https://m.media-amazon.com/images/I/61n9s+qj8eL._AC_SX679_.jpg"
                }
            );
        }
    }
}
