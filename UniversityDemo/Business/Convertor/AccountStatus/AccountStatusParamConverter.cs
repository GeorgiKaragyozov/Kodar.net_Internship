using UniversityDemo.Business.Convertor.Common;

namespace UniversityDemo.Business.Convertor.AccountStatus
{
    public class AccountStatusParamConverter 
        : BaseParamConverter<AccountStatusParam, Model.AccountStatus>,
        IAccountStatusParamConverter
    {
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

        public override Model.AccountStatus ConvertSpecific(AccountStatusParam param, Model.AccountStatus entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
