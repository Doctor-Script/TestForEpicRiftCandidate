namespace Core
{
    public interface ISpendable
    {
        void Spend();
        bool IsEnough();
    }
}
