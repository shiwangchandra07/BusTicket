public class ElevatorSystem
{
    private readonly List<Elevator> elevators;

    // Dependency is injected through constructor.
    // This is an example of Dependency Injection.
    private readonly IElevatorSelectionStrategy selectionStrategy;

    public ElevatorSystem(
        List<Elevator> elevators,
        IElevatorSelectionStrategy selectionStrategy)
    {
        this.elevators = elevators;
        this.selectionStrategy = selectionStrategy;
    }

    // Displays all elevators.
    public void ShowElevators()
    {
        Console.WriteLine("\n===== ELEVATOR STATUS =====");

        foreach (var elevator in elevators)
        {
            Console.WriteLine(elevator);
        }

        Console.WriteLine("===========================\n");
    }

    // Handles an external UP/DOWN request.
    public void RequestElevator(
        int floor,
        Direction direction)
    {
        var request = new ElevatorRequest(
            floor,
            direction
        );

        Console.WriteLine(
            $"\nRequest received at Floor {floor} : {direction}"
        );

        // Ask the strategy to select an elevator.
        Elevator selectedElevator =
            selectionStrategy.SelectElevator(
                elevators,
                request
            );

        Console.WriteLine(
            $"Elevator {selectedElevator.Id} selected."
        );

        // Send elevator to requested floor.
        selectedElevator.AddRequest(floor);

        selectedElevator.ProcessRequests();
    }

    // Handles a passenger selecting a destination
    // after entering an elevator.
    public void SelectFloor(
        int elevatorId,
        int destinationFloor)
    {
        Elevator? elevator =
            elevators.FirstOrDefault(
                e => e.Id == elevatorId
            );

        if (elevator == null)
        {
            Console.WriteLine("Elevator not found.");
            return;
        }

        Console.WriteLine(
            $"\nPassenger inside Elevator {elevatorId} selected Floor {destinationFloor}."
        );

        elevator.AddRequest(destinationFloor);

        elevator.ProcessRequests();
    }
}