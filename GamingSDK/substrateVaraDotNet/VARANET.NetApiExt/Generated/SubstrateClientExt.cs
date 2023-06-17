//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Model.Extrinsics;
using Substrate.NetApi.Model.Meta;
using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;
using VARANET.NetApiExt.Generated.Storage;


namespace VARANET.NetApiExt.Generated
{
    
    
    public sealed class SubstrateClientExt : Substrate.NetApi.SubstrateClient
    {
        
        /// <summary>
        /// StorageKeyDict for key definition informations.
        /// </summary>
        public System.Collections.Generic.Dictionary<System.Tuple<string, string>, System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>> StorageKeyDict;
        
        /// <summary>
        /// SystemStorage storage calls.
        /// </summary>
        public SystemStorage SystemStorage;
        
        /// <summary>
        /// TimestampStorage storage calls.
        /// </summary>
        public TimestampStorage TimestampStorage;
        
        /// <summary>
        /// AuthorshipStorage storage calls.
        /// </summary>
        public AuthorshipStorage AuthorshipStorage;
        
        /// <summary>
        /// BabeStorage storage calls.
        /// </summary>
        public BabeStorage BabeStorage;
        
        /// <summary>
        /// GrandpaStorage storage calls.
        /// </summary>
        public GrandpaStorage GrandpaStorage;
        
        /// <summary>
        /// BalancesStorage storage calls.
        /// </summary>
        public BalancesStorage BalancesStorage;
        
        /// <summary>
        /// TransactionPaymentStorage storage calls.
        /// </summary>
        public TransactionPaymentStorage TransactionPaymentStorage;
        
        /// <summary>
        /// SessionStorage storage calls.
        /// </summary>
        public SessionStorage SessionStorage;
        
        /// <summary>
        /// UtilityStorage storage calls.
        /// </summary>
        public UtilityStorage UtilityStorage;
        
        /// <summary>
        /// ProxyStorage storage calls.
        /// </summary>
        public ProxyStorage ProxyStorage;
        
        /// <summary>
        /// MultisigStorage storage calls.
        /// </summary>
        public MultisigStorage MultisigStorage;
        
        /// <summary>
        /// ValidatorSetStorage storage calls.
        /// </summary>
        public ValidatorSetStorage ValidatorSetStorage;
        
        /// <summary>
        /// SudoStorage storage calls.
        /// </summary>
        public SudoStorage SudoStorage;
        
        /// <summary>
        /// GearProgramStorage storage calls.
        /// </summary>
        public GearProgramStorage GearProgramStorage;
        
        /// <summary>
        /// GearMessengerStorage storage calls.
        /// </summary>
        public GearMessengerStorage GearMessengerStorage;
        
        /// <summary>
        /// GearSchedulerStorage storage calls.
        /// </summary>
        public GearSchedulerStorage GearSchedulerStorage;
        
        /// <summary>
        /// GearGasStorage storage calls.
        /// </summary>
        public GearGasStorage GearGasStorage;
        
        /// <summary>
        /// GearStorage storage calls.
        /// </summary>
        public GearStorage GearStorage;
        
        /// <summary>
        /// GearPaymentStorage storage calls.
        /// </summary>
        public GearPaymentStorage GearPaymentStorage;
        
        public SubstrateClientExt(System.Uri uri, Substrate.NetApi.Model.Extrinsics.ChargeType chargeType) : 
                base(uri, chargeType)
        {
            StorageKeyDict = new System.Collections.Generic.Dictionary<System.Tuple<string, string>, System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>>();
            this.SystemStorage = new SystemStorage(this);
            this.TimestampStorage = new TimestampStorage(this);
            this.AuthorshipStorage = new AuthorshipStorage(this);
            this.BabeStorage = new BabeStorage(this);
            this.GrandpaStorage = new GrandpaStorage(this);
            this.BalancesStorage = new BalancesStorage(this);
            this.TransactionPaymentStorage = new TransactionPaymentStorage(this);
            this.SessionStorage = new SessionStorage(this);
            this.UtilityStorage = new UtilityStorage(this);
            this.ProxyStorage = new ProxyStorage(this);
            this.MultisigStorage = new MultisigStorage(this);
            this.ValidatorSetStorage = new ValidatorSetStorage(this);
            this.SudoStorage = new SudoStorage(this);
            this.GearProgramStorage = new GearProgramStorage(this);
            this.GearMessengerStorage = new GearMessengerStorage(this);
            this.GearSchedulerStorage = new GearSchedulerStorage(this);
            this.GearGasStorage = new GearGasStorage(this);
            this.GearStorage = new GearStorage(this);
            this.GearPaymentStorage = new GearPaymentStorage(this);
        }
    }
}
