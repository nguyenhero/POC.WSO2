using Microsoft.Extensions.DependencyInjection.Extensions;
using SOAP.Models;
using SoapCore;
using System.ServiceModel.Channels;

WebApplicationBuilder? builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSoapCore();
builder.Services.TryAddSingleton<ISeaportService, SeaportService>();


WebApplication? app = builder.Build();

// Configure the HTTP request pipeline.


app.UseRouting();
app.MapControllers();
app.UseEndpoints(endpoints =>
{
    endpoints.UseSoapEndpoint<ISeaportService>("/Service.asmx", new SoapEncoderOptions()
    {
        MessageVersion = MessageVersion.Soap12WSAddressingAugust2004,

    }, SoapSerializer.DataContractSerializer);
    endpoints.UseSoapEndpoint<ISeaportService>("/Service-V1.asmx", new SoapEncoderOptions()
    {
        MessageVersion = MessageVersion.Soap11WSAddressingAugust2004,

    }, SoapSerializer.DataContractSerializer);
});
app.Run();
