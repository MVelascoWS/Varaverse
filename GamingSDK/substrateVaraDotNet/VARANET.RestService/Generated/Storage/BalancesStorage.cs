//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Model.Types.Base;
using Substrate.ServiceLayer.Attributes;
using Substrate.ServiceLayer.Storage;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace VARANET.RestService.Generated.Storage
{
    
    
    /// <summary>
    /// IBalancesStorage interface definition.
    /// </summary>
    public interface IBalancesStorage : IStorage
    {
        
        /// <summary>
        /// >> TotalIssuance
        ///  The total units issued in the system.
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U128 GetTotalIssuance();
        
        /// <summary>
        /// >> InactiveIssuance
        ///  The total units of outstanding deactivated balance in the system.
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U128 GetInactiveIssuance();
        
        /// <summary>
        /// >> Account
        ///  The Balances pallet example of storing the balance of an account.
        /// 
        ///  # Example
        /// 
        ///  ```nocompile
        ///   impl pallet_balances::Config for Runtime {
        ///     type AccountStore = StorageMapShim<Self::Account<Runtime>, frame_system::Provider<Runtime>, AccountId, Self::AccountData<Balance>>
        ///   }
        ///  ```
        /// 
        ///  You can also store the balance of an account in the `System` pallet.
        /// 
        ///  # Example
        /// 
        ///  ```nocompile
        ///   impl pallet_balances::Config for Runtime {
        ///    type AccountStore = System
        ///   }
        ///  ```
        /// 
        ///  But this comes with tradeoffs, storing account balances in the system pallet stores
        ///  `frame_system` data alongside the account data contrary to storing account balances in the
        ///  `Balances` pallet, which uses a `StorageMap` to store balances data only.
        ///  NOTE: This is only used in the case that this pallet is used to store balances.
        /// </summary>
        VARANET.NetApiExt.Generated.Model.pallet_balances.AccountData GetAccount(string key);
        
        /// <summary>
        /// >> Locks
        ///  Any liquidity locks on some account balances.
        ///  NOTE: Should only be accessed when setting, changing and freeing a lock.
        /// </summary>
        VARANET.NetApiExt.Generated.Model.bounded_collections.weak_bounded_vec.WeakBoundedVecT3 GetLocks(string key);
        
        /// <summary>
        /// >> Reserves
        ///  Named reserves on some account balances.
        /// </summary>
        VARANET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT3 GetReserves(string key);
    }
    
    /// <summary>
    /// BalancesStorage class definition.
    /// </summary>
    public sealed class BalancesStorage : IBalancesStorage
    {
        
        /// <summary>
        /// _totalIssuanceTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.NetApi.Model.Types.Primitive.U128> _totalIssuanceTypedStorage;
        
        /// <summary>
        /// _inactiveIssuanceTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.NetApi.Model.Types.Primitive.U128> _inactiveIssuanceTypedStorage;
        
        /// <summary>
        /// _accountTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<VARANET.NetApiExt.Generated.Model.pallet_balances.AccountData> _accountTypedStorage;
        
        /// <summary>
        /// _locksTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<VARANET.NetApiExt.Generated.Model.bounded_collections.weak_bounded_vec.WeakBoundedVecT3> _locksTypedStorage;
        
        /// <summary>
        /// _reservesTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<VARANET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT3> _reservesTypedStorage;
        
        /// <summary>
        /// BalancesStorage constructor.
        /// </summary>
        public BalancesStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.TotalIssuanceTypedStorage = new TypedStorage<Substrate.NetApi.Model.Types.Primitive.U128>("Balances.TotalIssuance", storageDataProvider, storageChangeDelegates);
            this.InactiveIssuanceTypedStorage = new TypedStorage<Substrate.NetApi.Model.Types.Primitive.U128>("Balances.InactiveIssuance", storageDataProvider, storageChangeDelegates);
            this.AccountTypedStorage = new TypedMapStorage<VARANET.NetApiExt.Generated.Model.pallet_balances.AccountData>("Balances.Account", storageDataProvider, storageChangeDelegates);
            this.LocksTypedStorage = new TypedMapStorage<VARANET.NetApiExt.Generated.Model.bounded_collections.weak_bounded_vec.WeakBoundedVecT3>("Balances.Locks", storageDataProvider, storageChangeDelegates);
            this.ReservesTypedStorage = new TypedMapStorage<VARANET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT3>("Balances.Reserves", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _totalIssuanceTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.NetApi.Model.Types.Primitive.U128> TotalIssuanceTypedStorage
        {
            get
            {
                return _totalIssuanceTypedStorage;
            }
            set
            {
                _totalIssuanceTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _inactiveIssuanceTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.NetApi.Model.Types.Primitive.U128> InactiveIssuanceTypedStorage
        {
            get
            {
                return _inactiveIssuanceTypedStorage;
            }
            set
            {
                _inactiveIssuanceTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _accountTypedStorage property
        /// </summary>
        public TypedMapStorage<VARANET.NetApiExt.Generated.Model.pallet_balances.AccountData> AccountTypedStorage
        {
            get
            {
                return _accountTypedStorage;
            }
            set
            {
                _accountTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _locksTypedStorage property
        /// </summary>
        public TypedMapStorage<VARANET.NetApiExt.Generated.Model.bounded_collections.weak_bounded_vec.WeakBoundedVecT3> LocksTypedStorage
        {
            get
            {
                return _locksTypedStorage;
            }
            set
            {
                _locksTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _reservesTypedStorage property
        /// </summary>
        public TypedMapStorage<VARANET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT3> ReservesTypedStorage
        {
            get
            {
                return _reservesTypedStorage;
            }
            set
            {
                _reservesTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Substrate.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await TotalIssuanceTypedStorage.InitializeAsync("Balances", "TotalIssuance");
            await InactiveIssuanceTypedStorage.InitializeAsync("Balances", "InactiveIssuance");
            await AccountTypedStorage.InitializeAsync("Balances", "Account");
            await LocksTypedStorage.InitializeAsync("Balances", "Locks");
            await ReservesTypedStorage.InitializeAsync("Balances", "Reserves");
        }
        
        /// <summary>
        /// Implements any storage change for Balances.TotalIssuance
        /// </summary>
        [StorageChange("Balances", "TotalIssuance")]
        public void OnUpdateTotalIssuance(string data)
        {
            TotalIssuanceTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> TotalIssuance
        ///  The total units issued in the system.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 GetTotalIssuance()
        {
            return TotalIssuanceTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for Balances.InactiveIssuance
        /// </summary>
        [StorageChange("Balances", "InactiveIssuance")]
        public void OnUpdateInactiveIssuance(string data)
        {
            InactiveIssuanceTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> InactiveIssuance
        ///  The total units of outstanding deactivated balance in the system.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 GetInactiveIssuance()
        {
            return InactiveIssuanceTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for Balances.Account
        /// </summary>
        [StorageChange("Balances", "Account")]
        public void OnUpdateAccount(string key, string data)
        {
            AccountTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Account
        ///  The Balances pallet example of storing the balance of an account.
        /// 
        ///  # Example
        /// 
        ///  ```nocompile
        ///   impl pallet_balances::Config for Runtime {
        ///     type AccountStore = StorageMapShim<Self::Account<Runtime>, frame_system::Provider<Runtime>, AccountId, Self::AccountData<Balance>>
        ///   }
        ///  ```
        /// 
        ///  You can also store the balance of an account in the `System` pallet.
        /// 
        ///  # Example
        /// 
        ///  ```nocompile
        ///   impl pallet_balances::Config for Runtime {
        ///    type AccountStore = System
        ///   }
        ///  ```
        /// 
        ///  But this comes with tradeoffs, storing account balances in the system pallet stores
        ///  `frame_system` data alongside the account data contrary to storing account balances in the
        ///  `Balances` pallet, which uses a `StorageMap` to store balances data only.
        ///  NOTE: This is only used in the case that this pallet is used to store balances.
        /// </summary>
        public VARANET.NetApiExt.Generated.Model.pallet_balances.AccountData GetAccount(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (AccountTypedStorage.Dictionary.TryGetValue(key, out VARANET.NetApiExt.Generated.Model.pallet_balances.AccountData result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Balances.Locks
        /// </summary>
        [StorageChange("Balances", "Locks")]
        public void OnUpdateLocks(string key, string data)
        {
            LocksTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Locks
        ///  Any liquidity locks on some account balances.
        ///  NOTE: Should only be accessed when setting, changing and freeing a lock.
        /// </summary>
        public VARANET.NetApiExt.Generated.Model.bounded_collections.weak_bounded_vec.WeakBoundedVecT3 GetLocks(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (LocksTypedStorage.Dictionary.TryGetValue(key, out VARANET.NetApiExt.Generated.Model.bounded_collections.weak_bounded_vec.WeakBoundedVecT3 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Balances.Reserves
        /// </summary>
        [StorageChange("Balances", "Reserves")]
        public void OnUpdateReserves(string key, string data)
        {
            ReservesTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Reserves
        ///  Named reserves on some account balances.
        /// </summary>
        public VARANET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT3 GetReserves(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (ReservesTypedStorage.Dictionary.TryGetValue(key, out VARANET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT3 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
    }
}
