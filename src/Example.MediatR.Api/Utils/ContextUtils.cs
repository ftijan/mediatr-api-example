using Example.MediatR.Api.Context;
using Example.MediatR.Api.Context.Models;

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
    }
}
