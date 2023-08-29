class Product {
    public string name;
    public string info;
    public int quantity;
    public bool premium;


    public void ShowProductDetails()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Info: {info}");
        Console.WriteLine($"Quantity: {quantity}");

        if (premium)
        {
            Console.WriteLine($"It's only avaliable for members!");
        }
    }
}
