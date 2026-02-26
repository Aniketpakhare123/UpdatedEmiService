using InterestService.Application.DTO;
using InterestService.Application.Interfaces;
using InterestService.Repository.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace InterestService.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class EmiController : ControllerBase
  {

    IEmi emiservice;

    public EmiController(IEmi e) {
      emiservice = e;
    }

    [HttpPost("generate-emi")]
    public async Task<IActionResult> GenerateEmi([FromBody] EmiRequestDTO request)
    {
      var data =await emiservice.GenerateSchedule(request);
            var response = new ApiResponse<object>
            {
                Success = true,
                StatusCode = 200,
                Message = "Loan Schedule generated successfully",
                Data = data,
                Errors = null,
                Meta = new { Timestamp = DateTime.UtcNow }
            };
            return Ok(response);
    }

        [HttpGet("loan/{id}")]
        
        public async Task<IActionResult> GetEmiSchedule(int id)
        {
          var data = await emiservice.GetEmischedule(id);
            var response = new ApiResponse<object>
            {
                Success = true,
                StatusCode = 200,
                Message = "Emi Schedule fetched successfully",
                Data = data,
                Errors = null,
                Meta = new { Timestamp = DateTime.UtcNow }
            };
            return Ok(response);

        }


        [HttpGet("{loanId}")]
        public async Task<IActionResult> GetEmiSchedules(int loanId)
        {
            var data = await emiservice.GetEmiSchedule(loanId);
            var response = new ApiResponse<object>
            {
                Success = true,
                StatusCode = 200,
                Message = "Emi Schedule fetched successfully",
                Data = data,
                Errors = null,
                Meta = new { Timestamp = DateTime.UtcNow }
            };

            return Ok(response);
        }


    }
}
