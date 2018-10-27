using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetSatis.Entities.Context;
using NetSatis.Entities.Tables;
using System.Linq.Expressions;
using NetSatis.Entities.Interfaces;
using System.Data.Entity.Migrations;
using NetSatis.Entities.Repositories;
using NetSatis.Entities.Validations;


namespace NetSatis.Entities.DataAccess
{
    public class CariDAL : EntityRepositoryBase<NetSatisContext, Cari, CariValidator>
    {
        
    }
}
