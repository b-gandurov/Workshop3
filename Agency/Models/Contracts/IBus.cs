namespace Agency.Models.Contracts
{
    public interface IBus :IHasId
    {
        bool HasFreeTv { get; }
    }
}