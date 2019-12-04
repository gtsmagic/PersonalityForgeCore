using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using PersonalityForgeCore.Models;

namespace PersonalityForge.Models
{
	[DataContract]
	internal class Payload
	{
		[DataMember(Name="message")]
		internal Message Message { get; set; }

		[DataMember(Name="user")]
		internal User User { get; set; }
	}
}

