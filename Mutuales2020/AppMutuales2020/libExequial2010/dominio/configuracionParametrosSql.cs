using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Sql;

namespace libMutuales2020.dominio
{
    public partial class configuracionParametrosSql
    {
        public string strNombreParametro { set; get; }
        public string strValorParametro { set; get; }
    }
}
