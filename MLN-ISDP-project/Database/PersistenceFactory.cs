using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MLN_ISDP_project.Database
{
    class PersistenceFactory
    {
        public Persistence Create(string id, Type in_type)
        {
            Persistence obj = null;

            var constructor = in_type.GetConstructor(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance, null, new Type[]{ }, new System.Reflection.ParameterModifier[]{});
            obj = (Persistence)constructor.Invoke(null);

            obj.id = id;

            return obj;
        }

        public T Create<T>(string id) where T: Persistence
        {
            return (T)this.Create(id, typeof(T));
        }
    }
}
