using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MLN_ISDP_project.Database
{
    class PersistenceFactory
    {
        //default db conn
        static System.Data.OleDb.OleDbConnectionStringBuilder csBuilder = new System.Data.OleDb.OleDbConnectionStringBuilder(
                "Provider=MSDAORA;Data Source=localhost;User ID=2023164;Password=#42Paradox;");
        static OracleDB dbConn = new OracleDB(csBuilder.ToString());

        public Persistence Create(string id, Type in_type, OracleDB in_db)
        {
            Persistence obj = null;

            var constructor = in_type.GetConstructor(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance, null, new Type[]{ }, new System.Reflection.ParameterModifier[]{});
            obj = (Persistence)constructor.Invoke(null);

            obj.id = id;

            return obj;
        }

        public Persistence Create(string id, Type in_type)
        {
            return this.Create(id, in_type, dbConn);
        }

        public T Create<T>(string id) where T: Persistence
        {
            return (T)this.Create(id, typeof(T));
        }
    }
}
