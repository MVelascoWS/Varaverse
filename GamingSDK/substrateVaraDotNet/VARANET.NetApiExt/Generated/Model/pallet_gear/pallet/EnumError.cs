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


namespace VARANET.NetApiExt.Generated.Model.pallet_gear.pallet
{
    
    
    public enum Error
    {
        
        MessageNotFound = 0,
        
        InsufficientBalanceForReserve = 1,
        
        GasLimitTooHigh = 2,
        
        ProgramAlreadyExists = 3,
        
        InactiveProgram = 4,
        
        NoMessageTree = 5,
        
        CodeAlreadyExists = 6,
        
        CodeDoesntExist = 7,
        
        CodeTooLarge = 8,
        
        ProgramConstructionFailed = 9,
        
        ValueLessThanMinimal = 10,
        
        MessagesStorageCorrupted = 11,
        
        MessageQueueProcessingDisabled = 12,
        
        ProgramNotFound = 13,
    }
    
    /// <summary>
    /// >> 258 - Variant[pallet_gear.pallet.Error]
    /// 
    ///			Custom [dispatch errors](https://docs.substrate.io/main-docs/build/events-errors/)
    ///			of this pallet.
    ///			
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}