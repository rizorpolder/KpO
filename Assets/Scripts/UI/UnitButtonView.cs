using System;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace UI
{
	public class UnitButtonView : MonoBehaviour
	{
		public System.Action OnButtonClickEvent = () => {};

		[SerializeField] private Button _selectButton;
		[SerializeField] private TextMeshProUGUI _text;
		[SerializeField] private Image _icon;
		[SerializeField] private GameObject _underline;

		private bool _isSelected = false;

		private void Start()
		{
			_selectButton.onClick.AddListener(OnButtonClickHandler);
		}

		public void OnButtonClickHandler()
		{
			SetSelectedState();
			OnButtonClickEvent?.Invoke();
		}

		private void SetSelectedState()
		{

		}
	}
}
