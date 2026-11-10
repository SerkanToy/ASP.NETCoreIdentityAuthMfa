var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddAuthentication("CookieAuth")
    .AddCookie("CookieAuth", opt =>
    {
        opt.Cookie.Name = "CookieAuth";
        opt.LoginPath = "/Login";
        opt.LogoutPath = "/Logout";
        opt.AccessDeniedPath = "/AccessDenied";
    });

builder.Services.AddAuthentication("AdminCookieAuth")
    .AddCookie("AdminCookieAuth", opt =>
    {
        opt.Cookie.Name = "AdminCookieAuth";
        opt.LoginPath = "/Login";
        opt.LogoutPath = "/Logout";
        opt.AccessDeniedPath = "/AccessDenied";
    });

builder.Services.AddAuthorization(opt =>
{
    opt.AddPolicy(name:"ArchiveDepartman",policy => policy.RequireClaim("Department", "archive"));
    opt.AddPolicy(name: "ManagerOnly", policy => policy.RequireClaim("Manager").RequireClaim("Admin"));
    opt.AddPolicy(name: "ManagerOnly", policy => policy.RequireClaim("Admin"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

app.Run();
