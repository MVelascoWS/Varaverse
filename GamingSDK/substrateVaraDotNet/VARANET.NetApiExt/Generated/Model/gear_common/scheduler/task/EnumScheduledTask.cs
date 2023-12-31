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


namespace VARANET.NetApiExt.Generated.Model.gear_common.scheduler.task
{
    
    
    public enum ScheduledTask
    {
        
        PauseProgram = 0,
        
        RemoveCode = 1,
        
        RemoveFromMailbox = 2,
        
        RemoveFromWaitlist = 3,
        
        RemovePausedProgram = 4,
        
        WakeMessage = 5,
        
        SendDispatch = 6,
        
        SendUserMessage = 7,
        
        RemoveGasReservation = 8,
    }
    
    /// <summary>
    /// >> 246 - Variant[gear_common.scheduler.task.ScheduledTask]
    /// </summary>
    public sealed class EnumScheduledTask : BaseEnumExt<ScheduledTask, VARANET.NetApiExt.Generated.Model.gear_core.ids.ProgramId, VARANET.NetApiExt.Generated.Model.gear_core.ids.CodeId, BaseTuple<VARANET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, VARANET.NetApiExt.Generated.Model.gear_core.ids.MessageId>, BaseTuple<VARANET.NetApiExt.Generated.Model.gear_core.ids.ProgramId, VARANET.NetApiExt.Generated.Model.gear_core.ids.MessageId>, VARANET.NetApiExt.Generated.Model.gear_core.ids.ProgramId, BaseTuple<VARANET.NetApiExt.Generated.Model.gear_core.ids.ProgramId, VARANET.NetApiExt.Generated.Model.gear_core.ids.MessageId>, VARANET.NetApiExt.Generated.Model.gear_core.ids.MessageId, BaseTuple<VARANET.NetApiExt.Generated.Model.gear_core.ids.MessageId, Substrate.NetApi.Model.Types.Primitive.Bool>, BaseTuple<VARANET.NetApiExt.Generated.Model.gear_core.ids.ProgramId, VARANET.NetApiExt.Generated.Model.gear_core.ids.ReservationId>>
    {
    }
}
