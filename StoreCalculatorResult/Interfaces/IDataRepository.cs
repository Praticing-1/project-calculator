using StoreCalculatorResult.Entities;

namespace StoreCalculatorResult.Interfaces
{
    public interface IDataRepository
    {
        Task InsertDataAsync(Data data);
    }
}