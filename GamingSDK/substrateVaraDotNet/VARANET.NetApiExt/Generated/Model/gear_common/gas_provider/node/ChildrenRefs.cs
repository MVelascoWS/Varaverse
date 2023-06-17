//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Attributes;
using Substrate.NetApi.Model.Types.Base;
using Substrate.NetApi.Model.Types.Metadata.V14;
using System.Collections.Generic;


namespace VARANET.NetApiExt.Generated.Model.gear_common.gas_provider.node
{
    
    
    /// <summary>
    /// >> 251 - Composite[gear_common.gas_provider.node.ChildrenRefs]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class ChildrenRefs : BaseType
    {
        
        /// <summary>
        /// >> spec_refs
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _specRefs;
        
        /// <summary>
        /// >> unspec_refs
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _unspecRefs;
        
        public Substrate.NetApi.Model.Types.Primitive.U32 SpecRefs
        {
            get
            {
                return this._specRefs;
            }
            set
            {
                this._specRefs = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 UnspecRefs
        {
            get
            {
                return this._unspecRefs;
            }
            set
            {
                this._unspecRefs = value;
            }
        }
        
        public override string TypeName()
        {
            return "ChildrenRefs";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(SpecRefs.Encode());
            result.AddRange(UnspecRefs.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            SpecRefs = new Substrate.NetApi.Model.Types.Primitive.U32();
            SpecRefs.Decode(byteArray, ref p);
            UnspecRefs = new Substrate.NetApi.Model.Types.Primitive.U32();
            UnspecRefs.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}