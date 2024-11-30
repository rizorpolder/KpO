using System;

namespace Common.Controllers.SceneController
{
	public class SceneController : ISceneControllerData, ISceneControllerCommand, ISceneControllerListener
	{
		public event Action OnSceneLoaded;
		public event Action OnSceneUnloaded;

		public SceneController()
		{
			
		}
		
		public void Load()
		{
		}

		public void LoadAsync()
		{
		}

		public void Unload()
		{
		}

		public void UnloadAsync()
		{
		}
	}
}