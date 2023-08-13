using CQRS_PipelineBehaviour.Entity;
using MediatR;
using Microsoft.AspNetCore.SignalR;

namespace CQRS_PipelineBehaviour.Features.InvoiceFeature.Commands;

public class CreateInvoiceCommand : IRequest<int>
{
    public string? InvoiceDate { get; set; }
    public string? Barcode { get; set; }
    public string? Description { get; set; }
    public int Discount { get; set; }
    public int Total { get; set; }

    public class CreateInvoiceCommandHandler : IRequestHandler<CreateInvoiceCommand, int>
    {
        public CreateInvoiceCommandHandler()
        {
            
        }
        public async Task<int> Handle(CreateInvoiceCommand command, CancellationToken cancellationToken)
        {
            //huh ?
            //_logger.LogInformation($"Handling CreateInvoiceCommand");

            var invoice = new Invoice();
            invoice.Barcode = command.Barcode;
            invoice.Description = command.Description;
            invoice.Discount = command.Discount;
            invoice.Total = command.Total;
            invoice.InvoiceDate = command.InvoiceDate;
            //DBContext Actions like SaveChanges
            await Task.CompletedTask;
            return invoice.InvoiceId;
        }
    }
}