using InventoryService.DTO.Request;
using InventoryService.DTO.Response;
using InventoryService.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Principal;

namespace InventoryService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly IInventoryService _inventoryService;

        public InventoryController(IInventoryService inventoryService)
        {
            _inventoryService = inventoryService;
        }

        [HttpPost("reserve")]
        public async Task<ActionResult<CarReserveResponse>> ReserveCar([FromBody] CarReserveRequest request)
        {
            var result = await _inventoryService.ReserveAsync(request);
            return Ok(result);
        }

        [HttpPost("realese")]
        public async Task<ActionResult<CarReleaseResponse>> RealeseCar([FromBody] CarReleaseRequest request)
        {
            var result = await _inventoryService.ReleaseAsync(request);
            return Ok(result);
        }

        [HttpPost("mark-sold")]
        public async Task<ActionResult<CarMarkSoldResponse>> MarkSoldCar([FromBody] CarMarkSoldRequest request)
        {
            var result = await _inventoryService.MarkSoldAsync(request);
            return Ok(result);
        }

        [HttpGet("available")]
        public async Task<ActionResult<AvailableResponse>> GetAvailableCars([FromQuery] CarAvailableRequest request)
        {
            var result = await _inventoryService.AvailableAsync();
            return Ok(result);          
        }

        [HttpGet("{carId}")]
        public async Task<ActionResult<CarInformationResponse>> GetCarInformation(Guid carId)
        {
            var request = new CarInformationRequest (carId);
            var result = await _inventoryService.InformationAsync(request);
            return Ok(result);
        }
        //- POST /api/inventory/reserve - резервирование автомобиля
        //- POST /api/inventory/release - освобождение резервирования
        //- POST /api/inventory/mark-sold - отметка о продаже
        //- GET /api/inventory/available - список доступных автомобилей
        //- GET /api/inventory/{carId} - информация по конкретному автомобилю
    }
}


//        [HttpPost]
//        public async Task<ActionResult> CreateAccount([FromBody] AccountCreateCommand command, CancellationToken token)
//        {
//            var response = await _mediator.Send(command, token);
//            if (response.IsFailure)
//            {
//                return BadRequest(response.Error);
//            }
//            return Ok();
//        }

//        [HttpDelete("{id}")]
//        public async Task<ActionResult> DeleteAccount(Guid id)
//        {
//            var command = new AccountDeleteCommand(id);
//            var response = await _mediator.Send(command);
//            if (response.IsFailure)
//            {
//                return BadRequest(response.Error);
//            }
//            return Ok(response);
//        }

//        [HttpPut]
//        public async Task<ActionResult> UpdateAccount([FromBody] AccountUpdateCommand command, CancellationToken token)
//        {
//            var response = await _mediator.Send(command);
//            if (response.IsFailure)
//            {
//                return BadRequest(response.Error);
//            }
//            return Ok(response);
//        }

//        [HttpGet]
//        public async Task<ActionResult<List<Account>>> GetAllAccount(CancellationToken token)
//        {
//            var request = new AccountGetAllQueries();
//            var response = await _mediator.Send(request, token);
//            if (response.IsFailure)
//            {
//                return BadRequest(response.Error);
//            }
//            return Ok(response.Value);
//        }

//        [HttpGet("customer/{id}")]
//        public async Task<ActionResult<Account>> GetByCustomerIdAccount(Guid id)
//        {
//            var request = new AccountGetByCustomerIdQueries(id);
//            var response = await _mediator.Send(request);
//            if (response.IsFailure)
//            {
//                return BadRequest(response.Error);
//            }
//            return Ok(response.Value);
//        }

//        [HttpGet("account/{id}")]
//        public async Task<ActionResult<Account>> GetByIdAccount(Guid id)
//        {
//            var request = new AccountGetByIdQueries(id);
//            var response = await _mediator.Send(request);
//            if (response.IsFailure)
//            {
//                return BadRequest(response.Error);
//            }
//            return Ok(response.Value);
//        }

//        [HttpGet("transactions/{accountId}")]
//        public async Task<ActionResult<List<Transaction>>> GetTransactionById(Guid accountId)
//        {
//            var request = new GetTransactionByIdQueries(accountId);
//            var response = await _mediator.Send(request);
//            if (response.IsFailure)
//            {
//                return BadRequest(response.Error);
//            }
//            return Ok(response.Value);
//        }
//    }
//}