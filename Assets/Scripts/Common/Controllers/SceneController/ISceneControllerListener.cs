using System;

namespace Common.Controllers.SceneController
{
	public interface ISceneControllerListener
	{
		event Action OnSceneLoaded;
		event Action OnSceneUnloaded;
	}
}