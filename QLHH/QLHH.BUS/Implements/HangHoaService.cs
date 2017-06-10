using System.Collections.Generic;
using System.Linq;
using Cross.Enums;
using Microsoft.EntityFrameworkCore;
using QLHH.BUS.Interfaces;
using QLHH.DAL;
using QLHH.DAL.Model;

namespace QLHH.BUS.Implements
{
    public class HangHoaService : BaseService, IHangHoaService
    {
        public HangHoaService(HongLienContext context) : base(context)
        {

        }

        public List<EntityAttribute> GetAttributeByType(EntityTypes entityTypes)
        {
            var entityAttributeForPhieuNhap =
                Context.EntityTypeAttributes
                    .Include(c => c.Attribute)
                        .ThenInclude(e => e.AttributeType)
                    .Where(c => c.EntityTypeId == (int)entityTypes)
                    .Select(c => new EntityAttribute()
                    {
                        Attribute = new Attribute()
                        {
                            AttributeType = c.Attribute.AttributeType
                        }
                    }).ToList();
            return entityAttributeForPhieuNhap;
        }
    }
}
