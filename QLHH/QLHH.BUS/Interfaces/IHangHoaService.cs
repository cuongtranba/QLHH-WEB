using System.Collections.Generic;
using Cross.Enums;
using QLHH.DAL.Model;

namespace QLHH.BUS.Interfaces
{
    public interface IHangHoaService
    {
        List<EntityAttribute> GetAttributeByType(EntityTypes phieuNhap);
    }
}
