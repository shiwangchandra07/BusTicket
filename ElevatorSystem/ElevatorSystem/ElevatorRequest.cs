// represent the direction in which the passanger want to travel
public enum Direction
{
    Up,
    Down,
}

//represent a request made by a passanger
public class ElevatorRequest
{
    public int Floor { get; }

    public Direction Direction { get; }

    // constructor 
    public ElevatorRequest(int floor, Direction direction)
    {
        Floor = floor;
        Direction = direction;
    }
}
