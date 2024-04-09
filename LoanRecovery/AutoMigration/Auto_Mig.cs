using LoanRecovery.Data;
using Microsoft.EntityFrameworkCore;

namespace LoanRecovery.AutoMigration
{
    public class Auto_Mig
    {

        public static void Initialize(AppDbContext appDb)
        {
            try
            {
                appDb.Database.Migrate();

            }
            catch (Exception ex)
            {

                throw new Exception("Database Migration Failed. please Contact Suppport", ex.InnerException);
            }
        
        
        }
    }
}
