//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;


namespace VARANET.NetApiExt.Generated.Model.pallet_proxy.pallet
{
    
    
    public enum Call
    {
        
        proxy = 0,
        
        add_proxy = 1,
        
        remove_proxy = 2,
        
        remove_proxies = 3,
        
        create_pure = 4,
        
        kill_pure = 5,
        
        announce = 6,
        
        remove_announcement = 7,
        
        reject_announcement = 8,
        
        proxy_announced = 9,
    }
    
    /// <summary>
    /// >> 179 - Variant[pallet_proxy.pallet.Call]
    /// Contains one variant per dispatchable that can be called by an extrinsic.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, BaseTuple<VARANET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Substrate.NetApi.Model.Types.Base.BaseOpt<VARANET.NetApiExt.Generated.Model.gear_runtime.EnumProxyType>, VARANET.NetApiExt.Generated.Model.gear_runtime.EnumRuntimeCall>, BaseTuple<VARANET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, VARANET.NetApiExt.Generated.Model.gear_runtime.EnumProxyType, Substrate.NetApi.Model.Types.Primitive.U32>, BaseTuple<VARANET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, VARANET.NetApiExt.Generated.Model.gear_runtime.EnumProxyType, Substrate.NetApi.Model.Types.Primitive.U32>, BaseVoid, BaseTuple<VARANET.NetApiExt.Generated.Model.gear_runtime.EnumProxyType, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U16>, BaseTuple<VARANET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, VARANET.NetApiExt.Generated.Model.gear_runtime.EnumProxyType, Substrate.NetApi.Model.Types.Primitive.U16, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>>, BaseTuple<VARANET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, VARANET.NetApiExt.Generated.Model.primitive_types.H256>, BaseTuple<VARANET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, VARANET.NetApiExt.Generated.Model.primitive_types.H256>, BaseTuple<VARANET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, VARANET.NetApiExt.Generated.Model.primitive_types.H256>, BaseTuple<VARANET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, VARANET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Substrate.NetApi.Model.Types.Base.BaseOpt<VARANET.NetApiExt.Generated.Model.gear_runtime.EnumProxyType>, VARANET.NetApiExt.Generated.Model.gear_runtime.EnumRuntimeCall>>
    {
    }
}
