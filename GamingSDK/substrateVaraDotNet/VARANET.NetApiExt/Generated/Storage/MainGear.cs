//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi;
using Substrate.NetApi.Model.Extrinsics;
using Substrate.NetApi.Model.Meta;
using Substrate.NetApi.Model.Types;
using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace VARANET.NetApiExt.Generated.Storage
{
    
    
    public sealed class GearStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        public GearStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Gear", "ExecuteInherent"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Model.Types.Primitive.Bool)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Gear", "BlockNumber"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Gear", "LastGearBlockNumber"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Model.Types.Primitive.U32)));
        }
        
        /// <summary>
        /// >> ExecuteInherentParams
        ///  A flag indicating whether the message queue should be processed at the end of a block
        /// 
        ///  If not set, the inherent extrinsic that processes the queue will keep throwing an error
        ///  thereby making the block builder exclude it from the block.
        /// </summary>
        public static string ExecuteInherentParams()
        {
            return RequestGenerator.GetStorage("Gear", "ExecuteInherent", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> ExecuteInherentDefault
        /// Default value as hex string
        /// </summary>
        public static string ExecuteInherentDefault()
        {
            return "0x01";
        }
        
        /// <summary>
        /// >> ExecuteInherent
        ///  A flag indicating whether the message queue should be processed at the end of a block
        /// 
        ///  If not set, the inherent extrinsic that processes the queue will keep throwing an error
        ///  thereby making the block builder exclude it from the block.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.Bool> ExecuteInherent(CancellationToken token)
        {
            string parameters = GearStorage.ExecuteInherentParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.Bool>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> BlockNumberParams
        ///  The current block number being processed.
        /// 
        ///  It shows block number in which queue is processed.
        ///  May be less than system pallet block number if panic occurred previously.
        /// </summary>
        public static string BlockNumberParams()
        {
            return RequestGenerator.GetStorage("Gear", "BlockNumber", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> BlockNumberDefault
        /// Default value as hex string
        /// </summary>
        public static string BlockNumberDefault()
        {
            return "0x00000000";
        }
        
        /// <summary>
        /// >> BlockNumber
        ///  The current block number being processed.
        /// 
        ///  It shows block number in which queue is processed.
        ///  May be less than system pallet block number if panic occurred previously.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U32> BlockNumber(CancellationToken token)
        {
            string parameters = GearStorage.BlockNumberParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U32>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> LastGearBlockNumberParams
        ///  The Gear block number before processing messages.
        /// 
        ///  A helper variable that mirrors the `BlockNumber` at the beginning of a block.
        ///  Allows to gauge the actual `BlockNumber` progress.
        /// </summary>
        public static string LastGearBlockNumberParams()
        {
            return RequestGenerator.GetStorage("Gear", "LastGearBlockNumber", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> LastGearBlockNumberDefault
        /// Default value as hex string
        /// </summary>
        public static string LastGearBlockNumberDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> LastGearBlockNumber
        ///  The Gear block number before processing messages.
        /// 
        ///  A helper variable that mirrors the `BlockNumber` at the beginning of a block.
        ///  Allows to gauge the actual `BlockNumber` progress.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U32> LastGearBlockNumber(CancellationToken token)
        {
            string parameters = GearStorage.LastGearBlockNumberParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U32>(parameters, token);
            return result;
        }
    }
    
    public sealed class GearCalls
    {
        
        /// <summary>
        /// >> upload_code
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method UploadCode(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> code)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(code.Encode());
            return new Method(104, "Gear", 0, "upload_code", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> upload_program
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method UploadProgram(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> code, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> salt, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> init_payload, Substrate.NetApi.Model.Types.Primitive.U64 gas_limit, Substrate.NetApi.Model.Types.Primitive.U128 value)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(code.Encode());
            byteArray.AddRange(salt.Encode());
            byteArray.AddRange(init_payload.Encode());
            byteArray.AddRange(gas_limit.Encode());
            byteArray.AddRange(value.Encode());
            return new Method(104, "Gear", 1, "upload_program", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> create_program
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method CreateProgram(VARANET.NetApiExt.Generated.Model.gear_core.ids.CodeId code_id, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> salt, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> init_payload, Substrate.NetApi.Model.Types.Primitive.U64 gas_limit, Substrate.NetApi.Model.Types.Primitive.U128 value)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(code_id.Encode());
            byteArray.AddRange(salt.Encode());
            byteArray.AddRange(init_payload.Encode());
            byteArray.AddRange(gas_limit.Encode());
            byteArray.AddRange(value.Encode());
            return new Method(104, "Gear", 2, "create_program", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> send_message
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method SendMessage(VARANET.NetApiExt.Generated.Model.gear_core.ids.ProgramId destination, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> payload, Substrate.NetApi.Model.Types.Primitive.U64 gas_limit, Substrate.NetApi.Model.Types.Primitive.U128 value)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(destination.Encode());
            byteArray.AddRange(payload.Encode());
            byteArray.AddRange(gas_limit.Encode());
            byteArray.AddRange(value.Encode());
            return new Method(104, "Gear", 3, "send_message", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> send_reply
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method SendReply(VARANET.NetApiExt.Generated.Model.gear_core.ids.MessageId reply_to_id, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> payload, Substrate.NetApi.Model.Types.Primitive.U64 gas_limit, Substrate.NetApi.Model.Types.Primitive.U128 value)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(reply_to_id.Encode());
            byteArray.AddRange(payload.Encode());
            byteArray.AddRange(gas_limit.Encode());
            byteArray.AddRange(value.Encode());
            return new Method(104, "Gear", 4, "send_reply", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> claim_value
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ClaimValue(VARANET.NetApiExt.Generated.Model.gear_core.ids.MessageId message_id)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(message_id.Encode());
            return new Method(104, "Gear", 5, "claim_value", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> run
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Run()
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            return new Method(104, "Gear", 6, "run", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_execute_inherent
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method SetExecuteInherent(Substrate.NetApi.Model.Types.Primitive.Bool value)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(value.Encode());
            return new Method(104, "Gear", 7, "set_execute_inherent", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> pay_program_rent
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method PayProgramRent(VARANET.NetApiExt.Generated.Model.gear_core.ids.ProgramId program_id, Substrate.NetApi.Model.Types.Primitive.U32 block_count)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(program_id.Encode());
            byteArray.AddRange(block_count.Encode());
            return new Method(104, "Gear", 8, "pay_program_rent", byteArray.ToArray());
        }
    }
    
    public sealed class GearConstants
    {
        
        /// <summary>
        /// >> Schedule
        ///  Cost schedule and limits.
        /// </summary>
        public VARANET.NetApiExt.Generated.Model.pallet_gear.schedule.Schedule Schedule()
        {
            var result = new VARANET.NetApiExt.Generated.Model.pallet_gear.schedule.Schedule();
            result.Create(@"0x00000100000004000080000000000200100000000100002000000020000000000080000000080006000000960000001A1A0000551A000023810000144A0000D41C0000BB180000850C0000E4160000D025000067010000E2110000DB4C00000C0900000000000077020000ED0500005E06000026070000B10A0000C2390000B41900004818000035180000E8140000DB04000010030000780E00003409000047030000CC0100005A010000FC0D00006F090000960E0000D4080000F20D000047090000080E000078090000BD0E0000C60800006C0E000080080000F60D0000AB080000000F00005D0800004E0D00002C080000E20D0000CD0800001B0A0000CD0400007709000029040000FD0C00006D090000010E0000BB0E00001A140000E31000008B4400006D370000F310000017120000A70900006204000040090000DF030000B4090000110500004C080000EE0300004B080000EC030000190800008F040000BF08000026040000C2070000380400007E40770000E6917500005A06F400003E11150100CAA6A700007EFAA400009EDBA40000C2F7A40000060F030000169EA50000FE0FAB00001EEEA700002EDAA800009E6EA80000225CE800008D020016B5A30000E2C2A500008A18DC0000AAD0440100CD0400363A460100C10400624BAB00002ECEF100009D06006A0A220100BEF92B01002E704F0100CD04004E2C2C010052810A0500C6EA8F0500EE82830300AEDB1D000022F5A803000E89E90000E2FF2F050075070052E9F404005D07008D0A0046C0A60000D203A80000AE9A480600BA8B46030042E2B50000C101008A8D5401003E46540100DEF5C000006102001AAAAA0000C90500CA14DC00005E39A30000267580060022AB91030076E4BF02004E39C90200DA34040400AE24F10000B621800100B10100251E00A663810100C101004D1E0076F8B006008E8A5D080032C9650200FE5DF7060006D77408005A0D2502004AF32302008235A518009101009101000000D92700350300050B00420B1243ED3C3E3A030000");
            return result;
        }
        
        /// <summary>
        /// >> OutgoingLimit
        ///  The maximum amount of messages that can be produced in single run.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 OutgoingLimit()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0x00040000");
            return result;
        }
        
        /// <summary>
        /// >> MailboxThreshold
        ///  The minimal gas amount for message to be inserted in mailbox.
        /// 
        ///  This gas will be consuming as rent for storing and message will be available
        ///  for reply or claim, once gas ends, message removes.
        /// 
        ///  Messages with gas limit less than that minimum will not be added in mailbox,
        ///  but will be seen in events.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U64 MailboxThreshold()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U64();
            result.Create("0xB80B000000000000");
            return result;
        }
        
        /// <summary>
        /// >> ReservationsLimit
        ///  Amount of reservations can exist for 1 program.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U64 ReservationsLimit()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U64();
            result.Create("0x0001000000000000");
            return result;
        }
        
        /// <summary>
        /// >> ProgramRentFreePeriod
        ///  The free of charge period of rent.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 ProgramRentFreePeriod()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0x404B4C00");
            return result;
        }
        
        /// <summary>
        /// >> ProgramRentMinimalResumePeriod
        ///  The minimal amount of blocks to resume.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 ProgramRentMinimalResumePeriod()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0x80510100");
            return result;
        }
        
        /// <summary>
        /// >> ProgramRentCostPerBlock
        ///  The program rent cost per block.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 ProgramRentCostPerBlock()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U128();
            result.Create("0x40597307000000000000000000000000");
            return result;
        }
    }
    
    public enum GearErrors
    {
        
        /// <summary>
        /// >> MessageNotFound
        /// Message wasn't found in the mailbox.
        /// </summary>
        MessageNotFound,
        
        /// <summary>
        /// >> InsufficientBalanceForReserve
        /// Not enough balance to reserve.
        /// 
        /// Usually occurs when the gas_limit specified is such that the origin account can't afford the message.
        /// </summary>
        InsufficientBalanceForReserve,
        
        /// <summary>
        /// >> GasLimitTooHigh
        /// Gas limit too high.
        /// 
        /// Occurs when an extrinsic's declared `gas_limit` is greater than a block's maximum gas limit.
        /// </summary>
        GasLimitTooHigh,
        
        /// <summary>
        /// >> ProgramAlreadyExists
        /// Program already exists.
        /// 
        /// Occurs if a program with some specific program id already exists in program storage.
        /// </summary>
        ProgramAlreadyExists,
        
        /// <summary>
        /// >> InactiveProgram
        /// Program is terminated.
        /// 
        /// Program init failed, so such message destination is no longer unavailable.
        /// </summary>
        InactiveProgram,
        
        /// <summary>
        /// >> NoMessageTree
        /// Message gas tree is not found.
        /// 
        /// When a message claimed from the mailbox has a corrupted or non-extant gas tree associated.
        /// </summary>
        NoMessageTree,
        
        /// <summary>
        /// >> CodeAlreadyExists
        /// Code already exists.
        /// 
        /// Occurs when trying to save to storage a program code that has been saved there.
        /// </summary>
        CodeAlreadyExists,
        
        /// <summary>
        /// >> CodeDoesntExist
        /// Code does not exist.
        /// 
        /// Occurs when trying to get a program code from storage, that doesn't exist.
        /// </summary>
        CodeDoesntExist,
        
        /// <summary>
        /// >> CodeTooLarge
        /// The code supplied to `upload_code` or `upload_program` exceeds the limit specified in the
        /// current schedule.
        /// </summary>
        CodeTooLarge,
        
        /// <summary>
        /// >> ProgramConstructionFailed
        /// Failed to create a program.
        /// </summary>
        ProgramConstructionFailed,
        
        /// <summary>
        /// >> ValueLessThanMinimal
        /// Value doesn't cover ExistentialDeposit.
        /// </summary>
        ValueLessThanMinimal,
        
        /// <summary>
        /// >> MessagesStorageCorrupted
        /// Messages storage corrupted.
        /// </summary>
        MessagesStorageCorrupted,
        
        /// <summary>
        /// >> MessageQueueProcessingDisabled
        /// Message queue processing is disabled.
        /// </summary>
        MessageQueueProcessingDisabled,
        
        /// <summary>
        /// >> ProgramNotFound
        /// Program with the specified id is not found.
        /// </summary>
        ProgramNotFound,
    }
}
