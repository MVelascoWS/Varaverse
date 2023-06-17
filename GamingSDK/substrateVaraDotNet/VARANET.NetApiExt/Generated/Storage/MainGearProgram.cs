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
    
    
    public sealed class GearProgramStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        public GearProgramStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("GearProgram", "CodeStorage"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, typeof(VARANET.NetApiExt.Generated.Model.gear_core.ids.CodeId), typeof(VARANET.NetApiExt.Generated.Model.gear_core.code.InstrumentedCode)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("GearProgram", "CodeLenStorage"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, typeof(VARANET.NetApiExt.Generated.Model.gear_core.ids.CodeId), typeof(Substrate.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("GearProgram", "OriginalCodeStorage"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, typeof(VARANET.NetApiExt.Generated.Model.gear_core.ids.CodeId), typeof(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("GearProgram", "MetadataStorage"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, typeof(VARANET.NetApiExt.Generated.Model.gear_core.ids.CodeId), typeof(VARANET.NetApiExt.Generated.Model.gear_common.CodeMetadata)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("GearProgram", "ProgramStorage"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, typeof(VARANET.NetApiExt.Generated.Model.gear_core.ids.ProgramId), typeof(VARANET.NetApiExt.Generated.Model.gear_common.EnumProgram)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("GearProgram", "MemoryPageStorage"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Identity,
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<VARANET.NetApiExt.Generated.Model.gear_core.ids.ProgramId, VARANET.NetApiExt.Generated.Model.gear_core.memory.GearPage>), typeof(VARANET.NetApiExt.Generated.Model.gear_core.memory.PageBuf)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("GearProgram", "WaitingInitStorage"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, typeof(VARANET.NetApiExt.Generated.Model.gear_core.ids.ProgramId), typeof(Substrate.NetApi.Model.Types.Base.BaseVec<VARANET.NetApiExt.Generated.Model.gear_core.ids.MessageId>)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("GearProgram", "PausedProgramStorage"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, typeof(VARANET.NetApiExt.Generated.Model.gear_core.ids.ProgramId), typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, VARANET.NetApiExt.Generated.Model.primitive_types.H256>)));
        }
        
        /// <summary>
        /// >> CodeStorageParams
        /// </summary>
        public static string CodeStorageParams(VARANET.NetApiExt.Generated.Model.gear_core.ids.CodeId key)
        {
            return RequestGenerator.GetStorage("GearProgram", "CodeStorage", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> CodeStorageDefault
        /// Default value as hex string
        /// </summary>
        public static string CodeStorageDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> CodeStorage
        /// </summary>
        public async Task<VARANET.NetApiExt.Generated.Model.gear_core.code.InstrumentedCode> CodeStorage(VARANET.NetApiExt.Generated.Model.gear_core.ids.CodeId key, CancellationToken token)
        {
            string parameters = GearProgramStorage.CodeStorageParams(key);
            var result = await _client.GetStorageAsync<VARANET.NetApiExt.Generated.Model.gear_core.code.InstrumentedCode>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> CodeLenStorageParams
        /// </summary>
        public static string CodeLenStorageParams(VARANET.NetApiExt.Generated.Model.gear_core.ids.CodeId key)
        {
            return RequestGenerator.GetStorage("GearProgram", "CodeLenStorage", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> CodeLenStorageDefault
        /// Default value as hex string
        /// </summary>
        public static string CodeLenStorageDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> CodeLenStorage
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U32> CodeLenStorage(VARANET.NetApiExt.Generated.Model.gear_core.ids.CodeId key, CancellationToken token)
        {
            string parameters = GearProgramStorage.CodeLenStorageParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U32>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> OriginalCodeStorageParams
        /// </summary>
        public static string OriginalCodeStorageParams(VARANET.NetApiExt.Generated.Model.gear_core.ids.CodeId key)
        {
            return RequestGenerator.GetStorage("GearProgram", "OriginalCodeStorage", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> OriginalCodeStorageDefault
        /// Default value as hex string
        /// </summary>
        public static string OriginalCodeStorageDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> OriginalCodeStorage
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>> OriginalCodeStorage(VARANET.NetApiExt.Generated.Model.gear_core.ids.CodeId key, CancellationToken token)
        {
            string parameters = GearProgramStorage.OriginalCodeStorageParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> MetadataStorageParams
        /// </summary>
        public static string MetadataStorageParams(VARANET.NetApiExt.Generated.Model.gear_core.ids.CodeId key)
        {
            return RequestGenerator.GetStorage("GearProgram", "MetadataStorage", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> MetadataStorageDefault
        /// Default value as hex string
        /// </summary>
        public static string MetadataStorageDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> MetadataStorage
        /// </summary>
        public async Task<VARANET.NetApiExt.Generated.Model.gear_common.CodeMetadata> MetadataStorage(VARANET.NetApiExt.Generated.Model.gear_core.ids.CodeId key, CancellationToken token)
        {
            string parameters = GearProgramStorage.MetadataStorageParams(key);
            var result = await _client.GetStorageAsync<VARANET.NetApiExt.Generated.Model.gear_common.CodeMetadata>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> ProgramStorageParams
        /// </summary>
        public static string ProgramStorageParams(VARANET.NetApiExt.Generated.Model.gear_core.ids.ProgramId key)
        {
            return RequestGenerator.GetStorage("GearProgram", "ProgramStorage", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> ProgramStorageDefault
        /// Default value as hex string
        /// </summary>
        public static string ProgramStorageDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> ProgramStorage
        /// </summary>
        public async Task<VARANET.NetApiExt.Generated.Model.gear_common.EnumProgram> ProgramStorage(VARANET.NetApiExt.Generated.Model.gear_core.ids.ProgramId key, CancellationToken token)
        {
            string parameters = GearProgramStorage.ProgramStorageParams(key);
            var result = await _client.GetStorageAsync<VARANET.NetApiExt.Generated.Model.gear_common.EnumProgram>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> MemoryPageStorageParams
        /// </summary>
        public static string MemoryPageStorageParams(Substrate.NetApi.Model.Types.Base.BaseTuple<VARANET.NetApiExt.Generated.Model.gear_core.ids.ProgramId, VARANET.NetApiExt.Generated.Model.gear_core.memory.GearPage> key)
        {
            return RequestGenerator.GetStorage("GearProgram", "MemoryPageStorage", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Identity,
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, key.Value);
        }
        
        /// <summary>
        /// >> MemoryPageStorageDefault
        /// Default value as hex string
        /// </summary>
        public static string MemoryPageStorageDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> MemoryPageStorage
        /// </summary>
        public async Task<VARANET.NetApiExt.Generated.Model.gear_core.memory.PageBuf> MemoryPageStorage(Substrate.NetApi.Model.Types.Base.BaseTuple<VARANET.NetApiExt.Generated.Model.gear_core.ids.ProgramId, VARANET.NetApiExt.Generated.Model.gear_core.memory.GearPage> key, CancellationToken token)
        {
            string parameters = GearProgramStorage.MemoryPageStorageParams(key);
            var result = await _client.GetStorageAsync<VARANET.NetApiExt.Generated.Model.gear_core.memory.PageBuf>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> WaitingInitStorageParams
        /// </summary>
        public static string WaitingInitStorageParams(VARANET.NetApiExt.Generated.Model.gear_core.ids.ProgramId key)
        {
            return RequestGenerator.GetStorage("GearProgram", "WaitingInitStorage", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> WaitingInitStorageDefault
        /// Default value as hex string
        /// </summary>
        public static string WaitingInitStorageDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> WaitingInitStorage
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Base.BaseVec<VARANET.NetApiExt.Generated.Model.gear_core.ids.MessageId>> WaitingInitStorage(VARANET.NetApiExt.Generated.Model.gear_core.ids.ProgramId key, CancellationToken token)
        {
            string parameters = GearProgramStorage.WaitingInitStorageParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Base.BaseVec<VARANET.NetApiExt.Generated.Model.gear_core.ids.MessageId>>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> PausedProgramStorageParams
        /// </summary>
        public static string PausedProgramStorageParams(VARANET.NetApiExt.Generated.Model.gear_core.ids.ProgramId key)
        {
            return RequestGenerator.GetStorage("GearProgram", "PausedProgramStorage", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> PausedProgramStorageDefault
        /// Default value as hex string
        /// </summary>
        public static string PausedProgramStorageDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> PausedProgramStorage
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, VARANET.NetApiExt.Generated.Model.primitive_types.H256>> PausedProgramStorage(VARANET.NetApiExt.Generated.Model.gear_core.ids.ProgramId key, CancellationToken token)
        {
            string parameters = GearProgramStorage.PausedProgramStorageParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, VARANET.NetApiExt.Generated.Model.primitive_types.H256>>(parameters, token);
            return result;
        }
    }
    
    public sealed class GearProgramCalls
    {
    }
    
    public sealed class GearProgramConstants
    {
    }
    
    public enum GearProgramErrors
    {
        
        /// <summary>
        /// >> DuplicateItem
        /// </summary>
        DuplicateItem,
        
        /// <summary>
        /// >> ItemNotFound
        /// </summary>
        ItemNotFound,
        
        /// <summary>
        /// >> NotActiveProgram
        /// </summary>
        NotActiveProgram,
        
        /// <summary>
        /// >> CannotFindDataForPage
        /// </summary>
        CannotFindDataForPage,
    }
}
