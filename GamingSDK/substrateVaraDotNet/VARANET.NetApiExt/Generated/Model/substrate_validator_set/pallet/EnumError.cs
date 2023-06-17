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


namespace VARANET.NetApiExt.Generated.Model.substrate_validator_set.pallet
{
    
    
    public enum Error
    {
        
        TooLowValidatorCount = 0,
        
        Duplicate = 1,
        
        ValidatorNotApproved = 2,
        
        BadOrigin = 3,
    }
    
    /// <summary>
    /// >> 202 - Variant[substrate_validator_set.pallet.Error]
    /// 
    ///			Custom [dispatch errors](https://docs.substrate.io/main-docs/build/events-errors/)
    ///			of this pallet.
    ///			
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}