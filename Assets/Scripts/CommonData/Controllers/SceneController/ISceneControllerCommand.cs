namespace CommonData.Controllers.SceneController
{
	public interface ISceneControllerCommand
	{
		public void Load();
		public void LoadAsync();
		public void Unload();
		public void UnloadAsync();

	}
}