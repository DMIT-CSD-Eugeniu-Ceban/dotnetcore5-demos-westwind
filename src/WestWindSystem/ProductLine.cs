using System;
using System.Collections.Generic;

namespace WestWindSystem
{
    public class ProductLine
    {
        #region Ex01a
        public Supplier Supplier { get; set; }
        
        public ProductLine(Supplier supplier)
        {
            Supplier = supplier;
            //Products = new List<Product>();
        }
        #endregion

        #region Ex01b
        public List<Product> Products { get; set; } = new();
        public int TotalProducts { get { return Products.Count; } }
        //using lambda syntax.
        //public int TotalProducts => Products.Count;
        public void AddProduct(Product product)
        {
            if (product == null)
                throw new ArgumentNullException(string.Empty,"No product supplied. Product not added.");
            bool found = false;
            foreach(Product existingProduct in Products)
                if (product.ProductName.Equals(existingProduct.ProductName))
                    found = true;
            if (found)
                throw new ArgumentException($"The product {product.ProductName} is already part of this product line. Product not added");
            Products.Add(product); 
        }

        public override string ToString()
       {
           return $"Total Number of Products: {TotalProducts}";
       }
        #endregion
    }
}