using BasicObjectOrientedProgramming;

var order = new Order("Tea", new DateTime(2026, 12, 12));
Console.WriteLine(order.Item);
Console.WriteLine(order.Date);

order.Date = new DateTime(2026, 11, 11);
Console.WriteLine(order.Date);
