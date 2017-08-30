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

namespace Vis4AgTrace
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="VisTraceability")]
	public partial class VisDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertLoadEvent(VisDAL.LoadEvent instance);
    partial void UpdateLoadEvent(VisDAL.LoadEvent instance);
    partial void DeleteLoadEvent(VisDAL.LoadEvent instance);
    partial void InsertTransferEvent(VisDAL.TransferEvent instance);
    partial void UpdateTransferEvent(VisDAL.TransferEvent instance);
    partial void DeleteTransferEvent(VisDAL.TransferEvent instance);
    partial void InsertLoad(VisDAL.Load instance);
    partial void UpdateLoad(VisDAL.Load instance);
    partial void DeleteLoad(VisDAL.Load instance);
    partial void InsertContainer(VisDAL.Container instance);
    partial void UpdateContainer(VisDAL.Container instance);
    partial void DeleteContainer(VisDAL.Container instance);
    #endregion
		
		public VisDBDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["VisTraceabilityConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public VisDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public VisDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public VisDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public VisDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<VisDAL.LoadEvent> LoadEvents
		{
			get
			{
				return this.GetTable<VisDAL.LoadEvent>();
			}
		}
		
		public System.Data.Linq.Table<VisDAL.TransferEvent> TransferEvents
		{
			get
			{
				return this.GetTable<VisDAL.TransferEvent>();
			}
		}
		
		public System.Data.Linq.Table<VisDAL.Load> Loads
		{
			get
			{
				return this.GetTable<VisDAL.Load>();
			}
		}
		
		public System.Data.Linq.Table<VisDAL.Container> Containers
		{
			get
			{
				return this.GetTable<VisDAL.Container>();
			}
		}
	}
}
namespace VisDAL
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LoadEvent")]
	public partial class LoadEvent : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _LoadEventID;
		
		private string _Description;
		
		private byte _EventTypeID;
		
		private System.Guid _TransferEventID;
		
		private System.Guid _LoadID;
		
		private EntityRef<TransferEvent> _TransferEvent;
		
		private EntityRef<Load> _Load;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnLoadEventIDChanging(System.Guid value);
    partial void OnLoadEventIDChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnEventTypeIDChanging(byte value);
    partial void OnEventTypeIDChanged();
    partial void OnTransferEventIDChanging(System.Guid value);
    partial void OnTransferEventIDChanged();
    partial void OnLoadIDChanging(System.Guid value);
    partial void OnLoadIDChanged();
    #endregion
		
		public LoadEvent()
		{
			this._TransferEvent = default(EntityRef<TransferEvent>);
			this._Load = default(EntityRef<Load>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LoadEventID", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid LoadEventID
		{
			get
			{
				return this._LoadEventID;
			}
			set
			{
				if ((this._LoadEventID != value))
				{
					this.OnLoadEventIDChanging(value);
					this.SendPropertyChanging();
					this._LoadEventID = value;
					this.SendPropertyChanged("LoadEventID");
					this.OnLoadEventIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(200) NOT NULL", CanBeNull=false)]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EventTypeID", DbType="TinyInt NOT NULL")]
		public byte EventTypeID
		{
			get
			{
				return this._EventTypeID;
			}
			set
			{
				if ((this._EventTypeID != value))
				{
					this.OnEventTypeIDChanging(value);
					this.SendPropertyChanging();
					this._EventTypeID = value;
					this.SendPropertyChanged("EventTypeID");
					this.OnEventTypeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TransferEventID", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid TransferEventID
		{
			get
			{
				return this._TransferEventID;
			}
			set
			{
				if ((this._TransferEventID != value))
				{
					if (this._TransferEvent.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnTransferEventIDChanging(value);
					this.SendPropertyChanging();
					this._TransferEventID = value;
					this.SendPropertyChanged("TransferEventID");
					this.OnTransferEventIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LoadID", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid LoadID
		{
			get
			{
				return this._LoadID;
			}
			set
			{
				if ((this._LoadID != value))
				{
					if (this._Load.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnLoadIDChanging(value);
					this.SendPropertyChanging();
					this._LoadID = value;
					this.SendPropertyChanged("LoadID");
					this.OnLoadIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TransferEvent_LoadEvent", Storage="_TransferEvent", ThisKey="TransferEventID", OtherKey="TransferEventID", IsForeignKey=true)]
		public TransferEvent TransferEvent
		{
			get
			{
				return this._TransferEvent.Entity;
			}
			set
			{
				TransferEvent previousValue = this._TransferEvent.Entity;
				if (((previousValue != value) 
							|| (this._TransferEvent.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TransferEvent.Entity = null;
						previousValue.LoadEvents.Remove(this);
					}
					this._TransferEvent.Entity = value;
					if ((value != null))
					{
						value.LoadEvents.Add(this);
						this._TransferEventID = value.TransferEventID;
					}
					else
					{
						this._TransferEventID = default(System.Guid);
					}
					this.SendPropertyChanged("TransferEvent");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Load_LoadEvent", Storage="_Load", ThisKey="LoadID", OtherKey="LoadID", IsForeignKey=true)]
		public Load Load
		{
			get
			{
				return this._Load.Entity;
			}
			set
			{
				Load previousValue = this._Load.Entity;
				if (((previousValue != value) 
							|| (this._Load.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Load.Entity = null;
						previousValue.LoadEvents.Remove(this);
					}
					this._Load.Entity = value;
					if ((value != null))
					{
						value.LoadEvents.Add(this);
						this._LoadID = value.LoadID;
					}
					else
					{
						this._LoadID = default(System.Guid);
					}
					this.SendPropertyChanged("Load");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TransferEvent")]
	public partial class TransferEvent : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _TransferEventID;
		
		private short _TransferTypeID;
		
		private string _SpatialData;
		
		private System.Nullable<short> _TransferMethodID;
		
		private System.Nullable<System.DateTime> _StartTime;
		
		private System.Nullable<double> _StartLatitude;
		
		private System.Nullable<double> _StartLongitude;
		
		private System.Nullable<System.DateTime> _EndTime;
		
		private System.Nullable<double> _EndLatitude;
		
		private System.Nullable<double> _EndLogitude;
		
		private System.Nullable<long> _ProductMaterialID;
		
		private System.Nullable<double> _QuantityTransferred;
		
		private string _QuantityUOM;
		
		private System.Nullable<double> _TransferRate;
		
		private string _TransferUOM;
		
		private EntitySet<LoadEvent> _LoadEvents;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTransferEventIDChanging(System.Guid value);
    partial void OnTransferEventIDChanged();
    partial void OnTransferTypeIDChanging(short value);
    partial void OnTransferTypeIDChanged();
    partial void OnSpatialDataChanging(string value);
    partial void OnSpatialDataChanged();
    partial void OnTransferMethodIDChanging(System.Nullable<short> value);
    partial void OnTransferMethodIDChanged();
    partial void OnStartTimeChanging(System.Nullable<System.DateTime> value);
    partial void OnStartTimeChanged();
    partial void OnStartLatitudeChanging(System.Nullable<double> value);
    partial void OnStartLatitudeChanged();
    partial void OnStartLongitudeChanging(System.Nullable<double> value);
    partial void OnStartLongitudeChanged();
    partial void OnEndTimeChanging(System.Nullable<System.DateTime> value);
    partial void OnEndTimeChanged();
    partial void OnEndLatitudeChanging(System.Nullable<double> value);
    partial void OnEndLatitudeChanged();
    partial void OnEndLogitudeChanging(System.Nullable<double> value);
    partial void OnEndLogitudeChanged();
    partial void OnProductMaterialIDChanging(System.Nullable<long> value);
    partial void OnProductMaterialIDChanged();
    partial void OnQuantityTransferredChanging(System.Nullable<double> value);
    partial void OnQuantityTransferredChanged();
    partial void OnQuantityUOMChanging(string value);
    partial void OnQuantityUOMChanged();
    partial void OnTransferRateChanging(System.Nullable<double> value);
    partial void OnTransferRateChanged();
    partial void OnTransferUOMChanging(string value);
    partial void OnTransferUOMChanged();
    #endregion
		
		public TransferEvent()
		{
			this._LoadEvents = new EntitySet<LoadEvent>(new Action<LoadEvent>(this.attach_LoadEvents), new Action<LoadEvent>(this.detach_LoadEvents));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TransferEventID", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid TransferEventID
		{
			get
			{
				return this._TransferEventID;
			}
			set
			{
				if ((this._TransferEventID != value))
				{
					this.OnTransferEventIDChanging(value);
					this.SendPropertyChanging();
					this._TransferEventID = value;
					this.SendPropertyChanged("TransferEventID");
					this.OnTransferEventIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TransferTypeID", DbType="SmallInt NOT NULL")]
		public short TransferTypeID
		{
			get
			{
				return this._TransferTypeID;
			}
			set
			{
				if ((this._TransferTypeID != value))
				{
					this.OnTransferTypeIDChanging(value);
					this.SendPropertyChanging();
					this._TransferTypeID = value;
					this.SendPropertyChanged("TransferTypeID");
					this.OnTransferTypeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SpatialData", DbType="NVarChar(500)")]
		public string SpatialData
		{
			get
			{
				return this._SpatialData;
			}
			set
			{
				if ((this._SpatialData != value))
				{
					this.OnSpatialDataChanging(value);
					this.SendPropertyChanging();
					this._SpatialData = value;
					this.SendPropertyChanged("SpatialData");
					this.OnSpatialDataChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TransferMethodID", DbType="SmallInt")]
		public System.Nullable<short> TransferMethodID
		{
			get
			{
				return this._TransferMethodID;
			}
			set
			{
				if ((this._TransferMethodID != value))
				{
					this.OnTransferMethodIDChanging(value);
					this.SendPropertyChanging();
					this._TransferMethodID = value;
					this.SendPropertyChanged("TransferMethodID");
					this.OnTransferMethodIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StartTime", DbType="DateTime")]
		public System.Nullable<System.DateTime> StartTime
		{
			get
			{
				return this._StartTime;
			}
			set
			{
				if ((this._StartTime != value))
				{
					this.OnStartTimeChanging(value);
					this.SendPropertyChanging();
					this._StartTime = value;
					this.SendPropertyChanged("StartTime");
					this.OnStartTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StartLatitude", DbType="Float")]
		public System.Nullable<double> StartLatitude
		{
			get
			{
				return this._StartLatitude;
			}
			set
			{
				if ((this._StartLatitude != value))
				{
					this.OnStartLatitudeChanging(value);
					this.SendPropertyChanging();
					this._StartLatitude = value;
					this.SendPropertyChanged("StartLatitude");
					this.OnStartLatitudeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StartLongitude", DbType="Float")]
		public System.Nullable<double> StartLongitude
		{
			get
			{
				return this._StartLongitude;
			}
			set
			{
				if ((this._StartLongitude != value))
				{
					this.OnStartLongitudeChanging(value);
					this.SendPropertyChanging();
					this._StartLongitude = value;
					this.SendPropertyChanged("StartLongitude");
					this.OnStartLongitudeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EndTime", DbType="DateTime")]
		public System.Nullable<System.DateTime> EndTime
		{
			get
			{
				return this._EndTime;
			}
			set
			{
				if ((this._EndTime != value))
				{
					this.OnEndTimeChanging(value);
					this.SendPropertyChanging();
					this._EndTime = value;
					this.SendPropertyChanged("EndTime");
					this.OnEndTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EndLatitude", DbType="Float")]
		public System.Nullable<double> EndLatitude
		{
			get
			{
				return this._EndLatitude;
			}
			set
			{
				if ((this._EndLatitude != value))
				{
					this.OnEndLatitudeChanging(value);
					this.SendPropertyChanging();
					this._EndLatitude = value;
					this.SendPropertyChanged("EndLatitude");
					this.OnEndLatitudeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EndLogitude", DbType="Float")]
		public System.Nullable<double> EndLogitude
		{
			get
			{
				return this._EndLogitude;
			}
			set
			{
				if ((this._EndLogitude != value))
				{
					this.OnEndLogitudeChanging(value);
					this.SendPropertyChanging();
					this._EndLogitude = value;
					this.SendPropertyChanged("EndLogitude");
					this.OnEndLogitudeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductMaterialID", DbType="BigInt")]
		public System.Nullable<long> ProductMaterialID
		{
			get
			{
				return this._ProductMaterialID;
			}
			set
			{
				if ((this._ProductMaterialID != value))
				{
					this.OnProductMaterialIDChanging(value);
					this.SendPropertyChanging();
					this._ProductMaterialID = value;
					this.SendPropertyChanged("ProductMaterialID");
					this.OnProductMaterialIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QuantityTransferred", DbType="Float")]
		public System.Nullable<double> QuantityTransferred
		{
			get
			{
				return this._QuantityTransferred;
			}
			set
			{
				if ((this._QuantityTransferred != value))
				{
					this.OnQuantityTransferredChanging(value);
					this.SendPropertyChanging();
					this._QuantityTransferred = value;
					this.SendPropertyChanged("QuantityTransferred");
					this.OnQuantityTransferredChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QuantityUOM", DbType="NVarChar(10)")]
		public string QuantityUOM
		{
			get
			{
				return this._QuantityUOM;
			}
			set
			{
				if ((this._QuantityUOM != value))
				{
					this.OnQuantityUOMChanging(value);
					this.SendPropertyChanging();
					this._QuantityUOM = value;
					this.SendPropertyChanged("QuantityUOM");
					this.OnQuantityUOMChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TransferRate", DbType="Float")]
		public System.Nullable<double> TransferRate
		{
			get
			{
				return this._TransferRate;
			}
			set
			{
				if ((this._TransferRate != value))
				{
					this.OnTransferRateChanging(value);
					this.SendPropertyChanging();
					this._TransferRate = value;
					this.SendPropertyChanged("TransferRate");
					this.OnTransferRateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TransferUOM", DbType="NVarChar(10)")]
		public string TransferUOM
		{
			get
			{
				return this._TransferUOM;
			}
			set
			{
				if ((this._TransferUOM != value))
				{
					this.OnTransferUOMChanging(value);
					this.SendPropertyChanging();
					this._TransferUOM = value;
					this.SendPropertyChanged("TransferUOM");
					this.OnTransferUOMChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TransferEvent_LoadEvent", Storage="_LoadEvents", ThisKey="TransferEventID", OtherKey="TransferEventID")]
		public EntitySet<LoadEvent> LoadEvents
		{
			get
			{
				return this._LoadEvents;
			}
			set
			{
				this._LoadEvents.Assign(value);
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
		
		private void attach_LoadEvents(LoadEvent entity)
		{
			this.SendPropertyChanging();
			entity.TransferEvent = this;
		}
		
		private void detach_LoadEvents(LoadEvent entity)
		{
			this.SendPropertyChanging();
			entity.TransferEvent = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[Load]")]
	public partial class Load : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _LoadID;
		
		private System.Guid _ContainerID;
		
		private string _Description;
		
		private System.Nullable<short> _LoadType;
		
		private System.Nullable<System.DateTime> _StartTime;
		
		private System.Nullable<System.DateTime> _EndTime;
		
		private System.Nullable<long> _ProductMaterialID;
		
		private System.Nullable<System.Guid> _RemainderLoadID;
		
		private EntitySet<LoadEvent> _LoadEvents;
		
		private EntityRef<Container> _Container;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnLoadIDChanging(System.Guid value);
    partial void OnLoadIDChanged();
    partial void OnContainerIDChanging(System.Guid value);
    partial void OnContainerIDChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnLoadTypeChanging(System.Nullable<short> value);
    partial void OnLoadTypeChanged();
    partial void OnStartTimeChanging(System.Nullable<System.DateTime> value);
    partial void OnStartTimeChanged();
    partial void OnEndTimeChanging(System.Nullable<System.DateTime> value);
    partial void OnEndTimeChanged();
    partial void OnProductMaterialIDChanging(System.Nullable<long> value);
    partial void OnProductMaterialIDChanged();
    partial void OnRemainderLoadIDChanging(System.Nullable<System.Guid> value);
    partial void OnRemainderLoadIDChanged();
    #endregion
		
		public Load()
		{
			this._LoadEvents = new EntitySet<LoadEvent>(new Action<LoadEvent>(this.attach_LoadEvents), new Action<LoadEvent>(this.detach_LoadEvents));
			this._Container = default(EntityRef<Container>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LoadID", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid LoadID
		{
			get
			{
				return this._LoadID;
			}
			set
			{
				if ((this._LoadID != value))
				{
					this.OnLoadIDChanging(value);
					this.SendPropertyChanging();
					this._LoadID = value;
					this.SendPropertyChanged("LoadID");
					this.OnLoadIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ContainerID", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid ContainerID
		{
			get
			{
				return this._ContainerID;
			}
			set
			{
				if ((this._ContainerID != value))
				{
					if (this._Container.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnContainerIDChanging(value);
					this.SendPropertyChanging();
					this._ContainerID = value;
					this.SendPropertyChanged("ContainerID");
					this.OnContainerIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(200) NOT NULL", CanBeNull=false)]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LoadType", DbType="SmallInt")]
		public System.Nullable<short> LoadType
		{
			get
			{
				return this._LoadType;
			}
			set
			{
				if ((this._LoadType != value))
				{
					this.OnLoadTypeChanging(value);
					this.SendPropertyChanging();
					this._LoadType = value;
					this.SendPropertyChanged("LoadType");
					this.OnLoadTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StartTime", DbType="DateTime")]
		public System.Nullable<System.DateTime> StartTime
		{
			get
			{
				return this._StartTime;
			}
			set
			{
				if ((this._StartTime != value))
				{
					this.OnStartTimeChanging(value);
					this.SendPropertyChanging();
					this._StartTime = value;
					this.SendPropertyChanged("StartTime");
					this.OnStartTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EndTime", DbType="DateTime")]
		public System.Nullable<System.DateTime> EndTime
		{
			get
			{
				return this._EndTime;
			}
			set
			{
				if ((this._EndTime != value))
				{
					this.OnEndTimeChanging(value);
					this.SendPropertyChanging();
					this._EndTime = value;
					this.SendPropertyChanged("EndTime");
					this.OnEndTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductMaterialID", DbType="BigInt")]
		public System.Nullable<long> ProductMaterialID
		{
			get
			{
				return this._ProductMaterialID;
			}
			set
			{
				if ((this._ProductMaterialID != value))
				{
					this.OnProductMaterialIDChanging(value);
					this.SendPropertyChanging();
					this._ProductMaterialID = value;
					this.SendPropertyChanged("ProductMaterialID");
					this.OnProductMaterialIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RemainderLoadID", DbType="UniqueIdentifier")]
		public System.Nullable<System.Guid> RemainderLoadID
		{
			get
			{
				return this._RemainderLoadID;
			}
			set
			{
				if ((this._RemainderLoadID != value))
				{
					this.OnRemainderLoadIDChanging(value);
					this.SendPropertyChanging();
					this._RemainderLoadID = value;
					this.SendPropertyChanged("RemainderLoadID");
					this.OnRemainderLoadIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Load_LoadEvent", Storage="_LoadEvents", ThisKey="LoadID", OtherKey="LoadID")]
		public EntitySet<LoadEvent> LoadEvents
		{
			get
			{
				return this._LoadEvents;
			}
			set
			{
				this._LoadEvents.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Container_Load", Storage="_Container", ThisKey="ContainerID", OtherKey="ContainerID", IsForeignKey=true)]
		public Container Container
		{
			get
			{
				return this._Container.Entity;
			}
			set
			{
				Container previousValue = this._Container.Entity;
				if (((previousValue != value) 
							|| (this._Container.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Container.Entity = null;
						previousValue.Loads.Remove(this);
					}
					this._Container.Entity = value;
					if ((value != null))
					{
						value.Loads.Add(this);
						this._ContainerID = value.ContainerID;
					}
					else
					{
						this._ContainerID = default(System.Guid);
					}
					this.SendPropertyChanged("Container");
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
		
		private void attach_LoadEvents(LoadEvent entity)
		{
			this.SendPropertyChanging();
			entity.Load = this;
		}
		
		private void detach_LoadEvents(LoadEvent entity)
		{
			this.SendPropertyChanging();
			entity.Load = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Container")]
	public partial class Container : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _ContainerID;
		
		private short _ContainerTypeID;
		
		private string _Name;
		
		private string _Description;
		
		private System.Nullable<double> _VolumeMax;
		
		private string _VolumeUOM;
		
		private System.Nullable<double> _MassMax;
		
		private string _MassMaxUOM;
		
		private string _LocationGLN;
		
		private EntitySet<Load> _Loads;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnContainerIDChanging(System.Guid value);
    partial void OnContainerIDChanged();
    partial void OnContainerTypeIDChanging(short value);
    partial void OnContainerTypeIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnVolumeMaxChanging(System.Nullable<double> value);
    partial void OnVolumeMaxChanged();
    partial void OnVolumeUOMChanging(string value);
    partial void OnVolumeUOMChanged();
    partial void OnMassMaxChanging(System.Nullable<double> value);
    partial void OnMassMaxChanged();
    partial void OnMassMaxUOMChanging(string value);
    partial void OnMassMaxUOMChanged();
    partial void OnLocationGLNChanging(string value);
    partial void OnLocationGLNChanged();
    #endregion
		
		public Container()
		{
			this._Loads = new EntitySet<Load>(new Action<Load>(this.attach_Loads), new Action<Load>(this.detach_Loads));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ContainerID", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid ContainerID
		{
			get
			{
				return this._ContainerID;
			}
			set
			{
				if ((this._ContainerID != value))
				{
					this.OnContainerIDChanging(value);
					this.SendPropertyChanging();
					this._ContainerID = value;
					this.SendPropertyChanged("ContainerID");
					this.OnContainerIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ContainerTypeID", DbType="SmallInt NOT NULL")]
		public short ContainerTypeID
		{
			get
			{
				return this._ContainerTypeID;
			}
			set
			{
				if ((this._ContainerTypeID != value))
				{
					this.OnContainerTypeIDChanging(value);
					this.SendPropertyChanging();
					this._ContainerTypeID = value;
					this.SendPropertyChanged("ContainerTypeID");
					this.OnContainerTypeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(200) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(500)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VolumeMax", DbType="Float")]
		public System.Nullable<double> VolumeMax
		{
			get
			{
				return this._VolumeMax;
			}
			set
			{
				if ((this._VolumeMax != value))
				{
					this.OnVolumeMaxChanging(value);
					this.SendPropertyChanging();
					this._VolumeMax = value;
					this.SendPropertyChanged("VolumeMax");
					this.OnVolumeMaxChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VolumeUOM", DbType="NVarChar(10)")]
		public string VolumeUOM
		{
			get
			{
				return this._VolumeUOM;
			}
			set
			{
				if ((this._VolumeUOM != value))
				{
					this.OnVolumeUOMChanging(value);
					this.SendPropertyChanging();
					this._VolumeUOM = value;
					this.SendPropertyChanged("VolumeUOM");
					this.OnVolumeUOMChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MassMax", DbType="Float")]
		public System.Nullable<double> MassMax
		{
			get
			{
				return this._MassMax;
			}
			set
			{
				if ((this._MassMax != value))
				{
					this.OnMassMaxChanging(value);
					this.SendPropertyChanging();
					this._MassMax = value;
					this.SendPropertyChanged("MassMax");
					this.OnMassMaxChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MassMaxUOM", DbType="NVarChar(10)")]
		public string MassMaxUOM
		{
			get
			{
				return this._MassMaxUOM;
			}
			set
			{
				if ((this._MassMaxUOM != value))
				{
					this.OnMassMaxUOMChanging(value);
					this.SendPropertyChanging();
					this._MassMaxUOM = value;
					this.SendPropertyChanged("MassMaxUOM");
					this.OnMassMaxUOMChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LocationGLN", DbType="NVarChar(13)")]
		public string LocationGLN
		{
			get
			{
				return this._LocationGLN;
			}
			set
			{
				if ((this._LocationGLN != value))
				{
					this.OnLocationGLNChanging(value);
					this.SendPropertyChanging();
					this._LocationGLN = value;
					this.SendPropertyChanged("LocationGLN");
					this.OnLocationGLNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Container_Load", Storage="_Loads", ThisKey="ContainerID", OtherKey="ContainerID")]
		public EntitySet<Load> Loads
		{
			get
			{
				return this._Loads;
			}
			set
			{
				this._Loads.Assign(value);
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
		
		private void attach_Loads(Load entity)
		{
			this.SendPropertyChanging();
			entity.Container = this;
		}
		
		private void detach_Loads(Load entity)
		{
			this.SendPropertyChanging();
			entity.Container = null;
		}
	}
}
#pragma warning restore 1591
