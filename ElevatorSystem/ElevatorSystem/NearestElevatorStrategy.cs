public class NearestElevatorStrategy : IElevatorSelectionStrategy
{
    public Elevator SelectElevator(
        List<Elevator> elevators,
        ElevatorRequest request
        )
    {
        Elevator? nearestElevator = null;

        int minimumDistance = int.MaxValue;

        foreach(var elevator in elevators)
        {
            // we prefer idle elevators.
            if (elevator.State != ElevatorState.Idle)
                continue;
            int distance = elevator.DistanceFrom(request.Floor);

            if(distance < minimumDistance)
            {
                minimumDistance = distance;
                nearestElevator = elevator;
            }
        }

        return nearestElevator!;
    }
}