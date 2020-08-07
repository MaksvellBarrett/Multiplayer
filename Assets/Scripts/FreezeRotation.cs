using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeRotation : MonoBehaviour
{
	public Transform HeadPosition;
	public Vector3 BodyPosition;

	void Update()
	{
		transform.position = HeadPosition.position + BodyPosition;
	}
}
