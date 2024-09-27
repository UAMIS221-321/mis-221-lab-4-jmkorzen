RouteEm(Menu());







static string Menu()
{
    System.Console.WriteLine("Enter 1 to display a plain topping-less pizza slice\nEnter 2 to display cheese pizza slice");
    System.Console.WriteLine("Enter 3 to display pepperoni pizza slice\nEnter 4 to exit");
    return System.Console.ReadLine();
}

static void RouteEm(string choice)
{
    switch(choice)
    {
        case "1":
            ToppingLess();
            break;
        case "2":
            Cheese();
            break;
        case "3":
            Pepperoni();
            break;
        case "4":
            Exit();
            break;
        default:
            BadInput();
            break;
    }
}

static void ToppingLess()
{
    Random rand = new Random();
    int randRows = rand.Next(8,13);
    System.Console.WriteLine(randRows);
    for(int i = randRows; i > 0; i--)
    {
        for(int j = 0; j<i;j++)
        {
            System.Console.Write("*\t");
        }
        System.Console.WriteLine();
    }
}

static void Cheese()
{
    Random rand = new Random();
    int randRows = rand.Next(8,13);
    System.Console.WriteLine(randRows);
    for(int i = randRows; i > 0; i--)
    {
        System.Console.Write("*\t");
        for(int j = 1; j<i;j++)
        {
            if(i==randRows)
            {
                System.Console.Write("*\t");
            }
            else if(j==i-1)
            {
                System.Console.Write("*\t");
            }
            else
            {
            System.Console.Write("#\t");
            }
        }
        System.Console.WriteLine();
    }
}

static void Pepperoni()
{
    Random rand = new Random();
    int randRows = rand.Next(8,13);
    System.Console.WriteLine(randRows);
    for(int i = randRows; i > 0; i--)
    {
        System.Console.Write("*\t");
        for(int j = 1; j<i;j++)
        {
            if(i==randRows)
            {
                System.Console.Write("*\t");
            }
            else if(j==i-1)
            {
                System.Console.Write("*\t");
            }
            else
            {
                Random random = new Random();
                int pep = random.Next(0,5);
                if(pep == 0)
                {
                    System.Console.Write("[]\t");
                }
                else
                {
                System.Console.Write("#\t");
                }
            }
        }
        System.Console.WriteLine();
    }
}

static void Exit()
{
    System.Console.WriteLine("Program exited");
}

static void BadInput()
{
    System.Console.WriteLine("Invalid choice");
    RouteEm(Menu());
}