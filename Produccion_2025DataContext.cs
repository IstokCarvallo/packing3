using System;
using SnapObjects.Data;
using SnapObjects.Data.SqlServer;

namespace Packing3
{
    public class Produccion_2025DataContext : SqlServerDataContext
    {
        public Produccion_2025DataContext(string connectionString)
                :this(new SqlServerDataContextOptions<Produccion_2025DataContext>(connectionString))
        {

        }

        public Produccion_2025DataContext(IDataContextOptions<Produccion_2025DataContext> options)
            : base(options)
        {

        }

        public Produccion_2025DataContext(IDataContextOptions options)
            : base(options)
        {

        }
    }
}
