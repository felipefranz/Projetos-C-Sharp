using NovidadesDotNet8.Implementations.InjecaoDependencia;
using NovidadesDotNet8.Interfaces.InjecaoDependencia;

var builder = WebApplication.CreateBuilder(args);

//***** Modelo convencional para inje��o de Depend�ncia ******///
//builder.Services.AddSingleton<ITesteInjecao, TesteInjecao>();
//builder.Services.AddScoped<ITesteInjecao, TesteInjecao>();
//builder.Services.AddTransient<ITesteInjecao, TesteInjecao>();
//***** Modelo convencional para inje��o de Depend�ncia ******///

//***** Inje��o com mapeamento por key *****//
builder.Services.AddKeyedSingleton<ITesteInjecao, TesteInjecao>("InjecaoSingletonUm");
builder.Services.AddKeyedSingleton<ITesteInjecao, TesteInjecao>("InjecaoSingletonDois");

builder.Services.AddKeyedScoped<ITesteInjecao, TesteInjecao>("InjecaoScopedUm");
builder.Services.AddKeyedScoped<ITesteInjecao, TesteInjecao>("InjecaoScopedDois");

builder.Services.AddKeyedTransient<ITesteInjecao, TesteInjecao>("InjecaoTransientUm");
builder.Services.AddKeyedTransient<ITesteInjecao, TesteInjecao>("InjecaoTransientDois");
//***** Inje��o com mapeamento por key *****//

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
