namespace CrmEarlyBound
{
	
	/// <summary>
	/// Person with access to the Microsoft CRM system and who owns objects in the Microsoft CRM database.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("systemuser")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9479")]
	public partial class SystemUser : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public SystemUser() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "systemuser";
		
		public const string EntitySchemaName = "SystemUser";
		
		public const string PrimaryIdAttribute = "systemuserid";
		
		public const string PrimaryNameAttribute = "fullname";
		
		public const int EntityTypeCode = 8;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		[System.Diagnostics.DebuggerNonUserCode()]
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		[System.Diagnostics.DebuggerNonUserCode()]
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		/// <summary>
		/// Type of user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accessmode")]
		public Microsoft.Xrm.Sdk.OptionSetValue AccessMode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("accessmode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("AccessMode");
				this.SetAttributeValue("accessmode", value);
				this.OnPropertyChanged("AccessMode");
			}
		}
		
		/// <summary>
		/// Unique identifier for address 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_addressid")]
		public System.Nullable<System.Guid> Address1_AddressId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("address1_addressid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_AddressId");
				this.SetAttributeValue("address1_addressid", value);
				this.OnPropertyChanged("Address1_AddressId");
			}
		}
		
		/// <summary>
		/// Type of address for address 1, such as billing, shipping, or primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_addresstypecode")]
		public Microsoft.Xrm.Sdk.OptionSetValue Address1_AddressTypeCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address1_addresstypecode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_AddressTypeCode");
				this.SetAttributeValue("address1_addresstypecode", value);
				this.OnPropertyChanged("Address1_AddressTypeCode");
			}
		}
		
		/// <summary>
		/// City name for address 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_city")]
		public string Address1_City
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address1_city");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_City");
				this.SetAttributeValue("address1_city", value);
				this.OnPropertyChanged("Address1_City");
			}
		}
		
		/// <summary>
		/// Shows the complete primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_composite")]
		public string Address1_Composite
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address1_composite");
			}
		}
		
		/// <summary>
		/// Country/region name in address 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_country")]
		public string Address1_Country
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address1_country");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_Country");
				this.SetAttributeValue("address1_country", value);
				this.OnPropertyChanged("Address1_Country");
			}
		}
		
		/// <summary>
		/// County name for address 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_county")]
		public string Address1_County
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address1_county");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_County");
				this.SetAttributeValue("address1_county", value);
				this.OnPropertyChanged("Address1_County");
			}
		}
		
		/// <summary>
		/// Fax number for address 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_fax")]
		public string Address1_Fax
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address1_fax");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_Fax");
				this.SetAttributeValue("address1_fax", value);
				this.OnPropertyChanged("Address1_Fax");
			}
		}
		
		/// <summary>
		/// Latitude for address 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_latitude")]
		public System.Nullable<double> Address1_Latitude
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("address1_latitude");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_Latitude");
				this.SetAttributeValue("address1_latitude", value);
				this.OnPropertyChanged("Address1_Latitude");
			}
		}
		
		/// <summary>
		/// First line for entering address 1 information.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_line1")]
		public string Address1_Line1
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address1_line1");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_Line1");
				this.SetAttributeValue("address1_line1", value);
				this.OnPropertyChanged("Address1_Line1");
			}
		}
		
		/// <summary>
		/// Second line for entering address 1 information.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_line2")]
		public string Address1_Line2
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address1_line2");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_Line2");
				this.SetAttributeValue("address1_line2", value);
				this.OnPropertyChanged("Address1_Line2");
			}
		}
		
		/// <summary>
		/// Third line for entering address 1 information.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_line3")]
		public string Address1_Line3
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address1_line3");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_Line3");
				this.SetAttributeValue("address1_line3", value);
				this.OnPropertyChanged("Address1_Line3");
			}
		}
		
		/// <summary>
		/// Longitude for address 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_longitude")]
		public System.Nullable<double> Address1_Longitude
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("address1_longitude");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_Longitude");
				this.SetAttributeValue("address1_longitude", value);
				this.OnPropertyChanged("Address1_Longitude");
			}
		}
		
		/// <summary>
		/// Name to enter for address 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_name")]
		public string Address1_Name
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address1_name");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_Name");
				this.SetAttributeValue("address1_name", value);
				this.OnPropertyChanged("Address1_Name");
			}
		}
		
		/// <summary>
		/// ZIP Code or postal code for address 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_postalcode")]
		public string Address1_PostalCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address1_postalcode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_PostalCode");
				this.SetAttributeValue("address1_postalcode", value);
				this.OnPropertyChanged("Address1_PostalCode");
			}
		}
		
		/// <summary>
		/// Post office box number for address 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_postofficebox")]
		public string Address1_PostOfficeBox
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address1_postofficebox");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_PostOfficeBox");
				this.SetAttributeValue("address1_postofficebox", value);
				this.OnPropertyChanged("Address1_PostOfficeBox");
			}
		}
		
		/// <summary>
		/// Method of shipment for address 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_shippingmethodcode")]
		public Microsoft.Xrm.Sdk.OptionSetValue Address1_ShippingMethodCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address1_shippingmethodcode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_ShippingMethodCode");
				this.SetAttributeValue("address1_shippingmethodcode", value);
				this.OnPropertyChanged("Address1_ShippingMethodCode");
			}
		}
		
		/// <summary>
		/// State or province for address 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_stateorprovince")]
		public string Address1_StateOrProvince
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address1_stateorprovince");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_StateOrProvince");
				this.SetAttributeValue("address1_stateorprovince", value);
				this.OnPropertyChanged("Address1_StateOrProvince");
			}
		}
		
		/// <summary>
		/// First telephone number associated with address 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_telephone1")]
		public string Address1_Telephone1
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address1_telephone1");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_Telephone1");
				this.SetAttributeValue("address1_telephone1", value);
				this.OnPropertyChanged("Address1_Telephone1");
			}
		}
		
		/// <summary>
		/// Second telephone number associated with address 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_telephone2")]
		public string Address1_Telephone2
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address1_telephone2");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_Telephone2");
				this.SetAttributeValue("address1_telephone2", value);
				this.OnPropertyChanged("Address1_Telephone2");
			}
		}
		
		/// <summary>
		/// Third telephone number associated with address 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_telephone3")]
		public string Address1_Telephone3
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address1_telephone3");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_Telephone3");
				this.SetAttributeValue("address1_telephone3", value);
				this.OnPropertyChanged("Address1_Telephone3");
			}
		}
		
		/// <summary>
		/// United Parcel Service (UPS) zone for address 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_upszone")]
		public string Address1_UPSZone
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address1_upszone");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_UPSZone");
				this.SetAttributeValue("address1_upszone", value);
				this.OnPropertyChanged("Address1_UPSZone");
			}
		}
		
		/// <summary>
		/// UTC offset for address 1. This is the difference between local time and standard Coordinated Universal Time.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_utcoffset")]
		public System.Nullable<int> Address1_UTCOffset
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("address1_utcoffset");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_UTCOffset");
				this.SetAttributeValue("address1_utcoffset", value);
				this.OnPropertyChanged("Address1_UTCOffset");
			}
		}
		
		/// <summary>
		/// Unique identifier for address 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_addressid")]
		public System.Nullable<System.Guid> Address2_AddressId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("address2_addressid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_AddressId");
				this.SetAttributeValue("address2_addressid", value);
				this.OnPropertyChanged("Address2_AddressId");
			}
		}
		
		/// <summary>
		/// Type of address for address 2, such as billing, shipping, or primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_addresstypecode")]
		public Microsoft.Xrm.Sdk.OptionSetValue Address2_AddressTypeCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address2_addresstypecode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_AddressTypeCode");
				this.SetAttributeValue("address2_addresstypecode", value);
				this.OnPropertyChanged("Address2_AddressTypeCode");
			}
		}
		
		/// <summary>
		/// City name for address 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_city")]
		public string Address2_City
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address2_city");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_City");
				this.SetAttributeValue("address2_city", value);
				this.OnPropertyChanged("Address2_City");
			}
		}
		
		/// <summary>
		/// Shows the complete secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_composite")]
		public string Address2_Composite
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address2_composite");
			}
		}
		
		/// <summary>
		/// Country/region name in address 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_country")]
		public string Address2_Country
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address2_country");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_Country");
				this.SetAttributeValue("address2_country", value);
				this.OnPropertyChanged("Address2_Country");
			}
		}
		
		/// <summary>
		/// County name for address 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_county")]
		public string Address2_County
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address2_county");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_County");
				this.SetAttributeValue("address2_county", value);
				this.OnPropertyChanged("Address2_County");
			}
		}
		
		/// <summary>
		/// Fax number for address 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_fax")]
		public string Address2_Fax
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address2_fax");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_Fax");
				this.SetAttributeValue("address2_fax", value);
				this.OnPropertyChanged("Address2_Fax");
			}
		}
		
		/// <summary>
		/// Latitude for address 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_latitude")]
		public System.Nullable<double> Address2_Latitude
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("address2_latitude");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_Latitude");
				this.SetAttributeValue("address2_latitude", value);
				this.OnPropertyChanged("Address2_Latitude");
			}
		}
		
		/// <summary>
		/// First line for entering address 2 information.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_line1")]
		public string Address2_Line1
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address2_line1");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_Line1");
				this.SetAttributeValue("address2_line1", value);
				this.OnPropertyChanged("Address2_Line1");
			}
		}
		
		/// <summary>
		/// Second line for entering address 2 information.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_line2")]
		public string Address2_Line2
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address2_line2");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_Line2");
				this.SetAttributeValue("address2_line2", value);
				this.OnPropertyChanged("Address2_Line2");
			}
		}
		
		/// <summary>
		/// Third line for entering address 2 information.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_line3")]
		public string Address2_Line3
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address2_line3");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_Line3");
				this.SetAttributeValue("address2_line3", value);
				this.OnPropertyChanged("Address2_Line3");
			}
		}
		
		/// <summary>
		/// Longitude for address 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_longitude")]
		public System.Nullable<double> Address2_Longitude
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("address2_longitude");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_Longitude");
				this.SetAttributeValue("address2_longitude", value);
				this.OnPropertyChanged("Address2_Longitude");
			}
		}
		
		/// <summary>
		/// Name to enter for address 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_name")]
		public string Address2_Name
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address2_name");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_Name");
				this.SetAttributeValue("address2_name", value);
				this.OnPropertyChanged("Address2_Name");
			}
		}
		
		/// <summary>
		/// ZIP Code or postal code for address 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_postalcode")]
		public string Address2_PostalCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address2_postalcode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_PostalCode");
				this.SetAttributeValue("address2_postalcode", value);
				this.OnPropertyChanged("Address2_PostalCode");
			}
		}
		
		/// <summary>
		/// Post office box number for address 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_postofficebox")]
		public string Address2_PostOfficeBox
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address2_postofficebox");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_PostOfficeBox");
				this.SetAttributeValue("address2_postofficebox", value);
				this.OnPropertyChanged("Address2_PostOfficeBox");
			}
		}
		
		/// <summary>
		/// Method of shipment for address 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_shippingmethodcode")]
		public Microsoft.Xrm.Sdk.OptionSetValue Address2_ShippingMethodCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address2_shippingmethodcode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_ShippingMethodCode");
				this.SetAttributeValue("address2_shippingmethodcode", value);
				this.OnPropertyChanged("Address2_ShippingMethodCode");
			}
		}
		
		/// <summary>
		/// State or province for address 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_stateorprovince")]
		public string Address2_StateOrProvince
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address2_stateorprovince");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_StateOrProvince");
				this.SetAttributeValue("address2_stateorprovince", value);
				this.OnPropertyChanged("Address2_StateOrProvince");
			}
		}
		
		/// <summary>
		/// First telephone number associated with address 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_telephone1")]
		public string Address2_Telephone1
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address2_telephone1");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_Telephone1");
				this.SetAttributeValue("address2_telephone1", value);
				this.OnPropertyChanged("Address2_Telephone1");
			}
		}
		
		/// <summary>
		/// Second telephone number associated with address 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_telephone2")]
		public string Address2_Telephone2
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address2_telephone2");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_Telephone2");
				this.SetAttributeValue("address2_telephone2", value);
				this.OnPropertyChanged("Address2_Telephone2");
			}
		}
		
		/// <summary>
		/// Third telephone number associated with address 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_telephone3")]
		public string Address2_Telephone3
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address2_telephone3");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_Telephone3");
				this.SetAttributeValue("address2_telephone3", value);
				this.OnPropertyChanged("Address2_Telephone3");
			}
		}
		
		/// <summary>
		/// United Parcel Service (UPS) zone for address 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_upszone")]
		public string Address2_UPSZone
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address2_upszone");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_UPSZone");
				this.SetAttributeValue("address2_upszone", value);
				this.OnPropertyChanged("Address2_UPSZone");
			}
		}
		
		/// <summary>
		/// UTC offset for address 2. This is the difference between local time and standard Coordinated Universal Time.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_utcoffset")]
		public System.Nullable<int> Address2_UTCOffset
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("address2_utcoffset");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_UTCOffset");
				this.SetAttributeValue("address2_utcoffset", value);
				this.OnPropertyChanged("Address2_UTCOffset");
			}
		}
		
		/// <summary>
		/// The identifier for the application. This is used to access data in another application.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("applicationid")]
		public System.Nullable<System.Guid> ApplicationId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("applicationid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ApplicationId");
				this.SetAttributeValue("applicationid", value);
				this.OnPropertyChanged("ApplicationId");
			}
		}
		
		/// <summary>
		/// The URI used as a unique logical identifier for the external app. This can be used to validate the application.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("applicationiduri")]
		public string ApplicationIdUri
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("applicationiduri");
			}
		}
		
		/// <summary>
		/// This is the application directory object Id.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("azureactivedirectoryobjectid")]
		public System.Nullable<System.Guid> AzureActiveDirectoryObjectId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("azureactivedirectoryobjectid");
			}
		}
		
		/// <summary>
		/// Unique identifier of the business unit with which the user is associated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessunitid")]
		public Microsoft.Xrm.Sdk.EntityReference BusinessUnitId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("businessunitid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("BusinessUnitId");
				this.SetAttributeValue("businessunitid", value);
				this.OnPropertyChanged("BusinessUnitId");
			}
		}
		
		/// <summary>
		/// Fiscal calendar associated with the user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("calendarid")]
		public Microsoft.Xrm.Sdk.EntityReference CalendarId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("calendarid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CalendarId");
				this.SetAttributeValue("calendarid", value);
				this.OnPropertyChanged("CalendarId");
			}
		}
		
		/// <summary>
		/// License type of user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("caltype")]
		public Microsoft.Xrm.Sdk.OptionSetValue CALType
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("caltype");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CALType");
				this.SetAttributeValue("caltype", value);
				this.OnPropertyChanged("CALType");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Date and time when the user was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the systemuser.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CreatedOnBehalfBy");
				this.SetAttributeValue("createdonbehalfby", value);
				this.OnPropertyChanged("CreatedOnBehalfBy");
			}
		}
		
		/// <summary>
		/// Indicates if default outlook filters have been populated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("defaultfilterspopulated")]
		public System.Nullable<bool> DefaultFiltersPopulated
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("defaultfilterspopulated");
			}
		}
		
		/// <summary>
		/// Select the mailbox associated with this user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("defaultmailbox")]
		public Microsoft.Xrm.Sdk.EntityReference DefaultMailbox
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("defaultmailbox");
			}
		}
		
		/// <summary>
		/// Type a default folder name for the user's OneDrive For Business location.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("defaultodbfoldername")]
		public string DefaultOdbFolderName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("defaultodbfoldername");
			}
		}
		
		/// <summary>
		/// Reason for disabling the user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("disabledreason")]
		public string DisabledReason
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("disabledreason");
			}
		}
		
		/// <summary>
		/// Whether to display the user in service views.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("displayinserviceviews")]
		public System.Nullable<bool> DisplayInServiceViews
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("displayinserviceviews");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("DisplayInServiceViews");
				this.SetAttributeValue("displayinserviceviews", value);
				this.OnPropertyChanged("DisplayInServiceViews");
			}
		}
		
		/// <summary>
		/// Active Directory domain of which the user is a member.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("domainname")]
		public string DomainName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("domainname");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("DomainName");
				this.SetAttributeValue("domainname", value);
				this.OnPropertyChanged("DomainName");
			}
		}
		
		/// <summary>
		/// Shows the status of the primary email address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailrouteraccessapproval")]
		public Microsoft.Xrm.Sdk.OptionSetValue EmailRouterAccessApproval
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("emailrouteraccessapproval");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("EmailRouterAccessApproval");
				this.SetAttributeValue("emailrouteraccessapproval", value);
				this.OnPropertyChanged("EmailRouterAccessApproval");
			}
		}
		
		/// <summary>
		/// Employee identifier for the user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("employeeid")]
		public string EmployeeId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("employeeid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("EmployeeId");
				this.SetAttributeValue("employeeid", value);
				this.OnPropertyChanged("EmployeeId");
			}
		}
		
		/// <summary>
		/// Shows the default image for the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage")]
		public byte[] EntityImage
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<byte[]>("entityimage");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("EntityImage");
				this.SetAttributeValue("entityimage", value);
				this.OnPropertyChanged("EntityImage");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage_timestamp")]
		public System.Nullable<long> EntityImage_Timestamp
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("entityimage_timestamp");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage_url")]
		public string EntityImage_URL
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("entityimage_url");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimageid")]
		public System.Nullable<System.Guid> EntityImageId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("entityimageid");
			}
		}
		
		/// <summary>
		/// Exchange rate for the currency associated with the systemuser with respect to the base currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
		public System.Nullable<decimal> ExchangeRate
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate");
			}
		}
		
		/// <summary>
		/// First name of the user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("firstname")]
		public string FirstName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("firstname");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("FirstName");
				this.SetAttributeValue("firstname", value);
				this.OnPropertyChanged("FirstName");
			}
		}
		
		/// <summary>
		/// Full name of the user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fullname")]
		public string FullName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("fullname");
			}
		}
		
		/// <summary>
		/// Government identifier for the user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("governmentid")]
		public string GovernmentId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("governmentid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("GovernmentId");
				this.SetAttributeValue("governmentid", value);
				this.OnPropertyChanged("GovernmentId");
			}
		}
		
		/// <summary>
		/// Home phone number for the user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("homephone")]
		public string HomePhone
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("homephone");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("HomePhone");
				this.SetAttributeValue("homephone", value);
				this.OnPropertyChanged("HomePhone");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("identityid")]
		public System.Nullable<int> IdentityId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("identityid");
			}
		}
		
		/// <summary>
		/// Unique identifier of the data import or data migration that created this record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
		public System.Nullable<int> ImportSequenceNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ImportSequenceNumber");
				this.SetAttributeValue("importsequencenumber", value);
				this.OnPropertyChanged("ImportSequenceNumber");
			}
		}
		
		/// <summary>
		/// Incoming email delivery method for the user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("incomingemaildeliverymethod")]
		public Microsoft.Xrm.Sdk.OptionSetValue IncomingEmailDeliveryMethod
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("incomingemaildeliverymethod");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IncomingEmailDeliveryMethod");
				this.SetAttributeValue("incomingemaildeliverymethod", value);
				this.OnPropertyChanged("IncomingEmailDeliveryMethod");
			}
		}
		
		/// <summary>
		/// Internal email address for the user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("internalemailaddress")]
		public string InternalEMailAddress
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("internalemailaddress");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("InternalEMailAddress");
				this.SetAttributeValue("internalemailaddress", value);
				this.OnPropertyChanged("InternalEMailAddress");
			}
		}
		
		/// <summary>
		/// User invitation status.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("invitestatuscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue InviteStatusCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("invitestatuscode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("InviteStatusCode");
				this.SetAttributeValue("invitestatuscode", value);
				this.OnPropertyChanged("InviteStatusCode");
			}
		}
		
		/// <summary>
		/// Information about whether the user is enabled.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isdisabled")]
		public System.Nullable<bool> IsDisabled
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isdisabled");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IsDisabled");
				this.SetAttributeValue("isdisabled", value);
				this.OnPropertyChanged("IsDisabled");
			}
		}
		
		/// <summary>
		/// Shows the status of approval of the email address by O365 Admin.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isemailaddressapprovedbyo365admin")]
		public System.Nullable<bool> IsEmailAddressApprovedByO365Admin
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isemailaddressapprovedbyo365admin");
			}
		}
		
		/// <summary>
		/// Check if user is an integration user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isintegrationuser")]
		public System.Nullable<bool> IsIntegrationUser
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isintegrationuser");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IsIntegrationUser");
				this.SetAttributeValue("isintegrationuser", value);
				this.OnPropertyChanged("IsIntegrationUser");
			}
		}
		
		/// <summary>
		/// Information about whether the user is licensed.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("islicensed")]
		public System.Nullable<bool> IsLicensed
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("islicensed");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IsLicensed");
				this.SetAttributeValue("islicensed", value);
				this.OnPropertyChanged("IsLicensed");
			}
		}
		
		/// <summary>
		/// Information about whether the user is synced with the directory.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("issyncwithdirectory")]
		public System.Nullable<bool> IsSyncWithDirectory
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("issyncwithdirectory");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IsSyncWithDirectory");
				this.SetAttributeValue("issyncwithdirectory", value);
				this.OnPropertyChanged("IsSyncWithDirectory");
			}
		}
		
		/// <summary>
		/// Job title of the user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("jobtitle")]
		public string JobTitle
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("jobtitle");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("JobTitle");
				this.SetAttributeValue("jobtitle", value);
				this.OnPropertyChanged("JobTitle");
			}
		}
		
		/// <summary>
		/// Last name of the user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastname")]
		public string LastName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("lastname");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("LastName");
				this.SetAttributeValue("lastname", value);
				this.OnPropertyChanged("LastName");
			}
		}
		
		/// <summary>
		/// Middle name of the user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("middlename")]
		public string MiddleName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("middlename");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("MiddleName");
				this.SetAttributeValue("middlename", value);
				this.OnPropertyChanged("MiddleName");
			}
		}
		
		/// <summary>
		/// Mobile alert email address for the user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mobilealertemail")]
		public string MobileAlertEMail
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("mobilealertemail");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("MobileAlertEMail");
				this.SetAttributeValue("mobilealertemail", value);
				this.OnPropertyChanged("MobileAlertEMail");
			}
		}
		
		/// <summary>
		/// Items contained with a particular SystemUser.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mobileofflineprofileid")]
		public Microsoft.Xrm.Sdk.EntityReference MobileOfflineProfileId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("mobileofflineprofileid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("MobileOfflineProfileId");
				this.SetAttributeValue("mobileofflineprofileid", value);
				this.OnPropertyChanged("MobileOfflineProfileId");
			}
		}
		
		/// <summary>
		/// Mobile phone number for the user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mobilephone")]
		public string MobilePhone
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("mobilephone");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("MobilePhone");
				this.SetAttributeValue("mobilephone", value);
				this.OnPropertyChanged("MobilePhone");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who last modified the user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Date and time when the user was last modified.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who last modified the systemuser.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ModifiedOnBehalfBy");
				this.SetAttributeValue("modifiedonbehalfby", value);
				this.OnPropertyChanged("ModifiedOnBehalfBy");
			}
		}
		
		/// <summary>
		/// Describes whether user is opted out or not
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_gdproptout")]
		public System.Nullable<bool> msdyn_gdproptout
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("msdyn_gdproptout");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_gdproptout");
				this.SetAttributeValue("msdyn_gdproptout", value);
				this.OnPropertyChanged("msdyn_gdproptout");
			}
		}
		
		/// <summary>
		/// Nickname of the user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("nickname")]
		public string NickName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("nickname");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("NickName");
				this.SetAttributeValue("nickname", value);
				this.OnPropertyChanged("NickName");
			}
		}
		
		/// <summary>
		/// Unique identifier of the organization associated with the user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		public System.Nullable<System.Guid> OrganizationId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("organizationid");
			}
		}
		
		/// <summary>
		/// Outgoing email delivery method for the user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("outgoingemaildeliverymethod")]
		public Microsoft.Xrm.Sdk.OptionSetValue OutgoingEmailDeliveryMethod
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("outgoingemaildeliverymethod");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OutgoingEmailDeliveryMethod");
				this.SetAttributeValue("outgoingemaildeliverymethod", value);
				this.OnPropertyChanged("OutgoingEmailDeliveryMethod");
			}
		}
		
		/// <summary>
		/// Date and time that the record was migrated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
		public System.Nullable<System.DateTime> OverriddenCreatedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OverriddenCreatedOn");
				this.SetAttributeValue("overriddencreatedon", value);
				this.OnPropertyChanged("OverriddenCreatedOn");
			}
		}
		
		/// <summary>
		/// Unique identifier of the manager of the user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentsystemuserid")]
		public Microsoft.Xrm.Sdk.EntityReference ParentSystemUserId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentsystemuserid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ParentSystemUserId");
				this.SetAttributeValue("parentsystemuserid", value);
				this.OnPropertyChanged("ParentSystemUserId");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("passporthi")]
		public System.Nullable<int> PassportHi
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("passporthi");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PassportHi");
				this.SetAttributeValue("passporthi", value);
				this.OnPropertyChanged("PassportHi");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("passportlo")]
		public System.Nullable<int> PassportLo
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("passportlo");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PassportLo");
				this.SetAttributeValue("passportlo", value);
				this.OnPropertyChanged("PassportLo");
			}
		}
		
		/// <summary>
		/// Personal email address of the user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("personalemailaddress")]
		public string PersonalEMailAddress
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("personalemailaddress");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PersonalEMailAddress");
				this.SetAttributeValue("personalemailaddress", value);
				this.OnPropertyChanged("PersonalEMailAddress");
			}
		}
		
		/// <summary>
		/// URL for the Website on which a photo of the user is located.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("photourl")]
		public string PhotoUrl
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("photourl");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PhotoUrl");
				this.SetAttributeValue("photourl", value);
				this.OnPropertyChanged("PhotoUrl");
			}
		}
		
		/// <summary>
		/// User's position in hierarchical security model.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("positionid")]
		public Microsoft.Xrm.Sdk.EntityReference PositionId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("positionid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PositionId");
				this.SetAttributeValue("positionid", value);
				this.OnPropertyChanged("PositionId");
			}
		}
		
		/// <summary>
		/// Preferred address for the user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredaddresscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue PreferredAddressCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("preferredaddresscode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PreferredAddressCode");
				this.SetAttributeValue("preferredaddresscode", value);
				this.OnPropertyChanged("PreferredAddressCode");
			}
		}
		
		/// <summary>
		/// Preferred email address for the user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredemailcode")]
		public Microsoft.Xrm.Sdk.OptionSetValue PreferredEmailCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("preferredemailcode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PreferredEmailCode");
				this.SetAttributeValue("preferredemailcode", value);
				this.OnPropertyChanged("PreferredEmailCode");
			}
		}
		
		/// <summary>
		/// Preferred phone number for the user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredphonecode")]
		public Microsoft.Xrm.Sdk.OptionSetValue PreferredPhoneCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("preferredphonecode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PreferredPhoneCode");
				this.SetAttributeValue("preferredphonecode", value);
				this.OnPropertyChanged("PreferredPhoneCode");
			}
		}
		
		/// <summary>
		/// Shows the ID of the process.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processid")]
		public System.Nullable<System.Guid> ProcessId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("processid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ProcessId");
				this.SetAttributeValue("processid", value);
				this.OnPropertyChanged("ProcessId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the default queue for the user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("queueid")]
		public Microsoft.Xrm.Sdk.EntityReference QueueId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("queueid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("QueueId");
				this.SetAttributeValue("queueid", value);
				this.OnPropertyChanged("QueueId");
			}
		}
		
		/// <summary>
		/// Salutation for correspondence with the user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salutation")]
		public string Salutation
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("salutation");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Salutation");
				this.SetAttributeValue("salutation", value);
				this.OnPropertyChanged("Salutation");
			}
		}
		
		/// <summary>
		/// Check if user is a setup user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("setupuser")]
		public System.Nullable<bool> SetupUser
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("setupuser");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SetupUser");
				this.SetAttributeValue("setupuser", value);
				this.OnPropertyChanged("SetupUser");
			}
		}
		
		/// <summary>
		/// SharePoint Work Email Address
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sharepointemailaddress")]
		public string SharePointEmailAddress
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("sharepointemailaddress");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SharePointEmailAddress");
				this.SetAttributeValue("sharepointemailaddress", value);
				this.OnPropertyChanged("SharePointEmailAddress");
			}
		}
		
		/// <summary>
		/// Site at which the user is located.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("siteid")]
		public Microsoft.Xrm.Sdk.EntityReference SiteId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("siteid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SiteId");
				this.SetAttributeValue("siteid", value);
				this.OnPropertyChanged("SiteId");
			}
		}
		
		/// <summary>
		/// Skill set of the user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("skills")]
		public string Skills
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("skills");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Skills");
				this.SetAttributeValue("skills", value);
				this.OnPropertyChanged("Skills");
			}
		}
		
		/// <summary>
		/// Shows the ID of the stage.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stageid")]
		public System.Nullable<System.Guid> StageId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("stageid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("StageId");
				this.SetAttributeValue("stageid", value);
				this.OnPropertyChanged("StageId");
			}
		}
		
		/// <summary>
		/// Unique identifier for the user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("systemuserid")]
		public System.Nullable<System.Guid> SystemUserId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("systemuserid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SystemUserId");
				this.SetAttributeValue("systemuserid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("SystemUserId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("systemuserid")]
		public override System.Guid Id
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return base.Id;
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.SystemUserId = value;
			}
		}
		
		/// <summary>
		/// Unique identifier of the territory to which the user is assigned.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("territoryid")]
		public Microsoft.Xrm.Sdk.EntityReference TerritoryId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("territoryid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TerritoryId");
				this.SetAttributeValue("territoryid", value);
				this.OnPropertyChanged("TerritoryId");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleversionnumber")]
		public System.Nullable<int> TimeZoneRuleVersionNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TimeZoneRuleVersionNumber");
				this.SetAttributeValue("timezoneruleversionnumber", value);
				this.OnPropertyChanged("TimeZoneRuleVersionNumber");
			}
		}
		
		/// <summary>
		/// Title of the user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("title")]
		public string Title
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("title");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Title");
				this.SetAttributeValue("title", value);
				this.OnPropertyChanged("Title");
			}
		}
		
		/// <summary>
		/// Unique identifier of the currency associated with the systemuser.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		public Microsoft.Xrm.Sdk.EntityReference TransactionCurrencyId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("transactioncurrencyid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TransactionCurrencyId");
				this.SetAttributeValue("transactioncurrencyid", value);
				this.OnPropertyChanged("TransactionCurrencyId");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("traversedpath")]
		public string TraversedPath
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("traversedpath");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TraversedPath");
				this.SetAttributeValue("traversedpath", value);
				this.OnPropertyChanged("TraversedPath");
			}
		}
		
		/// <summary>
		/// Shows the type of user license.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("userlicensetype")]
		public System.Nullable<int> UserLicenseType
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("userlicensetype");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("UserLicenseType");
				this.SetAttributeValue("userlicensetype", value);
				this.OnPropertyChanged("UserLicenseType");
			}
		}
		
		/// <summary>
		///  User PUID User Identifiable Information
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("userpuid")]
		public string UserPuid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("userpuid");
			}
		}
		
		/// <summary>
		/// Time zone code that was in use when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcconversiontimezonecode")]
		public System.Nullable<int> UTCConversionTimeZoneCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("UTCConversionTimeZoneCode");
				this.SetAttributeValue("utcconversiontimezonecode", value);
				this.OnPropertyChanged("UTCConversionTimeZoneCode");
			}
		}
		
		/// <summary>
		/// Version number of the user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// Windows Live ID
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("windowsliveid")]
		public string WindowsLiveID
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("windowsliveid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("WindowsLiveID");
				this.SetAttributeValue("windowsliveid", value);
				this.OnPropertyChanged("WindowsLiveID");
			}
		}
		
		/// <summary>
		/// User's Yammer login email address
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yammeremailaddress")]
		public string YammerEmailAddress
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("yammeremailaddress");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("YammerEmailAddress");
				this.SetAttributeValue("yammeremailaddress", value);
				this.OnPropertyChanged("YammerEmailAddress");
			}
		}
		
		/// <summary>
		/// User's Yammer ID
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yammeruserid")]
		public string YammerUserId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("yammeruserid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("YammerUserId");
				this.SetAttributeValue("yammeruserid", value);
				this.OnPropertyChanged("YammerUserId");
			}
		}
		
		/// <summary>
		/// Pronunciation of the first name of the user, written in phonetic hiragana or katakana characters.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yomifirstname")]
		public string YomiFirstName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("yomifirstname");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("YomiFirstName");
				this.SetAttributeValue("yomifirstname", value);
				this.OnPropertyChanged("YomiFirstName");
			}
		}
		
		/// <summary>
		/// Pronunciation of the full name of the user, written in phonetic hiragana or katakana characters.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yomifullname")]
		public string YomiFullName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("yomifullname");
			}
		}
		
		/// <summary>
		/// Pronunciation of the last name of the user, written in phonetic hiragana or katakana characters.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yomilastname")]
		public string YomiLastName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("yomilastname");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("YomiLastName");
				this.SetAttributeValue("yomilastname", value);
				this.OnPropertyChanged("YomiLastName");
			}
		}
		
		/// <summary>
		/// Pronunciation of the middle name of the user, written in phonetic hiragana or katakana characters.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yomimiddlename")]
		public string YomiMiddleName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("yomimiddlename");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("YomiMiddleName");
				this.SetAttributeValue("yomimiddlename", value);
				this.OnPropertyChanged("YomiMiddleName");
			}
		}
	}
}