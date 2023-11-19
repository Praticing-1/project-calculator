using StoreCalculatorResult.Entities;
using StoreCalculatorResult.Interfaces;


namespace StoreCalculatorResult.Repositories
{
    public class DataRepository : IDataRepository
    {
        private readonly Database.DatabaseContext _context;
        public DataRepository(Database.DatabaseContext context) => _context = context;
        public async Task InsertDataAsync(Data model){
            await _context.AddAsync(model);
            _context.SaveChanges();
        }
    }
}