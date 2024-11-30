using Common.Enums;
using UnityEngine;

namespace Common.Unit
{
	public abstract class Unit : MonoBehaviour
	{
		[SerializeField] protected TUnit _unitType;
		[SerializeField] protected int _health;

		public abstract void Attack();
		public abstract void GetDamage(int value);
	}
}