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


namespace VARANET.NetApiExt.Generated.Model.sp_consensus_grandpa
{
    
    
    public enum Equivocation
    {
        
        Prevote = 0,
        
        Precommit = 1,
    }
    
    /// <summary>
    /// >> 143 - Variant[sp_consensus_grandpa.Equivocation]
    /// </summary>
    public sealed class EnumEquivocation : BaseEnumExt<Equivocation, VARANET.NetApiExt.Generated.Model.finality_grandpa.EquivocationT1, VARANET.NetApiExt.Generated.Model.finality_grandpa.EquivocationT2>
    {
    }
}