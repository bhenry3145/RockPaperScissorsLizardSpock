using RockPaperScissorsLizardSpock.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<RockPaperScissorsLizardSpockServices>();

builder.Services.AddCors(options => {
    options.AddPolicy("AllowAll",
    policy => {
          policy.AllowAnyOrigin() // Allows requests from any origin
                .AllowAnyMethod() // Allows any Http Request (GET, POST, PUT, etc)
                .AllowAnyHeader(); // Allows any headers
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

app.UseCors("AllowAll");
