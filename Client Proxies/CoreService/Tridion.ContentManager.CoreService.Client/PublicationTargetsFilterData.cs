using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "PublicationTargetsFilterData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class PublicationTargetsFilterData : SystemWideListFilterData
	{
		private bool? IncludeEmulatedField;

		[DataMember(EmitDefaultValue = false)]
		public bool? IncludeEmulated
		{
			get
			{
				return this.IncludeEmulatedField;
			}
			set
			{
				this.IncludeEmulatedField = value;
			}
		}
	}
}