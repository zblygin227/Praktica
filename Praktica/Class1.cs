using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktica
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class agentstvo5Entities : DbContext
    {
        private static agentstvo5Entities context;
        public static agentstvo5Entities GetContext()
        {
            if (context == null) context = new agentstvo5Entities();
            return context;
        }
    }
}
