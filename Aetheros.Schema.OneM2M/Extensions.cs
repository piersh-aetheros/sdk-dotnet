namespace Aetheros.Schema.OneM2M
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Xml.Serialization;
	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;

	public partial class PrimitiveContent
	{
		[JsonProperty("acp")]
		[XmlElement("acp")]
		public AccessControlPolicy AccessControlPolicy { get; set; }

		[JsonProperty("ae")]
		[XmlElement("ae")]
		public AE AE { get; set; }

		[JsonProperty("cnt")]
		[XmlElement("cnt")]
		public Container Container { get; set; }

		[JsonProperty("cin")]
		[XmlElement("cin")]
		public ContentInstance ContentInstance { get; set; }

		[JsonProperty("cb")]
		[XmlElement("cb")]
		public CSEBase CSEBase { get; set; }

		[JsonProperty("dlv")]
		[XmlElement("dlv")]
		public Delivery Delivery { get; set; }

		[JsonProperty("evcg")]
		[XmlElement("evcg")]
		public EventConfig EventConfig { get; set; }

		[JsonProperty("exin")]
		[XmlElement("exin")]
		public ExecInstance ExecInstance { get; set; }

		[JsonProperty("grp")]
		[XmlElement("grp")]
		public Group Group { get; set; }

		[JsonProperty("lcp")]
		[XmlElement("lcp")]
		public LocationPolicy LocationPolicy { get; set; }

		[JsonProperty("mssp")]
		[XmlElement("mssp")]
		public M2MServiceSubscriptionProfile M2MServiceSubscriptionProfile { get; set; }

		[JsonProperty("mgc")]
		[XmlElement("mgc")]
		public MgmtCmd MgmtCmd { get; set; }

		//[JsonProperty("")]
		//[XmlElement("")]
		//public MgmtObj MgmtObj { get; set; }

		[JsonProperty("nod")]
		[XmlElement("nod")]
		public Node Node { get; set; }

		[JsonProperty("pch")]
		[XmlElement("pch")]
		public PollingChannel PollingChannel { get; set; }

		[JsonProperty("csr")]
		[XmlElement("csr")]
		public RemoteCSE RemoteCSE { get; set; }

		[JsonProperty("req")]
		[XmlElement("req")]
		public Request Request { get; set; }

		[JsonProperty("sch")]
		[XmlElement("sch")]
		public Schedule Schedule { get; set; }

		[JsonProperty("asar")]
		[XmlElement("asar")]
		public ServiceSubscribedAppRule ServiceSubscribedAppRule { get; set; }

		[JsonProperty("svsn")]
		[XmlElement("svsn")]
		public ServiceSubscribedNode ServiceSubscribedNode { get; set; }

		[JsonProperty("stcl")]
		[XmlElement("stcl")]
		public StatsCollect StatsCollect { get; set; }

		[JsonProperty("stcg")]
		[XmlElement("stcg")]
		public StatsConfig StatsConfig { get; set; }

		[JsonProperty("sub")]
		[XmlElement("sub")]
		public Subscription Subscription { get; set; }

		[JsonProperty("smd")]
		[XmlElement("smd")]
		public SemanticDescriptor SemanticDescriptor { get; set; }

		[JsonProperty("ntpr")]
		[XmlElement("ntpr")]
		public NotificationTargetMgmtPolicyRef NotificationTargetMgmtPolicyRef { get; set; }

		[JsonProperty("ntp")]
		[XmlElement("ntp")]
		public NotificationTargetPolicy NotificationTargetPolicy { get; set; }

		[JsonProperty("pdr")]
		[XmlElement("pdr")]
		public PolicyDeletionRules PolicyDeletionRules { get; set; }

		//[JsonProperty("")]
		//[XmlElement("")]
		//public FlexContainer FlexContainer { get; set; }

		[JsonProperty("ts")]
		[XmlElement("ts")]
		public TimeSeries TimeSeries { get; set; }

		[JsonProperty("tsi")]
		[XmlElement("tsi")]
		public TimeSeriesInstance TimeSeriesInstance { get; set; }

		[JsonProperty("rol")]
		[XmlElement("rol")]
		public Role Role { get; set; }

		[JsonProperty("tk")]
		[XmlElement("tk")]
		public Token Token { get; set; }

		[JsonProperty("trpt")]
		[XmlElement("trpt")]
		public TrafficPattern TrafficPattern { get; set; }

		[JsonProperty("dac")]
		[XmlElement("dac")]
		public DynamicAuthorizationConsultation DynamicAuthorizationConsultation { get; set; }

		[JsonProperty("acpA")]
		[XmlElement("acpA")]
		public AccessControlPolicyAnnc AccessControlPolicyAnnc { get; set; }

		[JsonProperty("aeA")]
		[XmlElement("aeA")]
		public AEAnnc AEAnnc { get; set; }

		[JsonProperty("cntA")]
		[XmlElement("cntA")]
		public ContainerAnnc ContainerAnnc { get; set; }

		[JsonProperty("cinA")]
		[XmlElement("cinA")]
		public ContentInstanceAnnc ContentInstanceAnnc { get; set; }

		[JsonProperty("grpA")]
		[XmlElement("grpA")]
		public GroupAnnc GroupAnnc { get; set; }

		[JsonProperty("lcpA")]
		[XmlElement("lcpA")]
		public LocationPolicyAnnc LocationPolicyAnnc { get; set; }

		//[JsonProperty("")]
		//[XmlElement("")]
		//public MgmtObjAnnc MgmtObjAnnc { get; set; }

		[JsonProperty("nodA")]
		[XmlElement("nodA")]
		public NodeAnnc NodeAnnc { get; set; }

		[JsonProperty("csrA")]
		[XmlElement("csrA")]
		public RemoteCSEAnnc RemoteCSEAnnc { get; set; }

		[JsonProperty("schA")]
		[XmlElement("schA")]
		public ScheduleAnnc ScheduleAnnc { get; set; }

		[JsonProperty("smdA")]
		[XmlElement("smdA")]
		public SemanticDescriptorAnnc SemanticDescriptorAnnc { get; set; }

		//[JsonProperty("")]
		//[XmlElement("")]
		//public FlexContainerAnnc FlexContainerAnnc { get; set; }

		[JsonProperty("tsa")]
		[XmlElement("tsa")]
		public TimeSeriesAnnc TimeSeriesAnnc { get; set; }

		[JsonProperty("tsia")]
		[XmlElement("tsia")]
		public TimeSeriesInstanceAnnc TimeSeriesInstanceAnnc { get; set; }

		[JsonProperty("trptA")]
		[XmlElement("trptA")]
		public TrafficPatternAnnc TrafficPatternAnnc { get; set; }
		//[JsonProperty("")]
		//[XmlElement("")]
		//public DynamicAuthorizationConsultationAnnc DynamicAuthorizationConsultationAnnc { get; set; }
	}


	public partial class Resources
	{
		[JsonProperty("acp")]
		[XmlElement("acp")]
		public ICollection<AccessControlPolicy> AccessControlPolicy { get; set; } = Array.Empty<AccessControlPolicy>();

		[JsonProperty("ae")]
		[XmlElement("ae")]
		public ICollection<AE> AE { get; set; } = Array.Empty<AE>();

		[JsonProperty("cnt")]
		[XmlElement("cnt")]
		public ICollection<Container> Container { get; set; } = Array.Empty<Container>();

		[JsonProperty("cin")]
		[XmlElement("cin")]
		public ICollection<ContentInstance> ContentInstance { get; set; } = Array.Empty<ContentInstance>();

		[JsonProperty("cb")]
		[XmlElement("cb")]
		public ICollection<CSEBase> CSEBase { get; set; } = Array.Empty<CSEBase>();

		[JsonProperty("dlv")]
		[XmlElement("dlv")]
		public ICollection<Delivery> Delivery { get; set; } = Array.Empty<Delivery>();

		[JsonProperty("evcg")]
		[XmlElement("evcg")]
		public ICollection<EventConfig> EventConfig { get; set; } = Array.Empty<EventConfig>();

		[JsonProperty("exin")]
		[XmlElement("exin")]
		public ICollection<ExecInstance> ExecInstance { get; set; } = Array.Empty<ExecInstance>();

		[JsonProperty("grp")]
		[XmlElement("grp")]
		public ICollection<Group> Group { get; set; } = Array.Empty<Group>();

		[JsonProperty("lcp")]
		[XmlElement("lcp")]
		public ICollection<LocationPolicy> LocationPolicy { get; set; } = Array.Empty<LocationPolicy>();

		[JsonProperty("mssp")]
		[XmlElement("mssp")]
		public ICollection<M2MServiceSubscriptionProfile> M2MServiceSubscriptionProfile { get; set; } = Array.Empty<M2MServiceSubscriptionProfile>();

		[JsonProperty("mgc")]
		[XmlElement("mgc")]
		public ICollection<MgmtCmd> MgmtCmd { get; set; } = Array.Empty<MgmtCmd>();

		//[JsonProperty("")]
		//[XmlElement("")]
		//public ICollection<MgmtObj> MgmtObj { get; set; } = Array.Empty<MgmtObj>();

		[JsonProperty("nod")]
		[XmlElement("nod")]
		public ICollection<Node> Node { get; set; } = Array.Empty<Node>();

		[JsonProperty("pch")]
		[XmlElement("pch")]
		public ICollection<PollingChannel> PollingChannel { get; set; } = Array.Empty<PollingChannel>();

		[JsonProperty("csr")]
		[XmlElement("csr")]
		public ICollection<RemoteCSE> RemoteCSE { get; set; } = Array.Empty<RemoteCSE>();

		[JsonProperty("req")]
		[XmlElement("req")]
		public ICollection<Request> Request { get; set; } = Array.Empty<Request>();

		[JsonProperty("sch")]
		[XmlElement("sch")]
		public ICollection<Schedule> Schedule { get; set; } = Array.Empty<Schedule>();

		[JsonProperty("asar")]
		[XmlElement("asar")]
		public ICollection<ServiceSubscribedAppRule> ServiceSubscribedAppRule { get; set; } = Array.Empty<ServiceSubscribedAppRule>();

		[JsonProperty("svsn")]
		[XmlElement("svsn")]
		public ICollection<ServiceSubscribedNode> ServiceSubscribedNode { get; set; } = Array.Empty<ServiceSubscribedNode>();

		[JsonProperty("stcl")]
		[XmlElement("stcl")]
		public ICollection<StatsCollect> StatsCollect { get; set; } = Array.Empty<StatsCollect>();

		[JsonProperty("stcg")]
		[XmlElement("stcg")]
		public ICollection<StatsConfig> StatsConfig { get; set; } = Array.Empty<StatsConfig>();

		[JsonProperty("sub")]
		[XmlElement("sub")]
		public ICollection<Subscription> Subscription { get; set; } = Array.Empty<Subscription>();

		[JsonProperty("smd")]
		[XmlElement("smd")]
		public ICollection<SemanticDescriptor> SemanticDescriptor { get; set; } = Array.Empty<SemanticDescriptor>();

		[JsonProperty("ntpr")]
		[XmlElement("ntpr")]
		public ICollection<NotificationTargetMgmtPolicyRef> NotificationTargetMgmtPolicyRef { get; set; } = Array.Empty<NotificationTargetMgmtPolicyRef>();

		[JsonProperty("ntp")]
		[XmlElement("ntp")]
		public ICollection<NotificationTargetPolicy> NotificationTargetPolicy { get; set; } = Array.Empty<NotificationTargetPolicy>();

		[JsonProperty("pdr")]
		[XmlElement("pdr")]
		public ICollection<PolicyDeletionRules> PolicyDeletionRules { get; set; } = Array.Empty<PolicyDeletionRules>();

		//[JsonProperty("")]
		//[XmlElement("")]
		//public ICollection<FlexContainer> FlexContainer { get; set; } = Array.Empty<FlexContainer>();

		[JsonProperty("ts")]
		[XmlElement("ts")]
		public ICollection<TimeSeries> TimeSeries { get; set; } = Array.Empty<TimeSeries>();

		[JsonProperty("tsi")]
		[XmlElement("tsi")]
		public ICollection<TimeSeriesInstance> TimeSeriesInstance { get; set; } = Array.Empty<TimeSeriesInstance>();

		[JsonProperty("rol")]
		[XmlElement("rol")]
		public ICollection<Role> Role { get; set; } = Array.Empty<Role>();

		[JsonProperty("tk")]
		[XmlElement("tk")]
		public ICollection<Token> Token { get; set; } = Array.Empty<Token>();

		[JsonProperty("trpt")]
		[XmlElement("trpt")]
		public ICollection<TrafficPattern> TrafficPattern { get; set; } = Array.Empty<TrafficPattern>();

		[JsonProperty("dac")]
		[XmlElement("dac")]
		public ICollection<DynamicAuthorizationConsultation> DynamicAuthorizationConsultation { get; set; } = Array.Empty<DynamicAuthorizationConsultation>();

		[JsonProperty("acpA")]
		[XmlElement("acpA")]
		public ICollection<AccessControlPolicyAnnc> AccessControlPolicyAnnc { get; set; } = Array.Empty<AccessControlPolicyAnnc>();

		[JsonProperty("aeA")]
		[XmlElement("aeA")]
		public ICollection<AEAnnc> AEAnnc { get; set; } = Array.Empty<AEAnnc>();

		[JsonProperty("cntA")]
		[XmlElement("cntA")]
		public ICollection<ContainerAnnc> ContainerAnnc { get; set; } = Array.Empty<ContainerAnnc>();

		[JsonProperty("cinA")]
		[XmlElement("cinA")]
		public ICollection<ContentInstanceAnnc> ContentInstanceAnnc { get; set; } = Array.Empty<ContentInstanceAnnc>();

		[JsonProperty("grpA")]
		[XmlElement("grpA")]
		public ICollection<GroupAnnc> GroupAnnc { get; set; } = Array.Empty<GroupAnnc>();

		[JsonProperty("lcpA")]
		[XmlElement("lcpA")]
		public ICollection<LocationPolicyAnnc> LocationPolicyAnnc { get; set; } = Array.Empty<LocationPolicyAnnc>();

		//[JsonProperty("")]
		//[XmlElement("")]
		//public ICollection<MgmtObjAnnc> MgmtObjAnnc { get; set; } = Array.Empty<MgmtObjAnnc>();

		[JsonProperty("nodA")]
		[XmlElement("nodA")]
		public ICollection<NodeAnnc> NodeAnnc { get; set; } = Array.Empty<NodeAnnc>();

		[JsonProperty("csrA")]
		[XmlElement("csrA")]
		public ICollection<RemoteCSEAnnc> RemoteCSEAnnc { get; set; } = Array.Empty<RemoteCSEAnnc>();

		[JsonProperty("schA")]
		[XmlElement("schA")]
		public ICollection<ScheduleAnnc> ScheduleAnnc { get; set; } = Array.Empty<ScheduleAnnc>();

		[JsonProperty("smdA")]
		[XmlElement("smdA")]
		public ICollection<SemanticDescriptorAnnc> SemanticDescriptorAnnc { get; set; } = Array.Empty<SemanticDescriptorAnnc>();

		//[JsonProperty("")]
		//[XmlElement("")]
		//public ICollection<FlexContainerAnnc> FlexContainerAnnc { get; set; } = Array.Empty<FlexContainerAnnc>();

		[JsonProperty("tsa")]
		[XmlElement("tsa")]
		public ICollection<TimeSeriesAnnc> TimeSeriesAnnc { get; set; } = Array.Empty<TimeSeriesAnnc>();

		[JsonProperty("tsia")]
		[XmlElement("tsia")]
		public ICollection<TimeSeriesInstanceAnnc> TimeSeriesInstanceAnnc { get; set; } = Array.Empty<TimeSeriesInstanceAnnc>();

		[JsonProperty("trptA")]
		[XmlElement("trptA")]
		public ICollection<TrafficPatternAnnc> TrafficPatternAnnc { get; set; } = Array.Empty<TrafficPatternAnnc>();
		//[JsonProperty("")]
		//[XmlElement("")]
		//public ICollection<DynamicAuthorizationConsultationAnnc> DynamicAuthorizationConsultationAnnc { get; set; } = Array.Empty<DynamicAuthorizationConsultationAnnc>();
	}
	public partial class ResponseContent
	{
		[JsonIgnore]
		[XmlIgnore]
		public ResponseStatusCode ResponseStatusCode { get; set; }
	}

	public class NotificationContent
	{
		[JsonProperty("sgn")]
		[XmlElement("sgn")]
		public Notification Notification { get; set; }
	}

	public partial class NotificationNotificationEvent
	{
		[JsonIgnore]
		[XmlIgnore]
		public RequestPrimitive PrimitiveRepresentation { get; set; }
	}





	public class SingleOrArrayConverter<T> : JsonConverter
	{
		public override bool CanConvert(Type objectType) => typeof(List<T>) == objectType;
		public override bool CanWrite => true;

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			var token = JToken.Load(reader);
			if (token.Type == JTokenType.Array)
				return token.ToObject<List<T>>();
			return new List<T> { token.ToObject<T>() };
		}

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			var list = (List<T>) value;
			if (list.Count == 1)
				value = list[0];
			serializer.Serialize(writer, value);
		}
	}

	public class JsonArrayItem<T> : JsonConverter
	{
		string _itemName;
		public JsonArrayItem(string itemName)
		{
			_itemName = itemName;
		}

		public override bool CanWrite => true;
		public override bool CanConvert(Type objectType) => true;

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			var token = JToken.Load(reader);
			if (token.Type != JTokenType.Object)
				return null;    // throw
			var obj = (JObject) token;
			if (obj.Count != 1)
				return null;    // throw
			var items = obj[_itemName];
			return items.Select(ch => ch.ToObject<T>()).ToList();
		}

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			var list = (List<T>) value;
			writer.WriteStartObject();
			writer.WritePropertyName(_itemName);
			serializer.Serialize(writer, value);
			writer.WriteEndObject();
		}
	}
}