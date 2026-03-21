string[] productName = new string[10];
int[] productStocks = new int[10];

int count = 0;

while (true)
{
    Console.WriteLine("\n\n1. Add Product");
    Console.WriteLine("2. View All");
    Console.WriteLine("3. Search One");
    Console.WriteLine("4. Update");
    Console.WriteLine("5. Delete");
    Console.WriteLine("6. Exit");

    Console.Write("Choice: ");
    int choice = Convert.ToInt32(Console.ReadLine());

    // Add Product
    if (choice == 1)
    {
        if (count < productName.Length)
        {
            Console.WriteLine("\nAdd Product");
            Console.Write("Enter a product name: ");
            productName[count] = Console.ReadLine();

            Console.Write("Enter Stock: ");
            productStocks[count] = int.Parse(Console.ReadLine());

            count++;
        }
        else
        {
            Console.WriteLine("Storage is full.");
        }
    }

    // View All Products
    if (choice == 2)
    {
        Console.WriteLine("\nView Products");
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"Product: {productName[i]} - Stock: {productStocks[i]}");
        }
    }

    // Search one product
    if (choice == 3)
    {
        Console.WriteLine("\nSearch Product");
        Console.Write("Enter product name to search: ");
        string search = Console.ReadLine();

        bool found = false;

        for (int i = 0; i < count; i++)
        {
            if (productName[i].ToLower() == search.ToLower())
            {
                Console.WriteLine($"Product name: {productName[i]} - Stocks {productStocks[i]}");

                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Product not found!");
        }
    }


    // Update Products
    if (choice == 4)
    {
        Console.WriteLine("\nUpdate Stock");
        Console.Write("Enter product name to update: ");
        string search = Console.ReadLine();

        bool found = false;

        for (int i = 0; i < count; i++)
        {
            if (productName[i].ToLower() == search.ToLower())
            {
                Console.Write("Enter new stock: ");
                productStocks[i] = int.Parse(Console.ReadLine());

                Console.Write("Stocks updated!");
                found = true;

                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Product not found!");
        }
    }

    if (choice == 5)
    {
        Console.WriteLine("\nDelete Product");
        Console.Write("Enter product name to delete: ");
        string search = Console.ReadLine();

        bool found = false;

        for (int i = 0; i < count; i++)
        {
            if (productName[i].ToLower() == search.ToLower())
            {
                // Shift all items after i one index left
                for (int j = i; j < count - 1; j++)
                {
                    productName[j] = productName[j + 1];
                    productStocks[j] = productStocks[j + 1];
                }

                // Optional: clear last slot
                productName[count - 1] = null;
                productStocks[count - 1] = 0;

                count--; // reduce the count
                found = true;
                Console.WriteLine("Product deleted.");
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Product not found.");
        }
    }

    if (choice == 6)
    {
        break;
    }
}

