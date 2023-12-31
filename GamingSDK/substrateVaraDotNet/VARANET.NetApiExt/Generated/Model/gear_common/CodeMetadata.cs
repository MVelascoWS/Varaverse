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


namespace VARANET.NetApiExt.Generated.Model.gear_common
{
    
    
    /// <summary>
    /// >> 209 - Composite[gear_common.CodeMetadata]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class CodeMetadata : BaseType
    {
        
        /// <summary>
        /// >> author
        /// </summary>
        private VARANET.NetApiExt.Generated.Model.primitive_types.H256 _author;
        
        /// <summary>
        /// >> block_number
        /// </summary>
        private Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32> _blockNumber;
        
        public VARANET.NetApiExt.Generated.Model.primitive_types.H256 Author
        {
            get
            {
                return this._author;
            }
            set
            {
                this._author = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32> BlockNumber
        {
            get
            {
                return this._blockNumber;
            }
            set
            {
                this._blockNumber = value;
            }
        }
        
        public override string TypeName()
        {
            return "CodeMetadata";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Author.Encode());
            result.AddRange(BlockNumber.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Author = new VARANET.NetApiExt.Generated.Model.primitive_types.H256();
            Author.Decode(byteArray, ref p);
            BlockNumber = new Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>();
            BlockNumber.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
