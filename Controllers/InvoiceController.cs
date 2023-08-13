using CQRS_PipelineBehaviour.Features.InvoiceFeature.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CQRS_PipelineBehaviour.Controllers;

[Route("api/[controller]")]
[ApiController]
public class InvoiceController : ControllerBase
{
    private IMediator _mediator;

    protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();


    [HttpPost]
    public async Task<IActionResult> Create(CreateInvoiceCommand command)
    {
        return Ok(await Mediator.Send(command));
    }


    // GET: api/<InvoiceController>
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] { "value1", "value2" };
    }

    // GET api/<InvoiceController>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }



    // PUT api/<InvoiceController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<InvoiceController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
