using Common.Controllers.SceneController;
using UnityEngine;
using Zenject;

public class StartScreenLoader : MonoBehaviour
{
	[Inject] private ISceneControllerCommand _controllerCommand;

	private void Start()
	{
		_controllerCommand?.Load();
	}
}