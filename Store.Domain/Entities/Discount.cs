using System;

namespace Store.Domain.Entities 
{
    public class Discount : Entity
    {
        public Discount(decimal amount, DateTime expireDate)
        {
            Amount = amount;
            ExpireDate = expireDate;
        }
        public decimal Amount { get; private set; }
        public DateTime ExpireDate { get; private set; }

        /* Abaixo, método para validar o cupom,
           Se a data estiver válida, ele aplica o desconto.
           Caso contrário ele não valida o cupom. 
           
           Com esse método abaixo, podemos criar testes, 
           de cupons nulos ou que vem sem dados.
        */
        public bool IsValid()
        {
            return DateTime.Compare(DateTime.Now, ExpireDate) < 0;
        }
        public decimal Value()
        {
            if (IsValid())
                return Amount;
            else
                return 0;
        }
    }
}