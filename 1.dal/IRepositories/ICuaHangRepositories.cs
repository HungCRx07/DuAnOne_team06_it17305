using _1.dal.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.dal.IRepositories
{
    public interface ICuaHangRepositories
    {
        bool Add(CuaHang obj);
        bool Update(CuaHang obj);
        bool Delete(CuaHang obj);
        CuaHang GetById(Guid id);
        List<CuaHang> GetAll();
    }
}
