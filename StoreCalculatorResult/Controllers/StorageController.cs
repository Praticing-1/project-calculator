using Microsoft.AspNetCore.Mvc;
using StoreCalculatorResult.Dtos;
using StoreCalculatorResult.Interfaces;

namespace StoreCalculatorResult.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StorageController : ControllerBase
    {

        private readonly IDataRepository _repository;

        public StorageController(IDataRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(
            [FromBody] CreateDataDto model
         )
        {
            await _repository.InsertDataAsync(new Entities.Data(model.data));
            return Accepted();
        }
    }
}