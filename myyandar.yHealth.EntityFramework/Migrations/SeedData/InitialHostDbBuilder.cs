using myyandar.yHealth.EntityFramework;
using EntityFramework.DynamicFilters;

namespace myyandar.yHealth.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly yHealthDbContext _context;

        public InitialHostDbBuilder(yHealthDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
