using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Birinci Parça
// Service Registration
builder.Services.AddControllers();
builder.Services.AddOpenApi();

builder.Services.AddSwaggerGen().AddEndpointsApiExplorer();

var app = builder.Build();

// Ýkinci Parça
// Middleware

app.UseSwagger();
app.UseSwaggerUI();

app.MapOpenApi();
app.MapScalarApiReference();
app.MapControllers();

app.Run();

//      /scalar/v1