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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Database")]
public partial class transec_datasetDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void InsertTransectionDB(TransectionDB instance);
  partial void UpdateTransectionDB(TransectionDB instance);
  partial void DeleteTransectionDB(TransectionDB instance);
  #endregion
	
	public transec_datasetDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public transec_datasetDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public transec_datasetDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public transec_datasetDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public transec_datasetDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<TransectionDB> TransectionDBs
	{
		get
		{
			return this.GetTable<TransectionDB>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TransectionDB")]
public partial class TransectionDB : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private System.Guid _Id;
	
	private string _Transaction_Id;
	
	private decimal _Amount;
	
	private string _Currency_Code;
	
	private System.DateTime _Transaction_Date;
	
	private string _Status;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(System.Guid value);
    partial void OnIdChanged();
    partial void OnTransaction_IdChanging(string value);
    partial void OnTransaction_IdChanged();
    partial void OnAmountChanging(decimal value);
    partial void OnAmountChanged();
    partial void OnCurrency_CodeChanging(string value);
    partial void OnCurrency_CodeChanged();
    partial void OnTransaction_DateChanging(System.DateTime value);
    partial void OnTransaction_DateChanged();
    partial void OnStatusChanging(string value);
    partial void OnStatusChanged();
    #endregion
	
	public TransectionDB()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
	public System.Guid Id
	{
		get
		{
			return this._Id;
		}
		set
		{
			if ((this._Id != value))
			{
				this.OnIdChanging(value);
				this.SendPropertyChanging();
				this._Id = value;
				this.SendPropertyChanged("Id");
				this.OnIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Transaction_Id", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Transaction_Id
	{
		get
		{
			return this._Transaction_Id;
		}
		set
		{
			if ((this._Transaction_Id != value))
			{
				this.OnTransaction_IdChanging(value);
				this.SendPropertyChanging();
				this._Transaction_Id = value;
				this.SendPropertyChanged("Transaction_Id");
				this.OnTransaction_IdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Amount", DbType="Decimal(16,2) NOT NULL")]
	public decimal Amount
	{
		get
		{
			return this._Amount;
		}
		set
		{
			if ((this._Amount != value))
			{
				this.OnAmountChanging(value);
				this.SendPropertyChanging();
				this._Amount = value;
				this.SendPropertyChanged("Amount");
				this.OnAmountChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Currency_Code", DbType="NVarChar(8) NOT NULL", CanBeNull=false)]
	public string Currency_Code
	{
		get
		{
			return this._Currency_Code;
		}
		set
		{
			if ((this._Currency_Code != value))
			{
				this.OnCurrency_CodeChanging(value);
				this.SendPropertyChanging();
				this._Currency_Code = value;
				this.SendPropertyChanged("Currency_Code");
				this.OnCurrency_CodeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Transaction_Date", DbType="DateTime NOT NULL")]
	public System.DateTime Transaction_Date
	{
		get
		{
			return this._Transaction_Date;
		}
		set
		{
			if ((this._Transaction_Date != value))
			{
				this.OnTransaction_DateChanging(value);
				this.SendPropertyChanging();
				this._Transaction_Date = value;
				this.SendPropertyChanged("Transaction_Date");
				this.OnTransaction_DateChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="VarChar(12) NOT NULL", CanBeNull=false)]
	public string Status
	{
		get
		{
			return this._Status;
		}
		set
		{
			if ((this._Status != value))
			{
				this.OnStatusChanging(value);
				this.SendPropertyChanging();
				this._Status = value;
				this.SendPropertyChanged("Status");
				this.OnStatusChanged();
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
#pragma warning restore 1591
