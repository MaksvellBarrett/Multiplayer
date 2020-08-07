﻿using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomGameManager : MonoBehaviour
{
	public GameObject PlayerPrefab;

	private void Start()
	{
		CreateNewPlayer();
	}
	
	private void CreateNewPlayer() 
	{
		Vector3 NewPos = new Vector3(Random.Range(-3, 3), 2, Random.Range(-3, 3));
		PhotonNetwork.Instantiate(PlayerPrefab.name, NewPos, Quaternion.identity);
	}
}