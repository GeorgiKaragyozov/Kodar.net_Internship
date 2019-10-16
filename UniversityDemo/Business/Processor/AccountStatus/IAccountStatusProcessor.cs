using System.Collections.Generic;
using UniversityDemo.Business.Convertor.AccountStatus;

namespace UniversityDemo.Business.Processor.AccountStatus
{
    public interface IAccountStatusProcessor
    {
        AccountStatusResult Create(AccountStatusParam param);
        List<AccountStatusResult> Create(List<AccountStatusParam> param);

        void Update(long id, AccountStatusParam param);
        void Update(List<AccountStatusParam> param);

        void Delete(long id);
        void Delete(List<long> idList);

        AccountStatusResult Find(long id);
        List<AccountStatusResult> Find();
    }
}
