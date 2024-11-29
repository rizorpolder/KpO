using Common.Enums;
using UnityEngine;
using UnityEngine.Serialization;

namespace Common.Unit
{
	public abstract class Unit : MonoBehaviour
	{
		[FormerlySerializedAs("_unitType")] [SerializeField] protected TUnit unit;
		[SerializeField] protected int _health;

		public abstract void Attack();
		public abstract void GetDamage(int value);
	}
}