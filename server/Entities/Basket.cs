using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;

namespace server.Entities
{
    public class Basket
    {
        public int Id { get; set; }
        public string BuyerId { get; set; }
        public List<BasketItem> Items { get; set; } = new List<BasketItem>();

        public void AddItem(Product product, int quantity)
        {
            if (Items.All(item => item.ProductId != product.Id))
            {
                Items.Add(new BasketItem{Product = product, Quantity=quantity});
                return;
            }
            var existingItem = Items.FirstOrDefault(item => item.ProductId == product.Id);
            if(existingItem !=null) existingItem.Quantity += quantity;
        }
        public void RemoveItem(int productId, int quantity)
        {
            var existingItem = Items.FirstOrDefault(item=> item.ProductId == productId);
            if (existingItem == null) return;
            existingItem.Quantity -=quantity;
            if(existingItem.Quantity <= 0) Items.Remove(existingItem);
        }

        internal void RemoveItem(Product product, int quantity)
        {
            throw new NotImplementedException();
        }
    }
}