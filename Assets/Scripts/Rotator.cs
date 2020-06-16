using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public Vector3 EulersPerSecond;

	void Update()
	{
		transform.Rotate(EulersPerSecond * Time.deltaTime);
    }
}
