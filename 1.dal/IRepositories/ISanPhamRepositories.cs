using _1.dal.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.dal.IRepositories
{
    public interface ISanPhamRepositories
    {
        bool Add(SanPham obj);
        bool Update(SanPham obj);
        bool Delete(SanPham obj);
        SanPham GetById(Guid id);
        List<SanPham> GetAll();
    }
}
