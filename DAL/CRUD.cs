using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public static class CRUD
    {
        internal static PlanesDbContext CreateDbContext()
        {
            try
            {
                var context = new PlanesDbContext();
                if (context.Database.GetPendingMigrations().Any())
                    context.Database.Migrate();

                return context;
            }
            catch (Exception ex)
            {
                throw new Exception("PlanesDbContext creation exception", ex);
            }
        }

        public static Int32 GetPlaneBoardsCount()
        {
            using (var context = CreateDbContext())
            {
                return context.PlaneBoards.Count();
            }
        }
    }
}
