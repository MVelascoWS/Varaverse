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


namespace VARANET.NetApiExt.Generated.Model.gear_core.message.context
{
    
    
    /// <summary>
    /// >> 231 - Composite[gear_core.message.context.ContextStore]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class ContextStore : BaseType
    {
        
        /// <summary>
        /// >> outgoing
        /// </summary>
        private VARANET.NetApiExt.Generated.Types.Base.BTreeMapT3 _outgoing;
        
        /// <summary>
        /// >> reply
        /// </summary>
        private Substrate.NetApi.Model.Types.Base.BaseOpt<VARANET.NetApiExt.Generated.Model.gear_core.buffer.LimitedVecT1> _reply;
        
        /// <summary>
        /// >> initialized
        /// </summary>
        private VARANET.NetApiExt.Generated.Types.Base.BTreeSetT1 _initialized;
        
        /// <summary>
        /// >> awaken
        /// </summary>
        private VARANET.NetApiExt.Generated.Types.Base.BTreeSetT5 _awaken;
        
        /// <summary>
        /// >> reply_sent
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.Bool _replySent;
        
        /// <summary>
        /// >> reservation_nonce
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U64 _reservationNonce;
        
        /// <summary>
        /// >> system_reservation
        /// </summary>
        private Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U64> _systemReservation;
        
        public VARANET.NetApiExt.Generated.Types.Base.BTreeMapT3 Outgoing
        {
            get
            {
                return this._outgoing;
            }
            set
            {
                this._outgoing = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Base.BaseOpt<VARANET.NetApiExt.Generated.Model.gear_core.buffer.LimitedVecT1> Reply
        {
            get
            {
                return this._reply;
            }
            set
            {
                this._reply = value;
            }
        }
        
        public VARANET.NetApiExt.Generated.Types.Base.BTreeSetT1 Initialized
        {
            get
            {
                return this._initialized;
            }
            set
            {
                this._initialized = value;
            }
        }
        
        public VARANET.NetApiExt.Generated.Types.Base.BTreeSetT5 Awaken
        {
            get
            {
                return this._awaken;
            }
            set
            {
                this._awaken = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.Bool ReplySent
        {
            get
            {
                return this._replySent;
            }
            set
            {
                this._replySent = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U64 ReservationNonce
        {
            get
            {
                return this._reservationNonce;
            }
            set
            {
                this._reservationNonce = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U64> SystemReservation
        {
            get
            {
                return this._systemReservation;
            }
            set
            {
                this._systemReservation = value;
            }
        }
        
        public override string TypeName()
        {
            return "ContextStore";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Outgoing.Encode());
            result.AddRange(Reply.Encode());
            result.AddRange(Initialized.Encode());
            result.AddRange(Awaken.Encode());
            result.AddRange(ReplySent.Encode());
            result.AddRange(ReservationNonce.Encode());
            result.AddRange(SystemReservation.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Outgoing = new VARANET.NetApiExt.Generated.Types.Base.BTreeMapT3();
            Outgoing.Decode(byteArray, ref p);
            Reply = new Substrate.NetApi.Model.Types.Base.BaseOpt<VARANET.NetApiExt.Generated.Model.gear_core.buffer.LimitedVecT1>();
            Reply.Decode(byteArray, ref p);
            Initialized = new VARANET.NetApiExt.Generated.Types.Base.BTreeSetT1();
            Initialized.Decode(byteArray, ref p);
            Awaken = new VARANET.NetApiExt.Generated.Types.Base.BTreeSetT5();
            Awaken.Decode(byteArray, ref p);
            ReplySent = new Substrate.NetApi.Model.Types.Primitive.Bool();
            ReplySent.Decode(byteArray, ref p);
            ReservationNonce = new Substrate.NetApi.Model.Types.Primitive.U64();
            ReservationNonce.Decode(byteArray, ref p);
            SystemReservation = new Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U64>();
            SystemReservation.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
