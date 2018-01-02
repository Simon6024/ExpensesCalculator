﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExpensesCalculator
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Transactions")]
	public partial class TransactionsDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAccount_Type(Account_Type instance);
    partial void UpdateAccount_Type(Account_Type instance);
    partial void DeleteAccount_Type(Account_Type instance);
    partial void InsertCategory(Category instance);
    partial void UpdateCategory(Category instance);
    partial void DeleteCategory(Category instance);
    partial void InsertTransaction_Type(Transaction_Type instance);
    partial void UpdateTransaction_Type(Transaction_Type instance);
    partial void DeleteTransaction_Type(Transaction_Type instance);
    partial void InsertTransaction(Transaction instance);
    partial void UpdateTransaction(Transaction instance);
    partial void DeleteTransaction(Transaction instance);
    partial void InsertTypeCategory(TypeCategory instance);
    partial void UpdateTypeCategory(TypeCategory instance);
    partial void DeleteTypeCategory(TypeCategory instance);
    partial void InsertSource(Source instance);
    partial void UpdateSource(Source instance);
    partial void DeleteSource(Source instance);
    partial void InsertAccount(Account instance);
    partial void UpdateAccount(Account instance);
    partial void DeleteAccount(Account instance);
    #endregion
		
		public TransactionsDataContext() : 
				base(global::ExpensesCalculator.Properties.Settings.Default.TransactionsConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public TransactionsDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TransactionsDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TransactionsDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TransactionsDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Account_Type> Account_Types
		{
			get
			{
				return this.GetTable<Account_Type>();
			}
		}
		
		public System.Data.Linq.Table<Category> Categories
		{
			get
			{
				return this.GetTable<Category>();
			}
		}
		
		public System.Data.Linq.Table<Transaction_Type> Transaction_Types
		{
			get
			{
				return this.GetTable<Transaction_Type>();
			}
		}
		
		public System.Data.Linq.Table<Transaction> Transactions
		{
			get
			{
				return this.GetTable<Transaction>();
			}
		}
		
		public System.Data.Linq.Table<TypeCategory> TypeCategories
		{
			get
			{
				return this.GetTable<TypeCategory>();
			}
		}
		
		public System.Data.Linq.Table<Source> Sources
		{
			get
			{
				return this.GetTable<Source>();
			}
		}
		
		public System.Data.Linq.Table<Account> Accounts
		{
			get
			{
				return this.GetTable<Account>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="trx.Account_Types")]
	public partial class Account_Type : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _ACCOUNT_TYPE;
		
		private EntitySet<Account> _Accounts;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnACCOUNT_TYPEChanging(string value);
    partial void OnACCOUNT_TYPEChanged();
    #endregion
		
		public Account_Type()
		{
			this._Accounts = new EntitySet<Account>(new Action<Account>(this.attach_Accounts), new Action<Account>(this.detach_Accounts));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ACCOUNT_TYPE", DbType="VarChar(255) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string ACCOUNT_TYPE
		{
			get
			{
				return this._ACCOUNT_TYPE;
			}
			set
			{
				if ((this._ACCOUNT_TYPE != value))
				{
					this.OnACCOUNT_TYPEChanging(value);
					this.SendPropertyChanging();
					this._ACCOUNT_TYPE = value;
					this.SendPropertyChanged("ACCOUNT_TYPE");
					this.OnACCOUNT_TYPEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Account_Type_Account", Storage="_Accounts", ThisKey="ACCOUNT_TYPE", OtherKey="ACCOUNT_TYPE_FK")]
		public EntitySet<Account> Accounts
		{
			get
			{
				return this._Accounts;
			}
			set
			{
				this._Accounts.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Accounts(Account entity)
		{
			this.SendPropertyChanging();
			entity.Account_Type = this;
		}
		
		private void detach_Accounts(Account entity)
		{
			this.SendPropertyChanging();
			entity.Account_Type = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="trx.Categories")]
	public partial class Category : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _CATEGORY;
		
		private EntitySet<TypeCategory> _TypeCategories;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCATEGORYChanging(string value);
    partial void OnCATEGORYChanged();
    #endregion
		
		public Category()
		{
			this._TypeCategories = new EntitySet<TypeCategory>(new Action<TypeCategory>(this.attach_TypeCategories), new Action<TypeCategory>(this.detach_TypeCategories));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CATEGORY", DbType="VarChar(255) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string CATEGORY
		{
			get
			{
				return this._CATEGORY;
			}
			set
			{
				if ((this._CATEGORY != value))
				{
					this.OnCATEGORYChanging(value);
					this.SendPropertyChanging();
					this._CATEGORY = value;
					this.SendPropertyChanged("CATEGORY");
					this.OnCATEGORYChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Category_TypeCategory", Storage="_TypeCategories", ThisKey="CATEGORY", OtherKey="CATEGORY_FK")]
		public EntitySet<TypeCategory> TypeCategories
		{
			get
			{
				return this._TypeCategories;
			}
			set
			{
				this._TypeCategories.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_TypeCategories(TypeCategory entity)
		{
			this.SendPropertyChanging();
			entity.Category = this;
		}
		
		private void detach_TypeCategories(TypeCategory entity)
		{
			this.SendPropertyChanging();
			entity.Category = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="trx.Transaction_Type")]
	public partial class Transaction_Type : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID_TRX_TYPE;
		
		private string _COMMENT;
		
		private EntitySet<Transaction> _Transactions;
		
		private EntitySet<TypeCategory> _TypeCategories;
		
		private EntitySet<Source> _Sources;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnID_TRX_TYPEChanging(int value);
    partial void OnID_TRX_TYPEChanged();
    partial void OnCOMMENTChanging(string value);
    partial void OnCOMMENTChanged();
    #endregion
		
		public Transaction_Type()
		{
			this._Transactions = new EntitySet<Transaction>(new Action<Transaction>(this.attach_Transactions), new Action<Transaction>(this.detach_Transactions));
			this._TypeCategories = new EntitySet<TypeCategory>(new Action<TypeCategory>(this.attach_TypeCategories), new Action<TypeCategory>(this.detach_TypeCategories));
			this._Sources = new EntitySet<Source>(new Action<Source>(this.attach_Sources), new Action<Source>(this.detach_Sources));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_TRX_TYPE", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID_TRX_TYPE
		{
			get
			{
				return this._ID_TRX_TYPE;
			}
			set
			{
				if ((this._ID_TRX_TYPE != value))
				{
					this.OnID_TRX_TYPEChanging(value);
					this.SendPropertyChanging();
					this._ID_TRX_TYPE = value;
					this.SendPropertyChanged("ID_TRX_TYPE");
					this.OnID_TRX_TYPEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_COMMENT", DbType="VarChar(255)")]
		public string COMMENT
		{
			get
			{
				return this._COMMENT;
			}
			set
			{
				if ((this._COMMENT != value))
				{
					this.OnCOMMENTChanging(value);
					this.SendPropertyChanging();
					this._COMMENT = value;
					this.SendPropertyChanged("COMMENT");
					this.OnCOMMENTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Transaction_Type_Transaction", Storage="_Transactions", ThisKey="ID_TRX_TYPE", OtherKey="ID_TRX_TYPE_FK")]
		public EntitySet<Transaction> Transactions
		{
			get
			{
				return this._Transactions;
			}
			set
			{
				this._Transactions.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Transaction_Type_TypeCategory", Storage="_TypeCategories", ThisKey="ID_TRX_TYPE", OtherKey="ID_TRX_TYPE_FK")]
		public EntitySet<TypeCategory> TypeCategories
		{
			get
			{
				return this._TypeCategories;
			}
			set
			{
				this._TypeCategories.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Transaction_Type_Source", Storage="_Sources", ThisKey="ID_TRX_TYPE", OtherKey="ID_TRX_TYPE_FK")]
		public EntitySet<Source> Sources
		{
			get
			{
				return this._Sources;
			}
			set
			{
				this._Sources.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Transactions(Transaction entity)
		{
			this.SendPropertyChanging();
			entity.Transaction_Type = this;
		}
		
		private void detach_Transactions(Transaction entity)
		{
			this.SendPropertyChanging();
			entity.Transaction_Type = null;
		}
		
		private void attach_TypeCategories(TypeCategory entity)
		{
			this.SendPropertyChanging();
			entity.Transaction_Type = this;
		}
		
		private void detach_TypeCategories(TypeCategory entity)
		{
			this.SendPropertyChanging();
			entity.Transaction_Type = null;
		}
		
		private void attach_Sources(Source entity)
		{
			this.SendPropertyChanging();
			entity.Transaction_Type = this;
		}
		
		private void detach_Sources(Source entity)
		{
			this.SendPropertyChanging();
			entity.Transaction_Type = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="trx.Transactions")]
	public partial class Transaction : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.DateTime _DATE;
		
		private string _ACCOUNT_FK;
		
		private decimal _AMOUNT;
		
		private string _COMMENT;
		
		private System.Nullable<int> _ID_TRX_TYPE_FK;
		
		private string _SOURCE_FK;
		
		private int _ID_TRX;
		
		private bool _TYPE_FROM_SOURCE;
		
		private EntityRef<Transaction_Type> _Transaction_Type;
		
		private EntityRef<Source> _Source;
		
		private EntityRef<Account> _Account;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnDATEChanging(System.DateTime value);
    partial void OnDATEChanged();
    partial void OnACCOUNT_FKChanging(string value);
    partial void OnACCOUNT_FKChanged();
    partial void OnAMOUNTChanging(decimal value);
    partial void OnAMOUNTChanged();
    partial void OnCOMMENTChanging(string value);
    partial void OnCOMMENTChanged();
    partial void OnID_TRX_TYPE_FKChanging(System.Nullable<int> value);
    partial void OnID_TRX_TYPE_FKChanged();
    partial void OnSOURCE_FKChanging(string value);
    partial void OnSOURCE_FKChanged();
    partial void OnID_TRXChanging(int value);
    partial void OnID_TRXChanged();
    partial void OnTYPE_FROM_SOURCEChanging(bool value);
    partial void OnTYPE_FROM_SOURCEChanged();
    #endregion
		
		public Transaction()
		{
			this._Transaction_Type = default(EntityRef<Transaction_Type>);
			this._Source = default(EntityRef<Source>);
			this._Account = default(EntityRef<Account>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DATE", DbType="DateTime NOT NULL")]
		public System.DateTime DATE
		{
			get
			{
				return this._DATE;
			}
			set
			{
				if ((this._DATE != value))
				{
					this.OnDATEChanging(value);
					this.SendPropertyChanging();
					this._DATE = value;
					this.SendPropertyChanged("DATE");
					this.OnDATEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ACCOUNT_FK", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string ACCOUNT_FK
		{
			get
			{
				return this._ACCOUNT_FK;
			}
			set
			{
				if ((this._ACCOUNT_FK != value))
				{
					if (this._Account.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnACCOUNT_FKChanging(value);
					this.SendPropertyChanging();
					this._ACCOUNT_FK = value;
					this.SendPropertyChanged("ACCOUNT_FK");
					this.OnACCOUNT_FKChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AMOUNT", DbType="Money NOT NULL")]
		public decimal AMOUNT
		{
			get
			{
				return this._AMOUNT;
			}
			set
			{
				if ((this._AMOUNT != value))
				{
					this.OnAMOUNTChanging(value);
					this.SendPropertyChanging();
					this._AMOUNT = value;
					this.SendPropertyChanged("AMOUNT");
					this.OnAMOUNTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_COMMENT", DbType="VarChar(255)")]
		public string COMMENT
		{
			get
			{
				return this._COMMENT;
			}
			set
			{
				if ((this._COMMENT != value))
				{
					this.OnCOMMENTChanging(value);
					this.SendPropertyChanging();
					this._COMMENT = value;
					this.SendPropertyChanged("COMMENT");
					this.OnCOMMENTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_TRX_TYPE_FK", DbType="Int")]
		public System.Nullable<int> ID_TRX_TYPE_FK
		{
			get
			{
				return this._ID_TRX_TYPE_FK;
			}
			set
			{
				if ((this._ID_TRX_TYPE_FK != value))
				{
					if (this._Transaction_Type.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnID_TRX_TYPE_FKChanging(value);
					this.SendPropertyChanging();
					this._ID_TRX_TYPE_FK = value;
					this.SendPropertyChanged("ID_TRX_TYPE_FK");
					this.OnID_TRX_TYPE_FKChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SOURCE_FK", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string SOURCE_FK
		{
			get
			{
				return this._SOURCE_FK;
			}
			set
			{
				if ((this._SOURCE_FK != value))
				{
					if (this._Source.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnSOURCE_FKChanging(value);
					this.SendPropertyChanging();
					this._SOURCE_FK = value;
					this.SendPropertyChanged("SOURCE_FK");
					this.OnSOURCE_FKChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_TRX", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID_TRX
		{
			get
			{
				return this._ID_TRX;
			}
			set
			{
				if ((this._ID_TRX != value))
				{
					this.OnID_TRXChanging(value);
					this.SendPropertyChanging();
					this._ID_TRX = value;
					this.SendPropertyChanged("ID_TRX");
					this.OnID_TRXChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TYPE_FROM_SOURCE", DbType="Bit NOT NULL")]
		public bool TYPE_FROM_SOURCE
		{
			get
			{
				return this._TYPE_FROM_SOURCE;
			}
			set
			{
				if ((this._TYPE_FROM_SOURCE != value))
				{
					this.OnTYPE_FROM_SOURCEChanging(value);
					this.SendPropertyChanging();
					this._TYPE_FROM_SOURCE = value;
					this.SendPropertyChanged("TYPE_FROM_SOURCE");
					this.OnTYPE_FROM_SOURCEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Transaction_Type_Transaction", Storage="_Transaction_Type", ThisKey="ID_TRX_TYPE_FK", OtherKey="ID_TRX_TYPE", IsForeignKey=true)]
		public Transaction_Type Transaction_Type
		{
			get
			{
				return this._Transaction_Type.Entity;
			}
			set
			{
				Transaction_Type previousValue = this._Transaction_Type.Entity;
				if (((previousValue != value) 
							|| (this._Transaction_Type.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Transaction_Type.Entity = null;
						previousValue.Transactions.Remove(this);
					}
					this._Transaction_Type.Entity = value;
					if ((value != null))
					{
						value.Transactions.Add(this);
						this._ID_TRX_TYPE_FK = value.ID_TRX_TYPE;
					}
					else
					{
						this._ID_TRX_TYPE_FK = default(Nullable<int>);
					}
					this.SendPropertyChanged("Transaction_Type");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Source_Transaction", Storage="_Source", ThisKey="SOURCE_FK", OtherKey="NAME", IsForeignKey=true)]
		public Source Source
		{
			get
			{
				return this._Source.Entity;
			}
			set
			{
				Source previousValue = this._Source.Entity;
				if (((previousValue != value) 
							|| (this._Source.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Source.Entity = null;
						previousValue.Transactions.Remove(this);
					}
					this._Source.Entity = value;
					if ((value != null))
					{
						value.Transactions.Add(this);
						this._SOURCE_FK = value.NAME;
					}
					else
					{
						this._SOURCE_FK = default(string);
					}
					this.SendPropertyChanged("Source");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Account_Transaction", Storage="_Account", ThisKey="ACCOUNT_FK", OtherKey="ACCOUNT", IsForeignKey=true)]
		public Account Account
		{
			get
			{
				return this._Account.Entity;
			}
			set
			{
				Account previousValue = this._Account.Entity;
				if (((previousValue != value) 
							|| (this._Account.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Account.Entity = null;
						previousValue.Transactions.Remove(this);
					}
					this._Account.Entity = value;
					if ((value != null))
					{
						value.Transactions.Add(this);
						this._ACCOUNT_FK = value.ACCOUNT;
					}
					else
					{
						this._ACCOUNT_FK = default(string);
					}
					this.SendPropertyChanged("Account");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="trx.TypeCategories")]
	public partial class TypeCategory : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Nullable<int> _ID_TRX_TYPE_FK;
		
		private string _CATEGORY_FK;
		
		private decimal _PERCENTAGE;
		
		private int _ID_TYP_CAT;
		
		private EntityRef<Category> _Category;
		
		private EntityRef<Transaction_Type> _Transaction_Type;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnID_TRX_TYPE_FKChanging(System.Nullable<int> value);
    partial void OnID_TRX_TYPE_FKChanged();
    partial void OnCATEGORY_FKChanging(string value);
    partial void OnCATEGORY_FKChanged();
    partial void OnPERCENTAGEChanging(decimal value);
    partial void OnPERCENTAGEChanged();
    partial void OnID_TYP_CATChanging(int value);
    partial void OnID_TYP_CATChanged();
    #endregion
		
		public TypeCategory()
		{
			this._Category = default(EntityRef<Category>);
			this._Transaction_Type = default(EntityRef<Transaction_Type>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_TRX_TYPE_FK", DbType="Int")]
		public System.Nullable<int> ID_TRX_TYPE_FK
		{
			get
			{
				return this._ID_TRX_TYPE_FK;
			}
			set
			{
				if ((this._ID_TRX_TYPE_FK != value))
				{
					if (this._Transaction_Type.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnID_TRX_TYPE_FKChanging(value);
					this.SendPropertyChanging();
					this._ID_TRX_TYPE_FK = value;
					this.SendPropertyChanged("ID_TRX_TYPE_FK");
					this.OnID_TRX_TYPE_FKChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CATEGORY_FK", DbType="VarChar(255)")]
		public string CATEGORY_FK
		{
			get
			{
				return this._CATEGORY_FK;
			}
			set
			{
				if ((this._CATEGORY_FK != value))
				{
					if (this._Category.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCATEGORY_FKChanging(value);
					this.SendPropertyChanging();
					this._CATEGORY_FK = value;
					this.SendPropertyChanged("CATEGORY_FK");
					this.OnCATEGORY_FKChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PERCENTAGE", DbType="Decimal(5,2) NOT NULL")]
		public decimal PERCENTAGE
		{
			get
			{
				return this._PERCENTAGE;
			}
			set
			{
				if ((this._PERCENTAGE != value))
				{
					this.OnPERCENTAGEChanging(value);
					this.SendPropertyChanging();
					this._PERCENTAGE = value;
					this.SendPropertyChanged("PERCENTAGE");
					this.OnPERCENTAGEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_TYP_CAT", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID_TYP_CAT
		{
			get
			{
				return this._ID_TYP_CAT;
			}
			set
			{
				if ((this._ID_TYP_CAT != value))
				{
					this.OnID_TYP_CATChanging(value);
					this.SendPropertyChanging();
					this._ID_TYP_CAT = value;
					this.SendPropertyChanged("ID_TYP_CAT");
					this.OnID_TYP_CATChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Category_TypeCategory", Storage="_Category", ThisKey="CATEGORY_FK", OtherKey="CATEGORY", IsForeignKey=true)]
		public Category Category
		{
			get
			{
				return this._Category.Entity;
			}
			set
			{
				Category previousValue = this._Category.Entity;
				if (((previousValue != value) 
							|| (this._Category.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Category.Entity = null;
						previousValue.TypeCategories.Remove(this);
					}
					this._Category.Entity = value;
					if ((value != null))
					{
						value.TypeCategories.Add(this);
						this._CATEGORY_FK = value.CATEGORY;
					}
					else
					{
						this._CATEGORY_FK = default(string);
					}
					this.SendPropertyChanged("Category");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Transaction_Type_TypeCategory", Storage="_Transaction_Type", ThisKey="ID_TRX_TYPE_FK", OtherKey="ID_TRX_TYPE", IsForeignKey=true)]
		public Transaction_Type Transaction_Type
		{
			get
			{
				return this._Transaction_Type.Entity;
			}
			set
			{
				Transaction_Type previousValue = this._Transaction_Type.Entity;
				if (((previousValue != value) 
							|| (this._Transaction_Type.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Transaction_Type.Entity = null;
						previousValue.TypeCategories.Remove(this);
					}
					this._Transaction_Type.Entity = value;
					if ((value != null))
					{
						value.TypeCategories.Add(this);
						this._ID_TRX_TYPE_FK = value.ID_TRX_TYPE;
					}
					else
					{
						this._ID_TRX_TYPE_FK = default(Nullable<int>);
					}
					this.SendPropertyChanged("Transaction_Type");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="trx.Source")]
	public partial class Source : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _NAME;
		
		private System.Nullable<int> _ID_TRX_TYPE_FK;
		
		private EntitySet<Transaction> _Transactions;
		
		private EntityRef<Transaction_Type> _Transaction_Type;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnNAMEChanging(string value);
    partial void OnNAMEChanged();
    partial void OnID_TRX_TYPE_FKChanging(System.Nullable<int> value);
    partial void OnID_TRX_TYPE_FKChanged();
    #endregion
		
		public Source()
		{
			this._Transactions = new EntitySet<Transaction>(new Action<Transaction>(this.attach_Transactions), new Action<Transaction>(this.detach_Transactions));
			this._Transaction_Type = default(EntityRef<Transaction_Type>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NAME", DbType="VarChar(255) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string NAME
		{
			get
			{
				return this._NAME;
			}
			set
			{
				if ((this._NAME != value))
				{
					this.OnNAMEChanging(value);
					this.SendPropertyChanging();
					this._NAME = value;
					this.SendPropertyChanged("NAME");
					this.OnNAMEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_TRX_TYPE_FK", DbType="Int")]
		public System.Nullable<int> ID_TRX_TYPE_FK
		{
			get
			{
				return this._ID_TRX_TYPE_FK;
			}
			set
			{
				if ((this._ID_TRX_TYPE_FK != value))
				{
					if (this._Transaction_Type.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnID_TRX_TYPE_FKChanging(value);
					this.SendPropertyChanging();
					this._ID_TRX_TYPE_FK = value;
					this.SendPropertyChanged("ID_TRX_TYPE_FK");
					this.OnID_TRX_TYPE_FKChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Source_Transaction", Storage="_Transactions", ThisKey="NAME", OtherKey="SOURCE_FK")]
		public EntitySet<Transaction> Transactions
		{
			get
			{
				return this._Transactions;
			}
			set
			{
				this._Transactions.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Transaction_Type_Source", Storage="_Transaction_Type", ThisKey="ID_TRX_TYPE_FK", OtherKey="ID_TRX_TYPE", IsForeignKey=true)]
		public Transaction_Type Transaction_Type
		{
			get
			{
				return this._Transaction_Type.Entity;
			}
			set
			{
				Transaction_Type previousValue = this._Transaction_Type.Entity;
				if (((previousValue != value) 
							|| (this._Transaction_Type.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Transaction_Type.Entity = null;
						previousValue.Sources.Remove(this);
					}
					this._Transaction_Type.Entity = value;
					if ((value != null))
					{
						value.Sources.Add(this);
						this._ID_TRX_TYPE_FK = value.ID_TRX_TYPE;
					}
					else
					{
						this._ID_TRX_TYPE_FK = default(Nullable<int>);
					}
					this.SendPropertyChanged("Transaction_Type");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Transactions(Transaction entity)
		{
			this.SendPropertyChanging();
			entity.Source = this;
		}
		
		private void detach_Transactions(Transaction entity)
		{
			this.SendPropertyChanging();
			entity.Source = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="trx.Accounts")]
	public partial class Account : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _BANK;
		
		private string _ACCOUNT;
		
		private string _ACCOUNT_TYPE_FK;
		
		private string _COMMENT;
		
		private string _FILENAME;
		
		private string _TEMPLATE;
		
		private EntitySet<Transaction> _Transactions;
		
		private EntityRef<Account_Type> _Account_Type;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnBANKChanging(string value);
    partial void OnBANKChanged();
    partial void OnACCOUNTChanging(string value);
    partial void OnACCOUNTChanged();
    partial void OnACCOUNT_TYPE_FKChanging(string value);
    partial void OnACCOUNT_TYPE_FKChanged();
    partial void OnCOMMENTChanging(string value);
    partial void OnCOMMENTChanged();
    partial void OnFILENAMEChanging(string value);
    partial void OnFILENAMEChanged();
    partial void OnTEMPLATEChanging(string value);
    partial void OnTEMPLATEChanged();
    #endregion
		
		public Account()
		{
			this._Transactions = new EntitySet<Transaction>(new Action<Transaction>(this.attach_Transactions), new Action<Transaction>(this.detach_Transactions));
			this._Account_Type = default(EntityRef<Account_Type>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BANK", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string BANK
		{
			get
			{
				return this._BANK;
			}
			set
			{
				if ((this._BANK != value))
				{
					this.OnBANKChanging(value);
					this.SendPropertyChanging();
					this._BANK = value;
					this.SendPropertyChanged("BANK");
					this.OnBANKChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ACCOUNT", DbType="VarChar(255) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string ACCOUNT
		{
			get
			{
				return this._ACCOUNT;
			}
			set
			{
				if ((this._ACCOUNT != value))
				{
					this.OnACCOUNTChanging(value);
					this.SendPropertyChanging();
					this._ACCOUNT = value;
					this.SendPropertyChanged("ACCOUNT");
					this.OnACCOUNTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ACCOUNT_TYPE_FK", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string ACCOUNT_TYPE_FK
		{
			get
			{
				return this._ACCOUNT_TYPE_FK;
			}
			set
			{
				if ((this._ACCOUNT_TYPE_FK != value))
				{
					if (this._Account_Type.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnACCOUNT_TYPE_FKChanging(value);
					this.SendPropertyChanging();
					this._ACCOUNT_TYPE_FK = value;
					this.SendPropertyChanged("ACCOUNT_TYPE_FK");
					this.OnACCOUNT_TYPE_FKChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_COMMENT", DbType="VarChar(255)")]
		public string COMMENT
		{
			get
			{
				return this._COMMENT;
			}
			set
			{
				if ((this._COMMENT != value))
				{
					this.OnCOMMENTChanging(value);
					this.SendPropertyChanging();
					this._COMMENT = value;
					this.SendPropertyChanged("COMMENT");
					this.OnCOMMENTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FILENAME", DbType="VarChar(255)")]
		public string FILENAME
		{
			get
			{
				return this._FILENAME;
			}
			set
			{
				if ((this._FILENAME != value))
				{
					this.OnFILENAMEChanging(value);
					this.SendPropertyChanging();
					this._FILENAME = value;
					this.SendPropertyChanged("FILENAME");
					this.OnFILENAMEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TEMPLATE", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string TEMPLATE
		{
			get
			{
				return this._TEMPLATE;
			}
			set
			{
				if ((this._TEMPLATE != value))
				{
					this.OnTEMPLATEChanging(value);
					this.SendPropertyChanging();
					this._TEMPLATE = value;
					this.SendPropertyChanged("TEMPLATE");
					this.OnTEMPLATEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Account_Transaction", Storage="_Transactions", ThisKey="ACCOUNT", OtherKey="ACCOUNT_FK")]
		public EntitySet<Transaction> Transactions
		{
			get
			{
				return this._Transactions;
			}
			set
			{
				this._Transactions.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Account_Type_Account", Storage="_Account_Type", ThisKey="ACCOUNT_TYPE_FK", OtherKey="ACCOUNT_TYPE", IsForeignKey=true)]
		public Account_Type Account_Type
		{
			get
			{
				return this._Account_Type.Entity;
			}
			set
			{
				Account_Type previousValue = this._Account_Type.Entity;
				if (((previousValue != value) 
							|| (this._Account_Type.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Account_Type.Entity = null;
						previousValue.Accounts.Remove(this);
					}
					this._Account_Type.Entity = value;
					if ((value != null))
					{
						value.Accounts.Add(this);
						this._ACCOUNT_TYPE_FK = value.ACCOUNT_TYPE;
					}
					else
					{
						this._ACCOUNT_TYPE_FK = default(string);
					}
					this.SendPropertyChanged("Account_Type");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Transactions(Transaction entity)
		{
			this.SendPropertyChanging();
			entity.Account = this;
		}
		
		private void detach_Transactions(Transaction entity)
		{
			this.SendPropertyChanging();
			entity.Account = null;
		}
	}
}
#pragma warning restore 1591
