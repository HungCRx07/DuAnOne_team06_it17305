using _1.dal.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.dal.IRepositories
{
    public interface IGioHangRepositories
    {
        bool Add(GioHang obj);
        bool Update(GioHang obj);
        bool Delete(GioHang obj);
        GioHang GetById(Guid id);
        List<GioHang> GetAll();
    }
}
