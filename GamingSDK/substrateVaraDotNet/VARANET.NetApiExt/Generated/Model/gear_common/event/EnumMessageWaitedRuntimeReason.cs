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


namespace VARANET.NetApiExt.Generated.Model.gear_common.@event
{
    
    
    public enum MessageWaitedRuntimeReason
    {
        
        WaitCalled = 0,
        
        WaitForCalled = 1,
        
        WaitUpToCalled = 2,
        
        WaitUpToCalledFull = 3,
    }
    
    /// <summary>
    /// >> 76 - Variant[gear_common.event.MessageWaitedRuntimeReason]
    /// </summary>
    public sealed class EnumMessageWaitedRuntimeReason : BaseEnum<MessageWaitedRuntimeReason>
    {
    }
}
