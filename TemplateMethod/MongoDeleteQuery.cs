using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPro
{
    public class MongoDeleteQuery : MongoTemplateBase
    {
        protected override void ExecuteQuery()
        {
            Console.WriteLine("Delete * From TABLE DB im Mongo.....");
        }
    }
}
