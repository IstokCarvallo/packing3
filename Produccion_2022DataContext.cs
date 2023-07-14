using System;
using SnapObjects.Data;
using SnapObjects.Data.SqlServer;

namespace Packing3
{
    public class Produccion_2022DataContext : SqlServerDataContext
    {
        public Produccion_2022DataContext(string connectionString)
                :this(new SqlServerDataContextOptions<Produccion_2022DataContext>(connectionString))
        {

        }

        public Produccion_2022DataContext(IDataContextOptions<Produccion_2022DataContext> options)
            : base(options)
        {

        }

        public Produccion_2022DataContext(IDataContextOptions options)
            : base(options)
        {

        }
    }
}
