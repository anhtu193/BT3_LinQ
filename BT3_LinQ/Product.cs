using System;

public class Product
{
    public string ProductID { get; set; }
    public string Name { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public string Origin { get; set; }
    public DateTime ExpiryDate { get; set; }

    public Product(string productID, string name, int quantity, decimal unitPrice, string origin, DateTime expiryDate)
    {
        ProductID = productID;
        Name = name;
        Quantity = quantity;
        UnitPrice = unitPrice;
        Origin = origin;
        ExpiryDate = expiryDate;
    }
}
