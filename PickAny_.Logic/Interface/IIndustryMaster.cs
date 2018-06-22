using PickAny_.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickAny_.Logic.Interface
{
    public interface IIndustryMaster
    {
        Result<Model.IndustryMaster> Save(Model.IndustryMaster industrymaster);
        Result<Boolean> Delete(int id);
        Result<List<Model.IndustryMaster>> GetIndustryList();
        Result<Model.IndustryMaster> GetIndustryById(int industryId);
    }
}
