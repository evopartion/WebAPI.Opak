var builder = WebApplication.CreateBuilder(args);

// Birinci Par�a
// Service Registration
builder.Services.AddControllers();

var app = builder.Build();

// �kinci Par�a
// Middleware

app.MapControllers();

app.Run();
