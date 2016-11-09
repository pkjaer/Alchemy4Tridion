using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class PreviewItemCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public RenderedItemData Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (RenderedItemData)this.results[0];
			}
		}

		public PreviewItemCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}
