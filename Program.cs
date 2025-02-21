using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Birinci Par�a
// Service Registration
builder.Services.AddControllers();
builder.Services.AddOpenApi();

builder.Services.AddSwaggerGen().AddEndpointsApiExplorer();

var app = builder.Build();

// �kinci Par�a
// Middleware

app.UseSwagger();
app.UseSwaggerUI();

app.MapOpenApi();
app.MapScalarApiReference();
app.MapControllers();

app.Run();

//      /scalar/v1