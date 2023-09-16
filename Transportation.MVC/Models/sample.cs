using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Transportation.Data.Context;

namespace Transportation.MVC.Models
{
	public class sample
	{
		public static void Initialize(IServiceProvider serviceProvider)
		{
			var context = serviceProvider.GetService<TransportationDbContext>();

			string[] roles = new string[] { "Owner", "Administrator", "Manager", "Editor", "Buyer", "Business", "Seller", "Subscriber" };

			foreach (string role in roles)
			{
				var roleStore = new RoleStore<IdentityRole>(context);

				if (!context.Roles.Any(r => r.Name == role))
				{
					roleStore.CreateAsync(new IdentityRole(role));
				}
			}



			

			

			context.SaveChangesAsync();
		}

		
	}
}
