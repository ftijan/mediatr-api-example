using Example.MediatR.Api.Context;
using Example.MediatR.Api.Context.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Example.MediatR.Api.Utils
{
    public static class ContextUtils
    {
        internal static void AddTestData(this ApiContext context)
        {           

            var testItem1 = new Item
            {
                Id = 1,
                Description = "Test 1"
            };

            var testItem2 = new Item
            {
                Id = 2,
                Description = "Test 2"
            };

            context.Items.AddRange(testItem1, testItem2);            

            context.SaveChanges();
        }

        internal static void AddTestData(this IApplicationBuilder applicationBuilder)
        {
            var serviceScope = applicationBuilder.ApplicationServices.CreateScope();

            var context = serviceScope.ServiceProvider.GetService<ApiContext>();

            context.AddTestData();
        }
    }
}
