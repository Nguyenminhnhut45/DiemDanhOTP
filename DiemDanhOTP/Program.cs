using DiemDanhOTP.Persistence;
using Microsoft.EntityFrameworkCore;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddCors((options) =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                        builder =>
                        {
                            builder.WithOrigins("http://example.com",
                                                "http://www.contoso.com");
                        });
});
ConfigurationManager configuration = builder.Configuration;

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//For identity.entityframworkcore.
builder.Services.AddDbContext<DiemDanhDBContext>(options => options.UseSqlServer(configuration.GetConnectionString("default")));

//builder.Services.AddSingleton<ITokenService>(new TokenService());
//builder.Services.AddSingleton<IUserRepositoryService>(new UserRepositoryService());


await using var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

await app.RunAsync();
