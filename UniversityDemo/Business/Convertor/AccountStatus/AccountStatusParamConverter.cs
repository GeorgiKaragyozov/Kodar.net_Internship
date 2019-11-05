using UniversityDemo.DataAccess.DataAccessObject.AccountStatus;

namespace UniversityDemo.Business.Convertor.AccountStatus
{
    public class AccountStatusParamConverter : IAccountStatusParamConverter
    {
        IAccountStatusDao Dao = new AccountStatusDao();

        public Model.AccountStatus Convert(AccountStatusParam param, Model.AccountStatus oldEntity)
        {
            Model.AccountStatus entity = null;

            if (oldEntity != null)
            {
                entity = oldEntity;
            }
            else
            {
                entity = new Model.AccountStatus
                {
                    Code = param.Code,
                    Id = param.Id,
                    Description = param.Description,
                    Name = param.Name
                };
            }

            return entity;
        }
    }
}
