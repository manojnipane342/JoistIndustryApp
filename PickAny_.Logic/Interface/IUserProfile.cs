using PickAny_.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PickAny_.Model;
using PickAny_.Model.UserProfiles;

namespace PickAny_.Logic.Interface
{
    public interface IUserProfile
    {
        Result<Boolean> Save(UserProfiles userProfile);
    }
}
