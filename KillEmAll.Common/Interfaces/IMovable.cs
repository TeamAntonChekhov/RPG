namespace KillEmAll.Common
{
    public interface IMovable
    {
        Location Location { get; }
        void GoTo(Location location);
    }
}
