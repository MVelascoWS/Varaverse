//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi;
using Substrate.NetApi.Model.Extrinsics;
using Substrate.NetApi.Model.Meta;
using Substrate.NetApi.Model.Types;
using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace VARANET.NetApiExt.Generated.Storage
{
    
    
    public sealed class AuthorshipStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        public AuthorshipStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Authorship", "Author"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(VARANET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32)));
        }
        
        /// <summary>
        /// >> AuthorParams
        ///  Author of current block.
        /// </summary>
        public static string AuthorParams()
        {
            return RequestGenerator.GetStorage("Authorship", "Author", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> AuthorDefault
        /// Default value as hex string
        /// </summary>
        public static string AuthorDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> Author
        ///  Author of current block.
        /// </summary>
        public async Task<VARANET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> Author(CancellationToken token)
        {
            string parameters = AuthorshipStorage.AuthorParams();
            var result = await _client.GetStorageAsync<VARANET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>(parameters, token);
            return result;
        }
    }
    
    public sealed class AuthorshipCalls
    {
    }
    
    public sealed class AuthorshipConstants
    {
    }
}
