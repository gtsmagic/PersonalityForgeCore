using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace JamesWright.PersonalityForgeCore.Models
{
	[DataContract]
	internal class User
	{
		[DataMember(Name="externalID")]
		public string ExternalID;
	}
}

