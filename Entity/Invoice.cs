namespace CQRS_PipelineBehaviour.Entity;

public class Invoice
{
    public int InvoiceId { get; set; }
    public string? InvoiceDate { get; set; }
    public string? Barcode { get; set; }
    public bool IsActive { get; set; }
    public string? Description { get; set; }
    public int Discount { get; set; }
    public int Total { get; set; }
}
