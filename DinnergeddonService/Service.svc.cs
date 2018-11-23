﻿using System.ServiceModel;
using System.Collections.Generic;
using Controller;
using System;
using Model;

namespace DinnergeddonService
{
    [ServiceBehavior]
    public class DinnergeddonService : IAccontService, ILobbyService
    {
        private readonly IAccountController accountController;

        public DinnergeddonService()
        {
            accountController = new AccountController();
        }

        /// <summary>
        /// This method adds a role to an account with accountId
        /// </summary>
        /// <param name="accountId">The id of the account that's to be added a role</param>
        /// <param name="roleName">The name of the role</param>
        /// <returns>If the operation was successful</returns>
        public bool AddToRole(Guid accountId, string roleName)
        {
            return accountController.AddToRole(accountId, roleName);
        }

        /// <summary>
        /// This method tries to find an account by searching for the email
        /// </summary>
        /// <param name="email">The email to be found</param>
        /// <returns>An account with email</returns>
        public Account FindByEmail(string email)
        {
            return accountController.FindByEmail(email);
        }

        /// <summary>
        /// This method tries to find an account by it's ID
        /// </summary>
        /// <param name="id">The id of an account</param>
        /// <returns>An account with ID</returns>
        public Account FindById(Guid id)
        {
            return accountController.FindById(id);
        }

        /// <summary>
        /// This method tries to find an acount by it's username
        /// </summary>
        /// <param name="username">The username of the account</param>
        /// <returns>An account with username</returns>
        public Account FindByUsername(string username)
        {
            return accountController.FindByUsername(username);
        }

        /// <summary>
        /// Gets all accounts on the system
        /// TODO: Make this method secure without exposing all the accounts to unwanted callers
        /// </summary>
        /// <returns>A list of all accounts saved on the database</returns>
        public IEnumerable<Account> GetAccounts()
        {
            return accountController.GetAccounts();
        }

        /// <summary>
        /// Gets all roles an account with accountId has
        /// </summary>
        /// <param name="accountId">The id of account</param>
        /// <returns>A list of all the roles an account with accountId has</returns>
        public IEnumerable<string> GetRoles(Guid accountId)
        {
            return accountController.GetAccountRoles(accountId);
        }

        /// <summary>
        /// This method adds a new account to the system
        /// </summary>
        /// <param name="account">An account to be added</param>
        /// <returns>If the account was added</returns>
        public bool InsertAccount(Account account)
        {
            return accountController.InsertAccount(account);
        }

        /// <summary>
        /// Checks if an account with accountId has a role with roleName
        /// </summary>
        /// <param name="accountId">The id of the account to be checked</param>
        /// <param name="roleName">The name of the role</param>
        /// <returns>If the account has this role</returns>
        public bool IsInRole(Guid accountId, string roleName)
        {
            return accountController.IsInRole(accountId, roleName);
        }

        /// <summary>
        /// Updates an account with new it's new information.
        /// Since the ID of an account is immutable (cannot change), the account that's going to be changed will be the one
        /// that has the ID of the account passed to this method
        /// </summary>
        /// <param name="updatedAccount">The new account informaiton</param>
        /// <returns>If the account was changed</returns>
        public bool UpdateAccount(Account updatedAccount)
        {
            return accountController.UpdateAccount(updatedAccount);
        }

        /// <summary>
        /// Deletes an already existing account from the system
        /// </summary>
        /// <param name="account">The account to be deleted</param>
        /// <returns>If the account was deleted successfuly</returns>
        public bool DeleteAccount(Account account)
        {
            return accountController.DeleteAccount(account);
        }

        public Lobby CreateLobby(string name, int playerLimit)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Lobby> GetLobbies()
        {
            throw new NotImplementedException();
        }

        public Lobby CreatePrivateLobby(string name, int playerLimit, string password)
        {
            throw new NotImplementedException();
        }


    }
}