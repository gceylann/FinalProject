using Core.DataAccess.EntityFramework;
using DateAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DateAccess.Concrete.Entityframework
{
    public class EfOrderDal: EfEntityRepositoryBase<Order, NorthwindContext>, IOrderDal
    {
    }
}
