using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Team_collaboration_1.Shared;

namespace TestTeam_collaboration_1
{
	public class TestMainLayout
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbDropdownModule),
				typeof(IgbDropdownItemModule),
				typeof(IgbDropdownHeaderModule),
				typeof(IgbIconButtonModule),
				typeof(IgbAvatarModule),
				typeof(IgbNavDrawerModule),
				typeof(IgbInputModule),
				typeof(IgbBadgeModule));
			var componentUnderTest = ctx.RenderComponent<MainLayout>();
			Assert.NotNull(componentUnderTest);
		}
	}
}