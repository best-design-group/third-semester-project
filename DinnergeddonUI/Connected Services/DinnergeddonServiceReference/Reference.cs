﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DinnergeddonUI.DinnergeddonServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Account", Namespace="http://schemas.datacontract.org/2004/07/Model")]
    [System.SerializableAttribute()]
    public partial class Account : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordHashField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SecurityStampField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PasswordHash {
            get {
                return this.PasswordHashField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordHashField, value) != true)) {
                    this.PasswordHashField = value;
                    this.RaisePropertyChanged("PasswordHash");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SecurityStamp {
            get {
                return this.SecurityStampField;
            }
            set {
                if ((object.ReferenceEquals(this.SecurityStampField, value) != true)) {
                    this.SecurityStampField = value;
                    this.RaisePropertyChanged("SecurityStamp");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Lobby", Namespace="http://schemas.datacontract.org/2004/07/Model")]
    [System.SerializableAttribute()]
    public partial class Lobby : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int LimitField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DinnergeddonUI.DinnergeddonServiceReference.Account[] PlayersField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Limit {
            get {
                return this.LimitField;
            }
            set {
                if ((this.LimitField.Equals(value) != true)) {
                    this.LimitField = value;
                    this.RaisePropertyChanged("Limit");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public DinnergeddonUI.DinnergeddonServiceReference.Account[] Players {
            get {
                return this.PlayersField;
            }
            set {
                if ((object.ReferenceEquals(this.PlayersField, value) != true)) {
                    this.PlayersField = value;
                    this.RaisePropertyChanged("Players");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DinnergeddonServiceReference.IAccountService")]
    public interface IAccountService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/FindById", ReplyAction="http://tempuri.org/IAccountService/FindByIdResponse")]
        DinnergeddonUI.DinnergeddonServiceReference.Account FindById(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/FindById", ReplyAction="http://tempuri.org/IAccountService/FindByIdResponse")]
        System.Threading.Tasks.Task<DinnergeddonUI.DinnergeddonServiceReference.Account> FindByIdAsync(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/FindByEmail", ReplyAction="http://tempuri.org/IAccountService/FindByEmailResponse")]
        DinnergeddonUI.DinnergeddonServiceReference.Account FindByEmail(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/FindByEmail", ReplyAction="http://tempuri.org/IAccountService/FindByEmailResponse")]
        System.Threading.Tasks.Task<DinnergeddonUI.DinnergeddonServiceReference.Account> FindByEmailAsync(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/FindByUsername", ReplyAction="http://tempuri.org/IAccountService/FindByUsernameResponse")]
        DinnergeddonUI.DinnergeddonServiceReference.Account FindByUsername(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/FindByUsername", ReplyAction="http://tempuri.org/IAccountService/FindByUsernameResponse")]
        System.Threading.Tasks.Task<DinnergeddonUI.DinnergeddonServiceReference.Account> FindByUsernameAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/InsertAccount", ReplyAction="http://tempuri.org/IAccountService/InsertAccountResponse")]
        bool InsertAccount(DinnergeddonUI.DinnergeddonServiceReference.Account account);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/InsertAccount", ReplyAction="http://tempuri.org/IAccountService/InsertAccountResponse")]
        System.Threading.Tasks.Task<bool> InsertAccountAsync(DinnergeddonUI.DinnergeddonServiceReference.Account account);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/UpdateAccount", ReplyAction="http://tempuri.org/IAccountService/UpdateAccountResponse")]
        bool UpdateAccount(DinnergeddonUI.DinnergeddonServiceReference.Account updatedAccount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/UpdateAccount", ReplyAction="http://tempuri.org/IAccountService/UpdateAccountResponse")]
        System.Threading.Tasks.Task<bool> UpdateAccountAsync(DinnergeddonUI.DinnergeddonServiceReference.Account updatedAccount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/DeleteAccount", ReplyAction="http://tempuri.org/IAccountService/DeleteAccountResponse")]
        bool DeleteAccount(DinnergeddonUI.DinnergeddonServiceReference.Account account);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/DeleteAccount", ReplyAction="http://tempuri.org/IAccountService/DeleteAccountResponse")]
        System.Threading.Tasks.Task<bool> DeleteAccountAsync(DinnergeddonUI.DinnergeddonServiceReference.Account account);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/GetAccounts", ReplyAction="http://tempuri.org/IAccountService/GetAccountsResponse")]
        DinnergeddonUI.DinnergeddonServiceReference.Account[] GetAccounts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/GetAccounts", ReplyAction="http://tempuri.org/IAccountService/GetAccountsResponse")]
        System.Threading.Tasks.Task<DinnergeddonUI.DinnergeddonServiceReference.Account[]> GetAccountsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/IsInRole", ReplyAction="http://tempuri.org/IAccountService/IsInRoleResponse")]
        bool IsInRole(System.Guid accountId, string roleName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/IsInRole", ReplyAction="http://tempuri.org/IAccountService/IsInRoleResponse")]
        System.Threading.Tasks.Task<bool> IsInRoleAsync(System.Guid accountId, string roleName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/AddToRole", ReplyAction="http://tempuri.org/IAccountService/AddToRoleResponse")]
        bool AddToRole(System.Guid accountId, string roleName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/AddToRole", ReplyAction="http://tempuri.org/IAccountService/AddToRoleResponse")]
        System.Threading.Tasks.Task<bool> AddToRoleAsync(System.Guid accountId, string roleName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/GetRoles", ReplyAction="http://tempuri.org/IAccountService/GetRolesResponse")]
        string[] GetRoles(System.Guid accountId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/GetRoles", ReplyAction="http://tempuri.org/IAccountService/GetRolesResponse")]
        System.Threading.Tasks.Task<string[]> GetRolesAsync(System.Guid accountId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/VerifyCredentials", ReplyAction="http://tempuri.org/IAccountService/VerifyCredentialsResponse")]
        DinnergeddonUI.DinnergeddonServiceReference.Account VerifyCredentials(string name, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/VerifyCredentials", ReplyAction="http://tempuri.org/IAccountService/VerifyCredentialsResponse")]
        System.Threading.Tasks.Task<DinnergeddonUI.DinnergeddonServiceReference.Account> VerifyCredentialsAsync(string name, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/GetEmailConfirmed", ReplyAction="http://tempuri.org/IAccountService/GetEmailConfirmedResponse")]
        bool GetEmailConfirmed(DinnergeddonUI.DinnergeddonServiceReference.Account account);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/GetEmailConfirmed", ReplyAction="http://tempuri.org/IAccountService/GetEmailConfirmedResponse")]
        System.Threading.Tasks.Task<bool> GetEmailConfirmedAsync(DinnergeddonUI.DinnergeddonServiceReference.Account account);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/SetEmailConfirmed", ReplyAction="http://tempuri.org/IAccountService/SetEmailConfirmedResponse")]
        void SetEmailConfirmed(DinnergeddonUI.DinnergeddonServiceReference.Account account, bool confirmed);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/SetEmailConfirmed", ReplyAction="http://tempuri.org/IAccountService/SetEmailConfirmedResponse")]
        System.Threading.Tasks.Task SetEmailConfirmedAsync(DinnergeddonUI.DinnergeddonServiceReference.Account account, bool confirmed);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/RemoveFromRole", ReplyAction="http://tempuri.org/IAccountService/RemoveFromRoleResponse")]
        bool RemoveFromRole(System.Guid accountId, string roleName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/RemoveFromRole", ReplyAction="http://tempuri.org/IAccountService/RemoveFromRoleResponse")]
        System.Threading.Tasks.Task<bool> RemoveFromRoleAsync(System.Guid accountId, string roleName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/GetNewDummyLobby", ReplyAction="http://tempuri.org/IAccountService/GetNewDummyLobbyResponse")]
        DinnergeddonUI.DinnergeddonServiceReference.Lobby GetNewDummyLobby();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/GetNewDummyLobby", ReplyAction="http://tempuri.org/IAccountService/GetNewDummyLobbyResponse")]
        System.Threading.Tasks.Task<DinnergeddonUI.DinnergeddonServiceReference.Lobby> GetNewDummyLobbyAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAccountServiceChannel : DinnergeddonUI.DinnergeddonServiceReference.IAccountService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AccountServiceClient : System.ServiceModel.ClientBase<DinnergeddonUI.DinnergeddonServiceReference.IAccountService>, DinnergeddonUI.DinnergeddonServiceReference.IAccountService {
        
        public AccountServiceClient() {
        }
        
        public AccountServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AccountServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AccountServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AccountServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public DinnergeddonUI.DinnergeddonServiceReference.Account FindById(System.Guid id) {
            return base.Channel.FindById(id);
        }
        
        public System.Threading.Tasks.Task<DinnergeddonUI.DinnergeddonServiceReference.Account> FindByIdAsync(System.Guid id) {
            return base.Channel.FindByIdAsync(id);
        }
        
        public DinnergeddonUI.DinnergeddonServiceReference.Account FindByEmail(string email) {
            return base.Channel.FindByEmail(email);
        }
        
        public System.Threading.Tasks.Task<DinnergeddonUI.DinnergeddonServiceReference.Account> FindByEmailAsync(string email) {
            return base.Channel.FindByEmailAsync(email);
        }
        
        public DinnergeddonUI.DinnergeddonServiceReference.Account FindByUsername(string username) {
            return base.Channel.FindByUsername(username);
        }
        
        public System.Threading.Tasks.Task<DinnergeddonUI.DinnergeddonServiceReference.Account> FindByUsernameAsync(string username) {
            return base.Channel.FindByUsernameAsync(username);
        }
        
        public bool InsertAccount(DinnergeddonUI.DinnergeddonServiceReference.Account account) {
            return base.Channel.InsertAccount(account);
        }
        
        public System.Threading.Tasks.Task<bool> InsertAccountAsync(DinnergeddonUI.DinnergeddonServiceReference.Account account) {
            return base.Channel.InsertAccountAsync(account);
        }
        
        public bool UpdateAccount(DinnergeddonUI.DinnergeddonServiceReference.Account updatedAccount) {
            return base.Channel.UpdateAccount(updatedAccount);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateAccountAsync(DinnergeddonUI.DinnergeddonServiceReference.Account updatedAccount) {
            return base.Channel.UpdateAccountAsync(updatedAccount);
        }
        
        public bool DeleteAccount(DinnergeddonUI.DinnergeddonServiceReference.Account account) {
            return base.Channel.DeleteAccount(account);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteAccountAsync(DinnergeddonUI.DinnergeddonServiceReference.Account account) {
            return base.Channel.DeleteAccountAsync(account);
        }
        
        public DinnergeddonUI.DinnergeddonServiceReference.Account[] GetAccounts() {
            return base.Channel.GetAccounts();
        }
        
        public System.Threading.Tasks.Task<DinnergeddonUI.DinnergeddonServiceReference.Account[]> GetAccountsAsync() {
            return base.Channel.GetAccountsAsync();
        }
        
        public bool IsInRole(System.Guid accountId, string roleName) {
            return base.Channel.IsInRole(accountId, roleName);
        }
        
        public System.Threading.Tasks.Task<bool> IsInRoleAsync(System.Guid accountId, string roleName) {
            return base.Channel.IsInRoleAsync(accountId, roleName);
        }
        
        public bool AddToRole(System.Guid accountId, string roleName) {
            return base.Channel.AddToRole(accountId, roleName);
        }
        
        public System.Threading.Tasks.Task<bool> AddToRoleAsync(System.Guid accountId, string roleName) {
            return base.Channel.AddToRoleAsync(accountId, roleName);
        }
        
        public string[] GetRoles(System.Guid accountId) {
            return base.Channel.GetRoles(accountId);
        }
        
        public System.Threading.Tasks.Task<string[]> GetRolesAsync(System.Guid accountId) {
            return base.Channel.GetRolesAsync(accountId);
        }
        
        public DinnergeddonUI.DinnergeddonServiceReference.Account VerifyCredentials(string name, string password) {
            return base.Channel.VerifyCredentials(name, password);
        }
        
        public System.Threading.Tasks.Task<DinnergeddonUI.DinnergeddonServiceReference.Account> VerifyCredentialsAsync(string name, string password) {
            return base.Channel.VerifyCredentialsAsync(name, password);
        }
        
        public bool GetEmailConfirmed(DinnergeddonUI.DinnergeddonServiceReference.Account account) {
            return base.Channel.GetEmailConfirmed(account);
        }
        
        public System.Threading.Tasks.Task<bool> GetEmailConfirmedAsync(DinnergeddonUI.DinnergeddonServiceReference.Account account) {
            return base.Channel.GetEmailConfirmedAsync(account);
        }
        
        public void SetEmailConfirmed(DinnergeddonUI.DinnergeddonServiceReference.Account account, bool confirmed) {
            base.Channel.SetEmailConfirmed(account, confirmed);
        }
        
        public System.Threading.Tasks.Task SetEmailConfirmedAsync(DinnergeddonUI.DinnergeddonServiceReference.Account account, bool confirmed) {
            return base.Channel.SetEmailConfirmedAsync(account, confirmed);
        }
        
        public bool RemoveFromRole(System.Guid accountId, string roleName) {
            return base.Channel.RemoveFromRole(accountId, roleName);
        }
        
        public System.Threading.Tasks.Task<bool> RemoveFromRoleAsync(System.Guid accountId, string roleName) {
            return base.Channel.RemoveFromRoleAsync(accountId, roleName);
        }
        
        public DinnergeddonUI.DinnergeddonServiceReference.Lobby GetNewDummyLobby() {
            return base.Channel.GetNewDummyLobby();
        }
        
        public System.Threading.Tasks.Task<DinnergeddonUI.DinnergeddonServiceReference.Lobby> GetNewDummyLobbyAsync() {
            return base.Channel.GetNewDummyLobbyAsync();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DinnergeddonServiceReference.IHighscoreService")]
    public interface IHighscoreService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHighscoreService/GetHighscore", ReplyAction="http://tempuri.org/IHighscoreService/GetHighscoreResponse")]
        int GetHighscore(System.Guid accountId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHighscoreService/GetHighscore", ReplyAction="http://tempuri.org/IHighscoreService/GetHighscoreResponse")]
        System.Threading.Tasks.Task<int> GetHighscoreAsync(System.Guid accountId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHighscoreService/GetHighscores", ReplyAction="http://tempuri.org/IHighscoreService/GetHighscoresResponse")]
        System.Collections.Generic.Dictionary<System.Guid, int> GetHighscores();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHighscoreService/GetHighscores", ReplyAction="http://tempuri.org/IHighscoreService/GetHighscoresResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<System.Guid, int>> GetHighscoresAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHighscoreService/GetTopNHighscores", ReplyAction="http://tempuri.org/IHighscoreService/GetTopNHighscoresResponse")]
        System.Collections.Generic.Dictionary<System.Guid, int> GetTopNHighscores(int n);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHighscoreService/GetTopNHighscores", ReplyAction="http://tempuri.org/IHighscoreService/GetTopNHighscoresResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<System.Guid, int>> GetTopNHighscoresAsync(int n);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IHighscoreServiceChannel : DinnergeddonUI.DinnergeddonServiceReference.IHighscoreService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HighscoreServiceClient : System.ServiceModel.ClientBase<DinnergeddonUI.DinnergeddonServiceReference.IHighscoreService>, DinnergeddonUI.DinnergeddonServiceReference.IHighscoreService {
        
        public HighscoreServiceClient() {
        }
        
        public HighscoreServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HighscoreServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HighscoreServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HighscoreServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int GetHighscore(System.Guid accountId) {
            return base.Channel.GetHighscore(accountId);
        }
        
        public System.Threading.Tasks.Task<int> GetHighscoreAsync(System.Guid accountId) {
            return base.Channel.GetHighscoreAsync(accountId);
        }
        
        public System.Collections.Generic.Dictionary<System.Guid, int> GetHighscores() {
            return base.Channel.GetHighscores();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<System.Guid, int>> GetHighscoresAsync() {
            return base.Channel.GetHighscoresAsync();
        }
        
        public System.Collections.Generic.Dictionary<System.Guid, int> GetTopNHighscores(int n) {
            return base.Channel.GetTopNHighscores(n);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<System.Guid, int>> GetTopNHighscoresAsync(int n) {
            return base.Channel.GetTopNHighscoresAsync(n);
        }
    }
}
