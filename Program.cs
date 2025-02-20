var builder = WebApplication.CreateBuilder(args);

// Birinci Parça
// Service Registration
builder.Services.AddControllers();

var app = builder.Build();

// Ýkinci Parça
// Middleware

app.MapControllers();

app.Run();
