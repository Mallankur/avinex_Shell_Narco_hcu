using Avinex_Shell_Norco_HCU.Servises.RefineryInformationServisecs;
using WebApplication1.ConnectionString;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.Configure<OngdbConnector>(builder.Configuration.GetSection("OngDB"));
builder.Services.AddSingleton<GenralInfprmationDataLoadservisecs>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
