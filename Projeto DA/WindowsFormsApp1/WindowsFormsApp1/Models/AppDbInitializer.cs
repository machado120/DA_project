using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace WindowsFormsApp1.Models
{


    public class AppDbInitializer : DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {
            // Alterar para o vosso context

            base.Seed(context);
        }
    }
}
