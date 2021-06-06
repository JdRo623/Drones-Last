using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapHandler : MonoBehaviour
{
	public Vector3 center;
	public Vector3 size;

	public bool ValidatePositionWhitinRange(Vector3 position)
	{
		if (position.x < center.x - size.x * 0.5f || position.x > center.x + size.x * 0.5f)
			return false;

		if (position.z < center.z - size.z * 0.5f || position.z > center.z + size.z * 0.5f)
			return false;

		return true;
	}

	void OnDrawGizmosSelected()
	{
		Gizmos.color = new Color(0, 1, 1, 0.5f);
		Gizmos.DrawCube(center, size);
	}
}
