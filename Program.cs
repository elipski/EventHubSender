// See https://aka.ms/new-console-template for more information
Console.WriteLine("Sending Events.");
//EventHubSender.IEventHubSender ehs = new EventHubSender.EventSender();

await EventHubSender.EventSender.Main();
