﻿using System.Collections.Generic;
using UniversityDemo.Business.Convertor.Account;

namespace UniversityDemo.Business.Processor.Account
{
    public interface IAccountProcessor
    {
        AccountResult Create(AccountParam param);
        List<AccountResult> Create(List<AccountParam> param);

        void Update(long id, AccountParam param);
        void Update(List<AccountParam> param);

        void Delete(long id);
        void Delete(List<long> idList);

        AccountResult Find(long id);
        List<AccountResult> Find();
        List<AccountResult> Find(string field, string value);
        AccountResult Find(string name);
        List<AccountResult> FindByCode(string code);
        List<AccountResult> FindByDescription(string description);
    }
}
