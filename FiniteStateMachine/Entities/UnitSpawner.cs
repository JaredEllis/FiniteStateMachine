using UnityEngine;
using FiniteStateMachine.Entities;

namespace FiniteStateMachine.Entities
{
	public class UnitSpawner : MonoBehaviour
	{
		public Unit Spawn(Unit unitPrefab, Transform location)
		{
			Unit newUnit = Instantiate(unitPrefab, location.position, location.rotation);
			return newUnit;
		}
	}
}