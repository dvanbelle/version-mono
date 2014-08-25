using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Topping.Core.Data.Factory
{
    public abstract class ToppingAccessorFactory
    {
        public abstract IToppingAccessor GetContext();
    }

    public  class ConcreteToppingAccessorFactory : ToppingAccessorFactory
    {

        public override IToppingAccessor GetContext()
        {
            if (true)
            {
				return (IToppingAccessor)new Topping.Core.Data.SQL.ToppingAccessor();
            }
            else 
            {
				return (IToppingAccessor)new Topping.Core.Data.Db4o.ToppingAccessor();
            }
        }
    }
}
