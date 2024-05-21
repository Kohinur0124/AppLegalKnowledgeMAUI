using Android.App;
using Android.Runtime;

namespace AppLegalKnowledge
{
	[Application]
	public class MainApplication : MauiApplication
	{
		public MainApplication(IntPtr handle, JniHandleOwnership ownership)
			: base(handle, ownership)
		{
			Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping(nameof(Entry), (handler, view) =>
			{
				if (view is Entry)
				{
					// Remove underline
					handler.PlatformView.SetBackgroundColor(Android.Graphics.Color.Transparent);


				}
			});
		}

		protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
	}
}
