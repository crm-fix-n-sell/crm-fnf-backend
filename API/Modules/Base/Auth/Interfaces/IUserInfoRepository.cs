using System.Collections.Generic;
using API.MongoData.Models.Auth;

namespace API.Modules.Base.Auth
{
    public interface IUserInfoRepository
    {
        #region UserInfo

        UserInfo Create(UserInfo sampleCustomer);
        UserInfo FindById(string mongoId);
        UserInfo FindByUsername(string username);
        UserInfo FindByEmail(string email);
        IList<UserInfo> Read();
        void Update(UserInfo sampleCustomer);
        void Delete(string mongoDb);

        #endregion
    }
}