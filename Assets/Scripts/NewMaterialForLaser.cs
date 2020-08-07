using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMaterialForLaser : MonoBehaviour
{
	public Material MaterialLaserPrefab;

    void Awake()
    {
        GetComponent<LineRenderer>().material = Material.Instantiate(MaterialLaserPrefab);
    }
}
