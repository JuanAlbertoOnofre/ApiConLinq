using ApiConLinq.BL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ApiConLinq.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly OperationsBL _operationsBL;

        public ValuesController(OperationsBL operationsBL)
        {
            _operationsBL = operationsBL;
        }

        [HttpPost("mult")]
        public async Task<IActionResult> multiplicaionAsync(double num1, double num2) 
        {
            try
            {
                var (Status, result) = await _operationsBL.MultiplicarAsync(num1, num2);
                if (result != 0)
                    return Ok(result);
                return BadRequest();
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost("div")]
        public async Task<IActionResult> dividirAsync(double num1, double num2)
        {
            try
            {
                var (Status, result) = await _operationsBL.DividirAsync(num1, num2);
                if (result != 0)
                    return Ok(result);
                return BadRequest();
            }
            catch (Exception)
            {

                throw;
            }
        }


        [HttpPost("pares")]
        public async Task<IActionResult> paresAsync()
        {
            try
            {
                var (Status, result) = await _operationsBL.GetArrayParesAsync();
                if (result != null)
                    return Ok(result);
                return BadRequest();
            }
            catch (Exception)
            {

                throw;
            }
        }


        [HttpGet]
        public async Task<IActionResult> GetArray()
        {
            try
            {
                var (Status, result) = await _operationsBL.GetArryAsync();
                if (result != null)
                    return Ok(result);
                return BadRequest();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
