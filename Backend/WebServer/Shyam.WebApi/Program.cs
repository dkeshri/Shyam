using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Shyam.Services.Extensions;
using Shyam.WebApi.Extensions;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapperLayer(typeof(Program));

builder.Services.AddCors(options =>
            options.AddPolicy("CorsPolicy", builder =>
                                                builder.AllowAnyOrigin()
                                                       .AllowAnyHeader()
                                                       .AllowAnyMethod()
                                                       .WithExposedHeaders("Content-Disposition")
                                                       .WithExposedHeaders("X-Pagination")
            ));

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(
                    options =>
                    {
                        options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters()
                        {
                            ValidateIssuerSigningKey = true,
                            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration.GetTokenSecret())),
                            ValidateIssuer = false,
                            ValidateAudience = false
                        };
                    }
                );

builder.Services.AddDataLayer(builder.Configuration);
builder.Services.AddServiceLayer(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("CorsPolicy");
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
