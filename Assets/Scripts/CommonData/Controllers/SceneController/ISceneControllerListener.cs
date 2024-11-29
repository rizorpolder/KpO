using System;

namespace CommonData.Controllers.SceneController
{
	public interface ISceneControllerListener
	{
		event Action OnSceneLoaded;
		event Action OnSceneUnloaded;
	}
}