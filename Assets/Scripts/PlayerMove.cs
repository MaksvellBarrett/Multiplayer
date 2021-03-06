﻿using Photon.Pun;
using Photon.Pun.Demo.PunBasics;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
	public GameObject Head;
	public OVRCameraRig MainCamera;
	public Camera CenterEye;
	public float RotationAngle = 45.0f;
	public float Speed = 0.1f;

	private PhotonView MyPhotonView;

	private void Start()
	{
		MyPhotonView = GetComponent<PhotonView>();
	}
	void Update()
	{
		if (MyPhotonView.IsMine)
		{
			MovePlayerForwardOrNot();
			MovePlayerBackOrNot();
		}
	}

	private void MovePlayerForwardOrNot() 
	{
		if (OVRInput.Get(OVRInput.Button.SecondaryThumbstickUp))
		{
			transform.position += transform.forward * Speed;
		}
	}

	private void MovePlayerBackOrNot() 
	{
		if (OVRInput.Get(OVRInput.Button.SecondaryThumbstickDown))
		{
			transform.position -= transform.forward * Speed;
		}
	}
}
