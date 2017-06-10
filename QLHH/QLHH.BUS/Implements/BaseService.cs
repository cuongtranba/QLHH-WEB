using QLHH.DAL;

namespace QLHH.BUS.Implements
{
    public abstract class BaseService
    {
        protected HongLienContext Context;

        protected BaseService(HongLienContext context)
        {
            this.Context = context;
        }
    }
}
