//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.AspNetCore.Mvc;
using Substrate.NetApi.Model.Types.Base;
using Substrate.ServiceLayer.Attributes;
using System.Collections.Generic;
using System.Threading.Tasks;
using VARANET.RestService.Generated.Storage;


namespace VARANET.RestService.Generated.Controller
{
    
    
    /// <summary>
    /// BabeController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class BabeController : ControllerBase
    {
        
        private IBabeStorage _babeStorage;
        
        /// <summary>
        /// BabeController constructor.
        /// </summary>
        public BabeController(IBabeStorage babeStorage)
        {
            _babeStorage = babeStorage;
        }
        
        /// <summary>
        /// >> EpochIndex
        ///  Current epoch index.
        /// </summary>
        [HttpGet("EpochIndex")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U64), 200)]
        [StorageKeyBuilder(typeof(VARANET.NetApiExt.Generated.Storage.BabeStorage), "EpochIndexParams")]
        public IActionResult GetEpochIndex()
        {
            return this.Ok(_babeStorage.GetEpochIndex());
        }
        
        /// <summary>
        /// >> Authorities
        ///  Current epoch authorities.
        /// </summary>
        [HttpGet("Authorities")]
        [ProducesResponseType(typeof(VARANET.NetApiExt.Generated.Model.bounded_collections.weak_bounded_vec.WeakBoundedVecT1), 200)]
        [StorageKeyBuilder(typeof(VARANET.NetApiExt.Generated.Storage.BabeStorage), "AuthoritiesParams")]
        public IActionResult GetAuthorities()
        {
            return this.Ok(_babeStorage.GetAuthorities());
        }
        
        /// <summary>
        /// >> GenesisSlot
        ///  The slot at which the first epoch actually started. This is 0
        ///  until the first block of the chain.
        /// </summary>
        [HttpGet("GenesisSlot")]
        [ProducesResponseType(typeof(VARANET.NetApiExt.Generated.Model.sp_consensus_slots.Slot), 200)]
        [StorageKeyBuilder(typeof(VARANET.NetApiExt.Generated.Storage.BabeStorage), "GenesisSlotParams")]
        public IActionResult GetGenesisSlot()
        {
            return this.Ok(_babeStorage.GetGenesisSlot());
        }
        
        /// <summary>
        /// >> CurrentSlot
        ///  Current slot number.
        /// </summary>
        [HttpGet("CurrentSlot")]
        [ProducesResponseType(typeof(VARANET.NetApiExt.Generated.Model.sp_consensus_slots.Slot), 200)]
        [StorageKeyBuilder(typeof(VARANET.NetApiExt.Generated.Storage.BabeStorage), "CurrentSlotParams")]
        public IActionResult GetCurrentSlot()
        {
            return this.Ok(_babeStorage.GetCurrentSlot());
        }
        
        /// <summary>
        /// >> Randomness
        ///  The epoch randomness for the *current* epoch.
        /// 
        ///  # Security
        /// 
        ///  This MUST NOT be used for gambling, as it can be influenced by a
        ///  malicious validator in the short term. It MAY be used in many
        ///  cryptographic protocols, however, so long as one remembers that this
        ///  (like everything else on-chain) it is public. For example, it can be
        ///  used where a number is needed that cannot have been chosen by an
        ///  adversary, for purposes such as public-coin zero-knowledge proofs.
        /// </summary>
        [HttpGet("Randomness")]
        [ProducesResponseType(typeof(VARANET.NetApiExt.Generated.Types.Base.Arr32U8), 200)]
        [StorageKeyBuilder(typeof(VARANET.NetApiExt.Generated.Storage.BabeStorage), "RandomnessParams")]
        public IActionResult GetRandomness()
        {
            return this.Ok(_babeStorage.GetRandomness());
        }
        
        /// <summary>
        /// >> PendingEpochConfigChange
        ///  Pending epoch configuration change that will be applied when the next epoch is enacted.
        /// </summary>
        [HttpGet("PendingEpochConfigChange")]
        [ProducesResponseType(typeof(VARANET.NetApiExt.Generated.Model.sp_consensus_babe.digests.EnumNextConfigDescriptor), 200)]
        [StorageKeyBuilder(typeof(VARANET.NetApiExt.Generated.Storage.BabeStorage), "PendingEpochConfigChangeParams")]
        public IActionResult GetPendingEpochConfigChange()
        {
            return this.Ok(_babeStorage.GetPendingEpochConfigChange());
        }
        
        /// <summary>
        /// >> NextRandomness
        ///  Next epoch randomness.
        /// </summary>
        [HttpGet("NextRandomness")]
        [ProducesResponseType(typeof(VARANET.NetApiExt.Generated.Types.Base.Arr32U8), 200)]
        [StorageKeyBuilder(typeof(VARANET.NetApiExt.Generated.Storage.BabeStorage), "NextRandomnessParams")]
        public IActionResult GetNextRandomness()
        {
            return this.Ok(_babeStorage.GetNextRandomness());
        }
        
        /// <summary>
        /// >> NextAuthorities
        ///  Next epoch authorities.
        /// </summary>
        [HttpGet("NextAuthorities")]
        [ProducesResponseType(typeof(VARANET.NetApiExt.Generated.Model.bounded_collections.weak_bounded_vec.WeakBoundedVecT1), 200)]
        [StorageKeyBuilder(typeof(VARANET.NetApiExt.Generated.Storage.BabeStorage), "NextAuthoritiesParams")]
        public IActionResult GetNextAuthorities()
        {
            return this.Ok(_babeStorage.GetNextAuthorities());
        }
        
        /// <summary>
        /// >> SegmentIndex
        ///  Randomness under construction.
        /// 
        ///  We make a trade-off between storage accesses and list length.
        ///  We store the under-construction randomness in segments of up to
        ///  `UNDER_CONSTRUCTION_SEGMENT_LENGTH`.
        /// 
        ///  Once a segment reaches this length, we begin the next one.
        ///  We reset all segments and return to `0` at the beginning of every
        ///  epoch.
        /// </summary>
        [HttpGet("SegmentIndex")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(VARANET.NetApiExt.Generated.Storage.BabeStorage), "SegmentIndexParams")]
        public IActionResult GetSegmentIndex()
        {
            return this.Ok(_babeStorage.GetSegmentIndex());
        }
        
        /// <summary>
        /// >> UnderConstruction
        ///  TWOX-NOTE: `SegmentIndex` is an increasing integer, so this is okay.
        /// </summary>
        [HttpGet("UnderConstruction")]
        [ProducesResponseType(typeof(VARANET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT1), 200)]
        [StorageKeyBuilder(typeof(VARANET.NetApiExt.Generated.Storage.BabeStorage), "UnderConstructionParams", typeof(Substrate.NetApi.Model.Types.Primitive.U32))]
        public IActionResult GetUnderConstruction(string key)
        {
            return this.Ok(_babeStorage.GetUnderConstruction(key));
        }
        
        /// <summary>
        /// >> Initialized
        ///  Temporary value (cleared at block finalization) which is `Some`
        ///  if per-block initialization has already been called for current block.
        /// </summary>
        [HttpGet("Initialized")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Base.BaseOpt<VARANET.NetApiExt.Generated.Model.sp_consensus_babe.digests.EnumPreDigest>), 200)]
        [StorageKeyBuilder(typeof(VARANET.NetApiExt.Generated.Storage.BabeStorage), "InitializedParams")]
        public IActionResult GetInitialized()
        {
            return this.Ok(_babeStorage.GetInitialized());
        }
        
        /// <summary>
        /// >> AuthorVrfRandomness
        ///  This field should always be populated during block processing unless
        ///  secondary plain slots are enabled (which don't contain a VRF output).
        /// 
        ///  It is set in `on_finalize`, before it will contain the value from the last block.
        /// </summary>
        [HttpGet("AuthorVrfRandomness")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Base.BaseOpt<VARANET.NetApiExt.Generated.Types.Base.Arr32U8>), 200)]
        [StorageKeyBuilder(typeof(VARANET.NetApiExt.Generated.Storage.BabeStorage), "AuthorVrfRandomnessParams")]
        public IActionResult GetAuthorVrfRandomness()
        {
            return this.Ok(_babeStorage.GetAuthorVrfRandomness());
        }
        
        /// <summary>
        /// >> EpochStart
        ///  The block numbers when the last and current epoch have started, respectively `N-1` and
        ///  `N`.
        ///  NOTE: We track this is in order to annotate the block number when a given pool of
        ///  entropy was fixed (i.e. it was known to chain observers). Since epochs are defined in
        ///  slots, which may be skipped, the block numbers may not line up with the slot numbers.
        /// </summary>
        [HttpGet("EpochStart")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>), 200)]
        [StorageKeyBuilder(typeof(VARANET.NetApiExt.Generated.Storage.BabeStorage), "EpochStartParams")]
        public IActionResult GetEpochStart()
        {
            return this.Ok(_babeStorage.GetEpochStart());
        }
        
        /// <summary>
        /// >> Lateness
        ///  How late the current block is compared to its parent.
        /// 
        ///  This entry is populated as part of block execution and is cleaned up
        ///  on block finalization. Querying this storage entry outside of block
        ///  execution context should always yield zero.
        /// </summary>
        [HttpGet("Lateness")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(VARANET.NetApiExt.Generated.Storage.BabeStorage), "LatenessParams")]
        public IActionResult GetLateness()
        {
            return this.Ok(_babeStorage.GetLateness());
        }
        
        /// <summary>
        /// >> EpochConfig
        ///  The configuration for the current epoch. Should never be `None` as it is initialized in
        ///  genesis.
        /// </summary>
        [HttpGet("EpochConfig")]
        [ProducesResponseType(typeof(VARANET.NetApiExt.Generated.Model.sp_consensus_babe.BabeEpochConfiguration), 200)]
        [StorageKeyBuilder(typeof(VARANET.NetApiExt.Generated.Storage.BabeStorage), "EpochConfigParams")]
        public IActionResult GetEpochConfig()
        {
            return this.Ok(_babeStorage.GetEpochConfig());
        }
        
        /// <summary>
        /// >> NextEpochConfig
        ///  The configuration for the next epoch, `None` if the config will not change
        ///  (you can fallback to `EpochConfig` instead in that case).
        /// </summary>
        [HttpGet("NextEpochConfig")]
        [ProducesResponseType(typeof(VARANET.NetApiExt.Generated.Model.sp_consensus_babe.BabeEpochConfiguration), 200)]
        [StorageKeyBuilder(typeof(VARANET.NetApiExt.Generated.Storage.BabeStorage), "NextEpochConfigParams")]
        public IActionResult GetNextEpochConfig()
        {
            return this.Ok(_babeStorage.GetNextEpochConfig());
        }
        
        /// <summary>
        /// >> SkippedEpochs
        ///  A list of the last 100 skipped epochs and the corresponding session index
        ///  when the epoch was skipped.
        /// 
        ///  This is only used for validating equivocation proofs. An equivocation proof
        ///  must contains a key-ownership proof for a given session, therefore we need a
        ///  way to tie together sessions and epoch indices, i.e. we need to validate that
        ///  a validator was the owner of a given key on a given session, and what the
        ///  active epoch index was during that session.
        /// </summary>
        [HttpGet("SkippedEpochs")]
        [ProducesResponseType(typeof(VARANET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT2), 200)]
        [StorageKeyBuilder(typeof(VARANET.NetApiExt.Generated.Storage.BabeStorage), "SkippedEpochsParams")]
        public IActionResult GetSkippedEpochs()
        {
            return this.Ok(_babeStorage.GetSkippedEpochs());
        }
    }
}
