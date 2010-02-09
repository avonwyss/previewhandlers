namespace FuelAdvance.PreviewHandlerPack.PreviewHandlers
{
	using System;
	using System.IO;

	public abstract class StreamBasedPreviewHandlerControl : PreviewHandlerControl
	{
		public sealed override void Load(FileInfo file)
		{
			using (FileStream fs = new FileStream(file.FullName, FileMode.Open, FileAccess.Read, FileShare.Delete | FileShare.ReadWrite))
			{
				Load(fs);
			}
		}
	}
}