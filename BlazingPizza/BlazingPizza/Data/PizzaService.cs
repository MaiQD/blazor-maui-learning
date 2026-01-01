namespace BlazingPizza.Data;

public class PizzaService
{
    public Task<Pizza[]> GetPizzasAsync()
    {
        // Call your data access technology here
        Pizza[] pizzas = new Pizza[]
        {
            new Pizza
            {
                PizzaId = 1,
                Name = "Margherita",
                Description = "Tomato sauce, fresh mozzarella, and basil",
                Price = 8.50m,
                Vegetarian = true,
                Vegan = false
            },
            new Pizza
            {
                PizzaId = 2,
                Name = "Pepperoni",
                Description = "Tomato sauce, mozzarella, and pepperoni",
                Price = 9.50m,
                Vegetarian = false,
                Vegan = false
            },
            new Pizza
            {
                PizzaId = 3,
                Name = "Veggie Delight",
                Description = "Tomato sauce, bell peppers, onions, mushrooms, and olives",
                Price = 9.00m,
                Vegetarian = true,
                Vegan = true
            }
        };
        return Task.FromResult(pizzas);
    }
}