//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Model.Types.Base;
using Substrate.ServiceLayer.Attributes;
using Substrate.ServiceLayer.Storage;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace VARANET.RestService.Generated.Storage
{
    
    
    /// <summary>
    /// IAuthorshipStorage interface definition.
    /// </summary>
    public interface IAuthorshipStorage : IStorage
    {
        
        /// <summary>
        /// >> Author
        ///  Author of current block.
        /// </summary>
        VARANET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 GetAuthor();
    }
    
    /// <summary>
    /// AuthorshipStorage class definition.
    /// </summary>
    public sealed class AuthorshipStorage : IAuthorshipStorage
    {
        
        /// <summary>
        /// _authorTypedStorage typed storage field
        /// </summary>
        private TypedStorage<VARANET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> _authorTypedStorage;
        
        /// <summary>
        /// AuthorshipStorage constructor.
        /// </summary>
        public AuthorshipStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.AuthorTypedStorage = new TypedStorage<VARANET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>("Authorship.Author", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _authorTypedStorage property
        /// </summary>
        public TypedStorage<VARANET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> AuthorTypedStorage
        {
            get
            {
                return _authorTypedStorage;
            }
            set
            {
                _authorTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Substrate.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await AuthorTypedStorage.InitializeAsync("Authorship", "Author");
        }
        
        /// <summary>
        /// Implements any storage change for Authorship.Author
        /// </summary>
        [StorageChange("Authorship", "Author")]
        public void OnUpdateAuthor(string data)
        {
            AuthorTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> Author
        ///  Author of current block.
        /// </summary>
        public VARANET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 GetAuthor()
        {
            return AuthorTypedStorage.Get();
        }
    }
}
