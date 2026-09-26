public interface IElevatorSelectionStrategy
{
    Elevator SelectElevator(
        List<Elevator> elavtor,
        ElevatorRequest request
        );
}