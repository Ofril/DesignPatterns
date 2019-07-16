using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPro
{
    public class MongoInsertQuery : MongoTemplateBase
    {
        protected override void ExecuteQuery()
        {
            Console.WriteLine("Insert into TABLE values () DB im Mongo.....");
        }
    }
}
