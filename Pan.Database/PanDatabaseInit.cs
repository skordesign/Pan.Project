using System;
using System.Collections.Generic;
using System.Text;

namespace Pan.Database
{
    public class PanDatabaseInit
    {
        public static void Init(PanDbContext _context)
        {
            _context.Database.EnsureCreated();
            for (int i = 0; i < 10; i++)
            {
                _context.Projects.Add(new Models.Models.Project
                {
                    Name = Guid.NewGuid().ToString(),
                    Description = Guid.NewGuid().ToString()
                });
            }
            _context.SaveChanges();
        }
    }
}
