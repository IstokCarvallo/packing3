using System;
using SnapObjects.Data;
using SnapObjects.Data.SqlServer;

namespace Packing3
{
    public class Produccion_2024DataContext : SqlServerDataContext
    {
        public Produccion_2024DataContext(string connectionString)
                :this(new SqlServerDataContextOptions<Produccion_2024DataContext>(connectionString))
        {

        }

        public Produccion_2024DataContext(IDataContextOptions<Produccion_2024DataContext> options)
            : base(options)
        {

        }

        public Produccion_2024DataContext(IDataContextOptions options)
            : base(options)
        {

        }
    }
}
