using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HortaOrganicaAppData.Dao
{
    public class BdSqlServerDao
    {
        //Configuração do banco de dados
        public readonly string conexaoSqlServer = @"Data Source=(localdb)\MSSQLLocalDB;" +
            " Database=HortaOrganica;" +
            " Integrated Security=True";
    }
}

