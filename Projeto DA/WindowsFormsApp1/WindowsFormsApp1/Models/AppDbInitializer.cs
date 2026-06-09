using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;
using WindowsFormsApp1.Models;


namespace WindowsFormsApp1.Models
{


    public class AppDbInitializer : DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {
            context.Utilizadores.AddOrUpdate(
                u => u.Username,
                new Utilizadores { Username = "admin", Password = "admin" }
            );

            base.Seed(context);
        }
        
    }

}
