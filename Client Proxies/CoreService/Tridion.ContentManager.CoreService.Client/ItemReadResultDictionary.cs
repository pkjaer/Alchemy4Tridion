using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, CollectionDataContract(Name = "ItemReadResultDictionary", Namespace = "http://www.sdltridion.com/ContentManager/R6", ItemName = "Item", KeyName = "Id", ValueName = "ItemReadResult")]
	public class ItemReadResultDictionary : Dictionary<string, ItemReadResult>
	{
	}
}