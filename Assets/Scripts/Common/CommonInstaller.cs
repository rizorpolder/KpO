using Common.Controllers.SaveController;
using Common.Controllers.SceneController;
using Zenject;

namespace Common
{
	public class CommonInstaller : MonoInstaller
	{
		public override void InstallBindings()
		{
			Container.BindInterfacesAndSelfTo<SaveController>().AsSingle();
			Container.BindInterfacesAndSelfTo<SceneController>().AsSingle();
		}
	}
}