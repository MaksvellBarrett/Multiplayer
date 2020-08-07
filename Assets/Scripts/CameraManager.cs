using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
	public GameObject Head;
	public OVRCameraRig MainCamera;
	public Camera CenterEye;
	private PhotonView MyPhotonView;

	private void Start()
	{
		MyPhotonView = GetComponent<PhotonView>();
	}

	void Update()
	{
		if (MyPhotonView.IsMine)
		{
			TurnOffHeadAndOnCamera();
		}
	}

	private void TurnOffHeadAndOnCamera()
	{
		Head.SetActive(false);
		MainCamera.disableEyeAnchorCameras = false;
		CenterEye.enabled = true;
	}
}
