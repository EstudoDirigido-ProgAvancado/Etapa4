string txt = OrderStatus.PendingPayment.ToString();
OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
Console.WriteLine(os);
Console.WriteLine(txt);
