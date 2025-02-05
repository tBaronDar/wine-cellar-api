namespace WineCellarAPI.Data;

public static class Extensions
{
    //The CreateDbIfNotExists method is defined as an extension of IHost.
    public static void CreateDBIfNotExist(this IHost host)
    {
        {
            using (var scope = host.Services.CreateScope())//create scope
            {
                var services = scope.ServiceProvider;//get services

                var context = services.GetRequiredService<WineCellarContext>();//get context from services
                context.Database.EnsureCreated();//run this method to check if db exists
                DbInitializer.Initialize(context);//seed db
            }
        }
    }
}