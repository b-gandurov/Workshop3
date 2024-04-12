namespace Agency.Models.Contracts
{
    public interface ITrain:IHasId
    {
        int Carts { get; }
    }
}