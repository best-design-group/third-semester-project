﻿using Model;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace DinnergeddonService
{
    [ServiceContract]
    public interface IAccountService
    {
        [OperationContract]
        bool RegisterAccount(string username, string email, string password);
        [OperationContract]
        bool CheckUsername(string username);
        [OperationContract]
        bool CheckEmail(string email);
        [OperationContract]
        Account GetInfo();
        [OperationContract]
        bool EditAccount(string username, string email, string password);
        [OperationContract]
        bool Login(string username, string password);
        [OperationContract]
        Account FindById(Guid id);
        [OperationContract]
        bool InsertAccount(Account account);
        [OperationContract]
        Account FindByEmail(string email);

        [OperationContract]
        bool IsInRole(Guid accountId, string roleName);
        [OperationContract]
        bool AddToRole(Guid accountId, string roleName);
        [OperationContract]
        List<string> GetRoles(Guid accountId);
    }
}
