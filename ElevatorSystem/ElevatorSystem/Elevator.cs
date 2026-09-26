public enum ElevatorState
{
    Idle,
    Moving,
    DoorOpen
}

public class Elevator
{
    // Private fields protect the internal state of the elevator
    private readonly List<int> requestedFloors = new();
    public int Id { get; }

    public int CurrentFloor { get; private set; }

    public ElevatorState State { get; private set; }

    public Elevator(int id , int startingFloor)
    {
        Id = id;
        CurrentFloor = startingFloor;
        State = ElevatorState.Idle;

    }
    // add a destination floor to this elevator.
    public void Addrequest(int floor)
    {
        if(floor < 1)
        {
            Console.WriteLine("Invalid floor");
            return;
        }

        if (!requestedFloors.Contains(floor))
        {
            requestedFloors.Add(floor);
            Console.WriteLine(
                $"Elevator {Id} : Floor {floor} added to request."
                );
        }
    }

    // Move the elvator and process all request floors.
    public void ProcessRequests()
    {
        while (requestedFloors.Count > 0)
        {
            // Take the first requested floor.
            int destination = requestedFloors[0];

            MoveToFloor(destination);

            OpenDoor();

            CloseDoor();

            // Remove completed request.
            requestedFloors.RemoveAt(0);
        }
        State = ElevatorState.Idle;

        Console.WriteLine(
             $"Elevator {Id} is now IDLE at floor {CurrentFloor}."
            );
    }

    private void MoveToFloor(int destination)
    {
        State = ElevatorState.Moving;

        Console.WriteLine(
            $"Elevator {Id} moving from floor {CurrentFloor} to floor {destination}..."
            );
        while (CurrentFloor != destination)
        {
            if(CurrentFloor != destination)
            {
                CurrentFloor++;
            }
            else
            {
                CurrentFloor--;
            }
            Console.WriteLine(
                $"Elevator {Id} -> Floor {CurrentFloor}"
                );
            //only for simulation purpose .
            Thread.Sleep(300);
        }
    }

    private void OpenDoor()
    {
        State = ElevatorState.DoorOpen;

        Console.WriteLine(
            $"Elevator {Id}: Door OPEN at floor {CurrentFloor}."
            );
        Thread.Sleep(500);

    }

    private void CloseDoor()
    {
        Console.WriteLine(
             $"Elevator {Id}: Door CLOSED."
            );

        Thread.Sleep(500);
    }

    // calcuilates how far the elevator is from a floor .
    public int DistanceFrom(int floor)
    {
        return Math.Abs(CurrentFloor - floor);
    }

    public override string ToString()
    {
        return $"Elevator {Id} | Floor: {CurrentFloor} | State: {State}";
    }
}