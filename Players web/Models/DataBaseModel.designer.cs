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

namespace Players_web.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="A_Players")]
	public partial class DataBaseModelDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertPlayer(Player instance);
    partial void UpdatePlayer(Player instance);
    partial void DeletePlayer(Player instance);
    #endregion
		
		public DataBaseModelDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["A_PlayersConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseModelDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseModelDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseModelDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseModelDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Player> Players
		{
			get
			{
				return this.GetTable<Player>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.players")]
	public partial class Player : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _player_id;
		
		private System.Nullable<int> _trainer_id;
		
		private string _name;
		
		private string _surname;
		
		private string _nationality;
		
		private System.Nullable<System.DateTime> _birth_date;
		
		private System.Nullable<int> _height;
		
		private System.Nullable<int> _weight;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onplayer_idChanging(int value);
    partial void Onplayer_idChanged();
    partial void Ontrainer_idChanging(System.Nullable<int> value);
    partial void Ontrainer_idChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnsurnameChanging(string value);
    partial void OnsurnameChanged();
    partial void OnnationalityChanging(string value);
    partial void OnnationalityChanged();
    partial void Onbirth_dateChanging(System.Nullable<System.DateTime> value);
    partial void Onbirth_dateChanged();
    partial void OnheightChanging(System.Nullable<int> value);
    partial void OnheightChanged();
    partial void OnweightChanging(System.Nullable<int> value);
    partial void OnweightChanged();
    #endregion
		
		public Player()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_player_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int player_id
		{
			get
			{
				return this._player_id;
			}
			set
			{
				if ((this._player_id != value))
				{
					this.Onplayer_idChanging(value);
					this.SendPropertyChanging();
					this._player_id = value;
					this.SendPropertyChanged("player_id");
					this.Onplayer_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_trainer_id", DbType="Int")]
		public System.Nullable<int> trainer_id
		{
			get
			{
				return this._trainer_id;
			}
			set
			{
				if ((this._trainer_id != value))
				{
					this.Ontrainer_idChanging(value);
					this.SendPropertyChanging();
					this._trainer_id = value;
					this.SendPropertyChanged("trainer_id");
					this.Ontrainer_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(255)")]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_surname", DbType="VarChar(255)")]
		public string surname
		{
			get
			{
				return this._surname;
			}
			set
			{
				if ((this._surname != value))
				{
					this.OnsurnameChanging(value);
					this.SendPropertyChanging();
					this._surname = value;
					this.SendPropertyChanged("surname");
					this.OnsurnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nationality", DbType="VarChar(255)")]
		public string nationality
		{
			get
			{
				return this._nationality;
			}
			set
			{
				if ((this._nationality != value))
				{
					this.OnnationalityChanging(value);
					this.SendPropertyChanging();
					this._nationality = value;
					this.SendPropertyChanged("nationality");
					this.OnnationalityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_birth_date", DbType="DateTime")]
		public System.Nullable<System.DateTime> birth_date
		{
			get
			{
				return this._birth_date;
			}
			set
			{
				if ((this._birth_date != value))
				{
					this.Onbirth_dateChanging(value);
					this.SendPropertyChanging();
					this._birth_date = value;
					this.SendPropertyChanged("birth_date");
					this.Onbirth_dateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_height", DbType="Int")]
		public System.Nullable<int> height
		{
			get
			{
				return this._height;
			}
			set
			{
				if ((this._height != value))
				{
					this.OnheightChanging(value);
					this.SendPropertyChanging();
					this._height = value;
					this.SendPropertyChanged("height");
					this.OnheightChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_weight", DbType="Int")]
		public System.Nullable<int> weight
		{
			get
			{
				return this._weight;
			}
			set
			{
				if ((this._weight != value))
				{
					this.OnweightChanging(value);
					this.SendPropertyChanging();
					this._weight = value;
					this.SendPropertyChanged("weight");
					this.OnweightChanged();
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
}
#pragma warning restore 1591
