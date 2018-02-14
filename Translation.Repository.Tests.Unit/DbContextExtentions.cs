using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Translation.Repository.Tests.Unit
{
    public static class DbContextExtentions
    {
        public static void ClearChangeTracker(this DbContext context)
        {
            var changedEntriesCopy = context.ChangeTracker.Entries().ToList();

            foreach (var entity in changedEntriesCopy)
            {
                context.Entry(entity.Entity).State = EntityState.Detached;
            }
        }
    }
}
