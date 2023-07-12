namespace Store.Domain.Entities
{
    public class Product : Entity
    {
        public Product(string title, decimal price, bool active)
        {
            this.Title = title;
            this.Price = price;
            this.Active = active;
        }

        public string Title { get; private set; }
        public decimal Price { get; private set; }
        public bool Active { get; private set; }

        /* public void ChangeInfo(string title, decimal price, bool active) // <-- Caso precisar modificar alguma informação, pois minhas propriedades estão privadas.
        {
            this.Title = title;
            this.Price = price;
            this.Active = active;
        } */
    }
}