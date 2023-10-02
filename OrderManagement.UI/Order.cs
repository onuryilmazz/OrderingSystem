using System;

public sealed class Order
{
    public Guid OrderId { get; set; }

    public string ItemName { get; set; } = default!;

    public string CustomerName { get; set; } = default!;

    public decimal Amount { get; set; }

    public OrderStatus Status { get; set; }
}

public enum OrderStatus
{
    New,
    Processing,
    Shipped,
    Delivered,
    Cancelled
}
