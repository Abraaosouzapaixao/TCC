using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bistro.Database.Entity
{
     public partial class tb_estoque
    {
        public string nm_produto { get { return this.tb_produto.nm_produto; } set { } }
        public DateTime dt_validade {get { return this.tb_produto.dt_validade; } }
    }
}
