// See https://aka.ms/new-console-template for more information


using Dapr.Client;
using System.Threading;

Console.WriteLine("Hello, World!");
using var client = new DaprClientBuilder()
    .UseHttpEndpoint("http://localhost:5030")
    .Build();

try
{
    //Using Dapr SDK to invoke a method
    var result = client.CreateInvokeMethodRequest(HttpMethod.Get, "helloworld", "hello");
    await client.InvokeMethodAsync(result);
}
catch (Exception ex) 
{

}
