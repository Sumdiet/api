using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);


var app = builder.Build();


app.UseCors(option => option.AllowAnyOrigin()
          .AllowAnyHeader()
          .AllowAnyMethod());
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
