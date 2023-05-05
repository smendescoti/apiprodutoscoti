using CentralDeProdutos.Services.Api.Setups;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

//adicionando as configurações
CorsSetup.Configure(builder);
DependencyInjectionSetup.Configure(builder);
AutoMapperSetup.Configure(builder);
SwaggerSetup.Configure(builder);

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();

CorsSetup.Use(app);

app.UseAuthorization();

app.MapControllers();

app.Run();
