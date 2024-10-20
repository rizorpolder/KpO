using System;
using UnityEngine;

namespace UI
{
	public class SceneUnitsSelectView : MonoBehaviour
	{
		[SerializeField] private UnitButtonView[] buttons;

		private void Start()
		{
			foreach (var unitButtonView in buttons)
			{
				unitButtonView.OnButtonClickEvent+= OnButtonClickEvent;
			}
		}

		private void OnButtonClickEvent()
		{
			foreach (var buttonView in buttons)
			{
				buttonView.SetSelectedState(false);
			}
		}
	}
}
