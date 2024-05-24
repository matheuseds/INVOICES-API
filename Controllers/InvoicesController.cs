using INVOICES_API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace INVOICES_API.Controllers
{
    [ApiController]
    [Route("v1/Invoices")]
    [Authorize("Bearer")]
    public class InvoicesController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> Post(Invoices invoices)
        {
            ErrorResponse errorResponse = new ErrorResponse();
            errorResponse.error = new ErrorDetail();
            errorResponse.error.message = new ErrorMessage();

            try
            {
                var invoice = await Invoices.Create(invoices);

                return Created($"Invoices/{invoice.DocEntry}", invoice);
            }
            catch (Exception ex)
            {
                errorResponse.error.message.value = ex.Message;

                return BadRequest(errorResponse);
            }
        }

        //[HttpGet]
        //public async Task<IActionResult> GetAll()
        //{
        //    ErrorResponse errorResponse = new ErrorResponse();
        //    errorResponse.error = new ErrorDetail();
        //    errorResponse.error.message = new ErrorMessage();

        //    try
        //    {
        //        var invoices = await Invoices.GetAll();

        //        var formattedResponse = new
        //        {
        //            value = invoices
        //        };

        //        return Ok(formattedResponse);
        //    }
        //    catch (Exception ex)
        //    {
        //        errorResponse.error.message.value = ex.Message;

        //        return BadRequest(errorResponse);
        //    }
        //}

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var invoice = await Invoices.Get(id);

                if (invoice == null) return NotFound();

                return Ok(invoice);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> Patch(int id, Invoices invoice)
        {
            try
            {
                await Invoices.Patch(id, invoice);

                return NoContent();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
