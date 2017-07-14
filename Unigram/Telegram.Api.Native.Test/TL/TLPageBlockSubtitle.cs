// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLPageBlockSubtitle : TLPageBlockBase 
	{
		public TLRichTextBase Text { get; set; }

		public TLPageBlockSubtitle() { }
		public TLPageBlockSubtitle(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.PageBlockSubtitle; } }

		public override void Read(TLBinaryReader from)
		{
			Text = TLFactory.Read<TLRichTextBase>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteObject(Text);
		}
	}
}