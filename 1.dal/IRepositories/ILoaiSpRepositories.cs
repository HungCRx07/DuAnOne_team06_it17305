using _1.dal.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.dal.IRepositories
{
    public interface ILoaiSpRepositories
    {
        bool Add(LoaiSp obj);
        bool Update(LoaiSp obj);
        bool Delete(LoaiSp obj);
        LoaiSp GetById(Guid id);
        List<LoaiSp> GetAll();
    }
}
