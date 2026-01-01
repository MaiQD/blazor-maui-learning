using Microsoft.EntityFrameworkCore;

namespace BlazingPizza.Data;

public class PizzaStoreContext : DbContext
{
    public PizzaStoreContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Order> Orders { get; set; }

    public DbSet<BlazingPizza.Pizza> Pizzas { get; set; }
    public DbSet<PizzaSpecial> PizzaSpecials { get; set; }
    
    public DbSet<Topping> Toppings { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<PizzaTopping>().HasKey(pt => new { pt.PizzaId, pt.ToppingId });
        modelBuilder.Entity<PizzaTopping>().HasOne<BlazingPizza.Pizza>().WithMany(ps => ps.Toppings);
        modelBuilder.Entity<PizzaTopping>().HasOne(pst => pst.Topping).WithMany();


    }
}