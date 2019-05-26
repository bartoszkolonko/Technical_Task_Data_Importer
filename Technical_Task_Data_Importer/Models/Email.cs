namespace CrmEarlyBound
{
	
	[System.Runtime.Serialization.DataContractAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9479")]
	public enum EmailState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Open = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Completed = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Canceled = 2,
	}
	
	/// <summary>
	/// Activity that is delivered using email protocols.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("email")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9479")]
	public partial class Email : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public Email() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "email";
		
		public const string EntitySchemaName = "Email";
		
		public const string PrimaryIdAttribute = "activityid";
		
		public const string PrimaryNameAttribute = "subject";
		
		public const int EntityTypeCode = 4202;
		
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
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityadditionalparams")]
		public string ActivityAdditionalParams
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("activityadditionalparams");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ActivityAdditionalParams");
				this.SetAttributeValue("activityadditionalparams", value);
				this.OnPropertyChanged("ActivityAdditionalParams");
			}
		}
		
		/// <summary>
		/// Unique identifier of the email activity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
		public System.Nullable<System.Guid> ActivityId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("activityid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ActivityId");
				this.SetAttributeValue("activityid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("ActivityId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
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
				this.ActivityId = value;
			}
		}
		
		/// <summary>
		/// Shows the type of activity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activitytypecode")]
		public string ActivityTypeCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("activitytypecode");
			}
		}
		
		/// <summary>
		/// Type the number of minutes spent creating and sending the email. The duration is used in reporting.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("actualdurationminutes")]
		public System.Nullable<int> ActualDurationMinutes
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("actualdurationminutes");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ActualDurationMinutes");
				this.SetAttributeValue("actualdurationminutes", value);
				this.OnPropertyChanged("ActualDurationMinutes");
			}
		}
		
		/// <summary>
		/// Enter the actual end date and time of the email. By default, it displays the date and time when the activity was completed or canceled, but can be edited to capture the actual time to create and send the email.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("actualend")]
		public System.Nullable<System.DateTime> ActualEnd
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("actualend");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ActualEnd");
				this.SetAttributeValue("actualend", value);
				this.OnPropertyChanged("ActualEnd");
			}
		}
		
		/// <summary>
		/// Enter the actual start date and time for the email. By default, it displays the date and time when the activity was created, but can be edited to capture the actual time to create and send the email.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("actualstart")]
		public System.Nullable<System.DateTime> ActualStart
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("actualstart");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ActualStart");
				this.SetAttributeValue("actualstart", value);
				this.OnPropertyChanged("ActualStart");
			}
		}
		
		/// <summary>
		/// Shows the umber of attachments of the email message.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("attachmentcount")]
		public System.Nullable<int> AttachmentCount
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("attachmentcount");
			}
		}
		
		/// <summary>
		/// Shows the number of times an email attachment has been viewed.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("attachmentopencount")]
		public System.Nullable<int> AttachmentOpenCount
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("attachmentopencount");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("AttachmentOpenCount");
				this.SetAttributeValue("attachmentopencount", value);
				this.OnPropertyChanged("AttachmentOpenCount");
			}
		}
		
		/// <summary>
		/// Hash of base of conversation index.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("baseconversationindexhash")]
		public System.Nullable<int> BaseConversationIndexHash
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("baseconversationindexhash");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("BaseConversationIndexHash");
				this.SetAttributeValue("baseconversationindexhash", value);
				this.OnPropertyChanged("BaseConversationIndexHash");
			}
		}
		
		/// <summary>
		/// Enter the recipients that are included on the email distribution, but are not displayed to other recipients.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("bcc")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.ActivityParty> Bcc
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				Microsoft.Xrm.Sdk.EntityCollection collection = this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityCollection>("bcc");
				if (((collection != null) 
							&& (collection.Entities != null)))
				{
					return System.Linq.Enumerable.Cast<CrmEarlyBound.ActivityParty>(collection.Entities);
				}
				else
				{
					return null;
				}
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Bcc");
				if ((value == null))
				{
					this.SetAttributeValue("bcc", value);
				}
				else
				{
					this.SetAttributeValue("bcc", new Microsoft.Xrm.Sdk.EntityCollection(new System.Collections.Generic.List<Microsoft.Xrm.Sdk.Entity>(value)));
				}
				this.OnPropertyChanged("Bcc");
			}
		}
		
		/// <summary>
		/// Type a category to identify the email type, such as lead outreach, customer follow-up, or service alert, to tie the email to a business group or function.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("category")]
		public string Category
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("category");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Category");
				this.SetAttributeValue("category", value);
				this.OnPropertyChanged("Category");
			}
		}
		
		/// <summary>
		/// Enter the recipients that should be copied on the email.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("cc")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.ActivityParty> Cc
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				Microsoft.Xrm.Sdk.EntityCollection collection = this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityCollection>("cc");
				if (((collection != null) 
							&& (collection.Entities != null)))
				{
					return System.Linq.Enumerable.Cast<CrmEarlyBound.ActivityParty>(collection.Entities);
				}
				else
				{
					return null;
				}
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Cc");
				if ((value == null))
				{
					this.SetAttributeValue("cc", value);
				}
				else
				{
					this.SetAttributeValue("cc", new Microsoft.Xrm.Sdk.EntityCollection(new System.Collections.Generic.List<Microsoft.Xrm.Sdk.Entity>(value)));
				}
				this.OnPropertyChanged("Cc");
			}
		}
		
		/// <summary>
		/// Indicates if the body is compressed.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("compressed")]
		public System.Nullable<bool> Compressed
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("compressed");
			}
		}
		
		/// <summary>
		/// Identifier for all the email responses for this conversation.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("conversationindex")]
		public string ConversationIndex
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("conversationindex");
			}
		}
		
		/// <summary>
		/// Conversation Tracking Id.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("conversationtrackingid")]
		public System.Nullable<System.Guid> ConversationTrackingId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("conversationtrackingid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ConversationTrackingId");
				this.SetAttributeValue("conversationtrackingid", value);
				this.OnPropertyChanged("ConversationTrackingId");
			}
		}
		
		/// <summary>
		/// Shows how an email is matched to an existing email in Microsoft Dynamics 365. For system use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("correlationmethod")]
		public Microsoft.Xrm.Sdk.OptionSetValue CorrelationMethod
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("correlationmethod");
			}
		}
		
		/// <summary>
		/// Shows who created the record.
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
		/// Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.
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
		/// Shows who created the record on behalf of another user.
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
		/// Enter the expected date and time when email will be sent.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("delayedemailsendtime")]
		public System.Nullable<System.DateTime> DelayedEmailSendTime
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("delayedemailsendtime");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("DelayedEmailSendTime");
				this.SetAttributeValue("delayedemailsendtime", value);
				this.OnPropertyChanged("DelayedEmailSendTime");
			}
		}
		
		/// <summary>
		/// Shows the count of the number of attempts made to send the email. The count is used as an indicator of email routing issues.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("deliveryattempts")]
		public System.Nullable<int> DeliveryAttempts
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("deliveryattempts");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("DeliveryAttempts");
				this.SetAttributeValue("deliveryattempts", value);
				this.OnPropertyChanged("DeliveryAttempts");
			}
		}
		
		/// <summary>
		/// Select the priority of delivery of the email to the email server.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("deliveryprioritycode")]
		public Microsoft.Xrm.Sdk.OptionSetValue DeliveryPriorityCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("deliveryprioritycode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("DeliveryPriorityCode");
				this.SetAttributeValue("deliveryprioritycode", value);
				this.OnPropertyChanged("DeliveryPriorityCode");
			}
		}
		
		/// <summary>
		/// Select whether the sender should receive confirmation that the email was delivered.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("deliveryreceiptrequested")]
		public System.Nullable<bool> DeliveryReceiptRequested
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("deliveryreceiptrequested");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("DeliveryReceiptRequested");
				this.SetAttributeValue("deliveryreceiptrequested", value);
				this.OnPropertyChanged("DeliveryReceiptRequested");
			}
		}
		
		/// <summary>
		/// Type the greeting and message text of the email.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("description")]
		public string Description
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("description");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Description");
				this.SetAttributeValue("description", value);
				this.OnPropertyChanged("Description");
			}
		}
		
		/// <summary>
		/// Select the direction of the email as incoming or outbound.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("directioncode")]
		public System.Nullable<bool> DirectionCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("directioncode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("DirectionCode");
				this.SetAttributeValue("directioncode", value);
				this.OnPropertyChanged("DirectionCode");
			}
		}
		
		/// <summary>
		/// Shows the date and time when an email reminder expires.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailreminderexpirytime")]
		public System.Nullable<System.DateTime> EmailReminderExpiryTime
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("emailreminderexpirytime");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("EmailReminderExpiryTime");
				this.SetAttributeValue("emailreminderexpirytime", value);
				this.OnPropertyChanged("EmailReminderExpiryTime");
			}
		}
		
		/// <summary>
		/// Shows the status of the email reminder.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailreminderstatus")]
		public Microsoft.Xrm.Sdk.OptionSetValue EmailReminderStatus
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("emailreminderstatus");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailremindertext")]
		public string EmailReminderText
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("emailremindertext");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("EmailReminderText");
				this.SetAttributeValue("emailremindertext", value);
				this.OnPropertyChanged("EmailReminderText");
			}
		}
		
		/// <summary>
		/// Shows the type of the email reminder.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailremindertype")]
		public Microsoft.Xrm.Sdk.OptionSetValue EmailReminderType
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("emailremindertype");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("EmailReminderType");
				this.SetAttributeValue("emailremindertype", value);
				this.OnPropertyChanged("EmailReminderType");
			}
		}
		
		/// <summary>
		/// Shows the sender of the email.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailsender")]
		public Microsoft.Xrm.Sdk.EntityReference EmailSender
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("emailsender");
			}
		}
		
		/// <summary>
		/// Email Tracking Id.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailtrackingid")]
		public System.Nullable<System.Guid> EmailTrackingId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("emailtrackingid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("EmailTrackingId");
				this.SetAttributeValue("emailtrackingid", value);
				this.OnPropertyChanged("EmailTrackingId");
			}
		}
		
		/// <summary>
		/// Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.
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
		/// Select whether the email allows following recipient activities sent from Microsoft Dynamics 365.This is user preference state which can be overridden by system evaluated state.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("followemailuserpreference")]
		public System.Nullable<bool> FollowEmailUserPreference
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("followemailuserpreference");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("FollowEmailUserPreference");
				this.SetAttributeValue("followemailuserpreference", value);
				this.OnPropertyChanged("FollowEmailUserPreference");
			}
		}
		
		/// <summary>
		/// Enter the sender of the email.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("from")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.ActivityParty> From
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				Microsoft.Xrm.Sdk.EntityCollection collection = this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityCollection>("from");
				if (((collection != null) 
							&& (collection.Entities != null)))
				{
					return System.Linq.Enumerable.Cast<CrmEarlyBound.ActivityParty>(collection.Entities);
				}
				else
				{
					return null;
				}
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("From");
				if ((value == null))
				{
					this.SetAttributeValue("from", value);
				}
				else
				{
					this.SetAttributeValue("from", new Microsoft.Xrm.Sdk.EntityCollection(new System.Collections.Generic.List<Microsoft.Xrm.Sdk.Entity>(value)));
				}
				this.OnPropertyChanged("From");
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
		/// Type the ID of the email message that this email activity is a response to.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("inreplyto")]
		public string InReplyTo
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("inreplyto");
			}
		}
		
		/// <summary>
		/// Information regarding whether the email activity was billed as part of resolving a case.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isbilled")]
		public System.Nullable<bool> IsBilled
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isbilled");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IsBilled");
				this.SetAttributeValue("isbilled", value);
				this.OnPropertyChanged("IsBilled");
			}
		}
		
		/// <summary>
		/// For internal use only. Shows whether this email is followed. This is evaluated state which overrides user selection of follow email.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isemailfollowed")]
		public System.Nullable<bool> IsEmailFollowed
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isemailfollowed");
			}
		}
		
		/// <summary>
		/// For internal use only. Shows whether this email Reminder is Set.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isemailreminderset")]
		public System.Nullable<bool> IsEmailReminderSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isemailreminderset");
			}
		}
		
		/// <summary>
		/// Information regarding whether the activity is a regular activity type or event type.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isregularactivity")]
		public System.Nullable<bool> IsRegularActivity
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isregularactivity");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isunsafe")]
		public System.Nullable<int> IsUnsafe
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("isunsafe");
			}
		}
		
		/// <summary>
		/// Indication if the email was created by a workflow rule.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isworkflowcreated")]
		public System.Nullable<bool> IsWorkflowCreated
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isworkflowcreated");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IsWorkflowCreated");
				this.SetAttributeValue("isworkflowcreated", value);
				this.OnPropertyChanged("IsWorkflowCreated");
			}
		}
		
		/// <summary>
		/// Contains the date and time stamp of the last on hold time.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastonholdtime")]
		public System.Nullable<System.DateTime> LastOnHoldTime
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("lastonholdtime");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("LastOnHoldTime");
				this.SetAttributeValue("lastonholdtime", value);
				this.OnPropertyChanged("LastOnHoldTime");
			}
		}
		
		/// <summary>
		/// Shows the latest date and time when email was opened.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastopenedtime")]
		public System.Nullable<System.DateTime> LastOpenedTime
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("lastopenedtime");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("LastOpenedTime");
				this.SetAttributeValue("lastopenedtime", value);
				this.OnPropertyChanged("LastOpenedTime");
			}
		}
		
		/// <summary>
		/// Shows the number of times a link in an email has been clicked.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("linksclickedcount")]
		public System.Nullable<int> LinksClickedCount
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("linksclickedcount");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("LinksClickedCount");
				this.SetAttributeValue("linksclickedcount", value);
				this.OnPropertyChanged("LinksClickedCount");
			}
		}
		
		/// <summary>
		/// Unique identifier of the email message. Used only for email that is received.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("messageid")]
		public string MessageId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("messageid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("MessageId");
				this.SetAttributeValue("messageid", value);
				this.OnPropertyChanged("MessageId");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("messageiddupcheck")]
		[System.ObsoleteAttribute()]
		public System.Nullable<System.Guid> MessageIdDupCheck
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("messageiddupcheck");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("MessageIdDupCheck");
				this.SetAttributeValue("messageiddupcheck", value);
				this.OnPropertyChanged("MessageIdDupCheck");
			}
		}
		
		/// <summary>
		/// MIME type of the email message data.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mimetype")]
		public string MimeType
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("mimetype");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("MimeType");
				this.SetAttributeValue("mimetype", value);
				this.OnPropertyChanged("MimeType");
			}
		}
		
		/// <summary>
		/// Shows who last updated the record.
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
		/// Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.
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
		/// Shows who last updated the record on behalf of another user.
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
		/// Select the notification code to identify issues with the email recipients or attachments, such as blocked attachments.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("notifications")]
		public Microsoft.Xrm.Sdk.OptionSetValue Notifications
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("notifications");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Notifications");
				this.SetAttributeValue("notifications", value);
				this.OnPropertyChanged("Notifications");
			}
		}
		
		/// <summary>
		/// Shows how long, in minutes, that the record was on hold.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("onholdtime")]
		public System.Nullable<int> OnHoldTime
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("onholdtime");
			}
		}
		
		/// <summary>
		/// Shows the number of times an email has been opened.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("opencount")]
		public System.Nullable<int> OpenCount
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("opencount");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OpenCount");
				this.SetAttributeValue("opencount", value);
				this.OnPropertyChanged("OpenCount");
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
		/// Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
		public Microsoft.Xrm.Sdk.EntityReference OwnerId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OwnerId");
				this.SetAttributeValue("ownerid", value);
				this.OnPropertyChanged("OwnerId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the business unit that owns the email activity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit");
			}
		}
		
		/// <summary>
		/// Unique identifier of the team who owns the email activity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		public Microsoft.Xrm.Sdk.EntityReference OwningTeam
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who owns the email activity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		public Microsoft.Xrm.Sdk.EntityReference OwningUser
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser");
			}
		}
		
		/// <summary>
		/// Select the activity that the email is associated with.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentactivityid")]
		public Microsoft.Xrm.Sdk.EntityReference ParentActivityId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentactivityid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ParentActivityId");
				this.SetAttributeValue("parentactivityid", value);
				this.OnPropertyChanged("ParentActivityId");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("postponeemailprocessinguntil")]
		public System.Nullable<System.DateTime> PostponeEmailProcessingUntil
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("postponeemailprocessinguntil");
			}
		}
		
		/// <summary>
		/// Select the priority so that preferred customers or critical issues are handled quickly.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("prioritycode")]
		public Microsoft.Xrm.Sdk.OptionSetValue PriorityCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("prioritycode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PriorityCode");
				this.SetAttributeValue("prioritycode", value);
				this.OnPropertyChanged("PriorityCode");
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
		/// Indicates that a read receipt is requested.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("readreceiptrequested")]
		public System.Nullable<bool> ReadReceiptRequested
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("readreceiptrequested");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ReadReceiptRequested");
				this.SetAttributeValue("readreceiptrequested", value);
				this.OnPropertyChanged("ReadReceiptRequested");
			}
		}
		
		/// <summary>
		/// Choose the record that the email relates to.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
		public Microsoft.Xrm.Sdk.EntityReference RegardingObjectId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("regardingobjectid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("RegardingObjectId");
				this.SetAttributeValue("regardingobjectid", value);
				this.OnPropertyChanged("RegardingObjectId");
			}
		}
		
		/// <summary>
		/// Reminder Action Card Id.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("reminderactioncardid")]
		public System.Nullable<System.Guid> ReminderActionCardId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("reminderactioncardid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ReminderActionCardId");
				this.SetAttributeValue("reminderactioncardid", value);
				this.OnPropertyChanged("ReminderActionCardId");
			}
		}
		
		/// <summary>
		/// Shows the number of replies received for an email.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("replycount")]
		public System.Nullable<int> ReplyCount
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("replycount");
			}
		}
		
		/// <summary>
		/// Scheduled duration of the email activity, specified in minutes.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("scheduleddurationminutes")]
		public System.Nullable<int> ScheduledDurationMinutes
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("scheduleddurationminutes");
			}
		}
		
		/// <summary>
		/// Enter the expected due date and time for the activity to be completed to provide details about when the email will be sent.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("scheduledend")]
		public System.Nullable<System.DateTime> ScheduledEnd
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("scheduledend");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ScheduledEnd");
				this.SetAttributeValue("scheduledend", value);
				this.OnPropertyChanged("ScheduledEnd");
			}
		}
		
		/// <summary>
		/// Enter the expected start date and time for the activity to provide details about the tentative time when the email activity must be initiated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("scheduledstart")]
		public System.Nullable<System.DateTime> ScheduledStart
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("scheduledstart");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ScheduledStart");
				this.SetAttributeValue("scheduledstart", value);
				this.OnPropertyChanged("ScheduledStart");
			}
		}
		
		/// <summary>
		/// Sender of the email.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sender")]
		public string Sender
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("sender");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Sender");
				this.SetAttributeValue("sender", value);
				this.OnPropertyChanged("Sender");
			}
		}
		
		/// <summary>
		/// Select the mailbox associated with the sender of the email message.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sendermailboxid")]
		public Microsoft.Xrm.Sdk.EntityReference SenderMailboxId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("sendermailboxid");
			}
		}
		
		/// <summary>
		/// Shows the parent account of the sender of the email.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sendersaccount")]
		public Microsoft.Xrm.Sdk.EntityReference SendersAccount
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("sendersaccount");
			}
		}
		
		/// <summary>
		/// Shows the date and time that the email was sent.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("senton")]
		public System.Nullable<System.DateTime> SentOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("senton");
			}
		}
		
		/// <summary>
		/// Unique identifier for the associated service.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("serviceid")]
		public Microsoft.Xrm.Sdk.EntityReference ServiceId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("serviceid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ServiceId");
				this.SetAttributeValue("serviceid", value);
				this.OnPropertyChanged("ServiceId");
			}
		}
		
		/// <summary>
		/// Choose the service level agreement (SLA) that you want to apply to the email record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("slaid")]
		public Microsoft.Xrm.Sdk.EntityReference SLAId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("slaid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SLAId");
				this.SetAttributeValue("slaid", value);
				this.OnPropertyChanged("SLAId");
			}
		}
		
		/// <summary>
		/// Last SLA that was applied to this email. This field is for internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("slainvokedid")]
		public Microsoft.Xrm.Sdk.EntityReference SLAInvokedId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("slainvokedid");
			}
		}
		
		/// <summary>
		/// Shows the date and time by which the activities are sorted.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sortdate")]
		public System.Nullable<System.DateTime> SortDate
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("sortdate");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SortDate");
				this.SetAttributeValue("sortdate", value);
				this.OnPropertyChanged("SortDate");
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
		/// Shows whether the email is open, completed, or canceled. Completed and canceled email is read-only and can't be edited.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<CrmEarlyBound.EmailState> StateCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((CrmEarlyBound.EmailState)(System.Enum.ToObject(typeof(CrmEarlyBound.EmailState), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("StateCode");
				if ((value == null))
				{
					this.SetAttributeValue("statecode", null);
				}
				else
				{
					this.SetAttributeValue("statecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("StateCode");
			}
		}
		
		/// <summary>
		/// Select the email's status.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue StatusCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("StatusCode");
				this.SetAttributeValue("statuscode", value);
				this.OnPropertyChanged("StatusCode");
			}
		}
		
		/// <summary>
		/// Type a subcategory to identify the email type and relate the activity to a specific product, sales region, business group, or other function.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("subcategory")]
		public string Subcategory
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("subcategory");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Subcategory");
				this.SetAttributeValue("subcategory", value);
				this.OnPropertyChanged("Subcategory");
			}
		}
		
		/// <summary>
		/// Type a short description about the objective or primary topic of the email.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("subject")]
		public string Subject
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("subject");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Subject");
				this.SetAttributeValue("subject", value);
				this.OnPropertyChanged("Subject");
			}
		}
		
		/// <summary>
		/// Shows the Microsoft Office Outlook account for the user who submitted the email to Microsoft Dynamics 365.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("submittedby")]
		public string SubmittedBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("submittedby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SubmittedBy");
				this.SetAttributeValue("submittedby", value);
				this.OnPropertyChanged("SubmittedBy");
			}
		}
		
		/// <summary>
		/// For internal use only. ID for template used in email.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("templateid")]
		public Microsoft.Xrm.Sdk.EntityReference TemplateId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("templateid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TemplateId");
				this.SetAttributeValue("templateid", value);
				this.OnPropertyChanged("TemplateId");
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
		/// Enter the account, contact, lead, queue, or user recipients for the email.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("to")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.ActivityParty> To
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				Microsoft.Xrm.Sdk.EntityCollection collection = this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityCollection>("to");
				if (((collection != null) 
							&& (collection.Entities != null)))
				{
					return System.Linq.Enumerable.Cast<CrmEarlyBound.ActivityParty>(collection.Entities);
				}
				else
				{
					return null;
				}
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("To");
				if ((value == null))
				{
					this.SetAttributeValue("to", value);
				}
				else
				{
					this.SetAttributeValue("to", new Microsoft.Xrm.Sdk.EntityCollection(new System.Collections.Generic.List<Microsoft.Xrm.Sdk.Entity>(value)));
				}
				this.OnPropertyChanged("To");
			}
		}
		
		/// <summary>
		/// Shows the email addresses corresponding to the recipients.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("torecipients")]
		public string ToRecipients
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("torecipients");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ToRecipients");
				this.SetAttributeValue("torecipients", value);
				this.OnPropertyChanged("ToRecipients");
			}
		}
		
		/// <summary>
		/// Shows the tracking token assigned to the email to make sure responses are automatically tracked in Microsoft Dynamics 365.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("trackingtoken")]
		public string TrackingToken
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("trackingtoken");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TrackingToken");
				this.SetAttributeValue("trackingtoken", value);
				this.OnPropertyChanged("TrackingToken");
			}
		}
		
		/// <summary>
		/// Choose the local currency for the record to make sure budgets are reported in the correct currency.
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
	}
}