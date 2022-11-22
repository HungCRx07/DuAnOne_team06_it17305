using _1.dal.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.dal.IRepositories
{
    public interface IGioHangCtRepositories
    {
        bool Add(GioHangCt obj);
        bool Update(GioHangCt obj);
        bool Delete(GioHangCt obj);
        GioHangCt GetById(Guid id);
        List<GioHangCt> GetAll();
    }
}
