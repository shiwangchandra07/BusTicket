class Program
{
    static void Main()
    {
        Console.WriteLine("=================================");
        Console.WriteLine("       ELEVATOR SYSTEM");
        Console.WriteLine("=================================");

        // Create multiple elevators.
        var elevators = new List<Elevator>
        {
            new Elevator(1, 1),
            new Elevator(2, 5),
            new Elevator(3, 10)
        };

        // Create the strategy.
        IElevatorSelectionStrategy strategy =
            new NearestElevatorStrategy();

        // Dependency Injection:
        // ElevatorSystem receives its dependencies
        // instead of creating them internally.
        var elevatorSystem =
            new ElevatorSystem(
                elevators,
                strategy
            );

        bool running = true;

        while (running)
        {
            Console.WriteLine("\n===== MENU =====");

            Console.WriteLine("1. Show Elevators");

            Console.WriteLine("2. Request Elevator");

            Console.WriteLine("3. Select Destination Floor");

            Console.WriteLine("4. Exit");

            Console.Write("Enter choice: ");

            string? input = Console.ReadLine();

            switch (input)
            {
                case "1":

                    elevatorSystem.ShowElevators();

                    break;

                case "2":

                    Console.Write("Enter current floor: ");

                    int floor =
                        int.Parse(Console.ReadLine()!);

                    Console.Write("Enter direction (up/down): ");

                    string directionInput =
                        Console.ReadLine()!.ToLower();

                    Direction direction;

                    if (directionInput == "up")
                    {
                        direction = Direction.Up;
                    }
                    else
                    {
                        direction = Direction.Down;
                    }

                    elevatorSystem.RequestElevator(
                        floor,
                        direction
                    );

                    break;

                case "3":

                    Console.Write("Enter elevator ID: ");

                    int elevatorId =
                        int.Parse(Console.ReadLine()!);

                    Console.Write("Enter destination floor: ");

                    int destination =
                        int.Parse(Console.ReadLine()!);

                    elevatorSystem.SelectFloor(
                        elevatorId,
                        destination
                    );

                    break;

                case "4":

                    running = false;

                    Console.WriteLine(
                        "Elevator System shutting down..."
                    );

                    break;

                default:

                    Console.WriteLine(
                        "Invalid choice."
                    );

                    break;
            }
        }
    }
}
