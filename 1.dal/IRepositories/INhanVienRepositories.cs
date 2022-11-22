using _1.dal.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.dal.IRepositories
{
    public interface INhanVienRepositories
    {
        bool Add(NhanVien obj);
        bool Update(NhanVien obj);
        bool Delete(NhanVien obj);
        NhanVien GetById(Guid id);
        List<NhanVien> GetAll();
    }
}
