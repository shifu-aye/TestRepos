using (var host = new ServiceHost(typeof(Test.Service)))
{
    host.Open();
    Console.WriteLine("Хост запущен!");

    Console.ReadLine();
}