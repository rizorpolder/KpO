using FirstPhase.Controllers.FieldController;
using FirstPhase.Field;
using Zenject;

namespace FirstPhase
{
	public class FirstPhaseSceneInstaller : MonoInstaller
	{
		public override void InstallBindings()
		{
			//Field
			Container.Bind<IFieldCommand>().To<FieldController>().AsSingle();
			Container.Bind<IFieldData>().To<FieldController>().AsSingle();
			Container.Bind<IFieldListener>().To<FieldController>().AsSingle();
		}
	}
}