var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//Use Routing
app.UseRouting();
app.UseEndpoints(static endpoints =>
{
    endpoints.MapGet("/Home", async (context) =>
    {
        await context.Response.WriteAsync("This is Home Page..GET");
    });


    endpoints.MapPost("/Home", async (context) =>
    {
        await context.Response.WriteAsync("This is Home Page..POST");
    });

    endpoints.MapPut("/Home", async (context) =>
    {
        await context.Response.WriteAsync("This is Home Page..PUT");
    });


    endpoints.MapDelete("/Home", async (context) =>
    {
        await context.Response.WriteAsync("This is Home Page..DELETE");
    });

});

app.Run(async (HttpContext context) =>
{
    await context.Response.WriteAsync("Page Not Found");
});


//app.Map("/Home", () => "Hello World!");
//app.MapGet("/Home", () => "Hello World! -GET");
//app.MapPost("/Home", () => "Hello World! -POST");
//app.MapPut("/Home", () => "Hello World! -PUT");
//app.MapDelete("/Home", () => "Hello World! -DELETE");

app.Run();
