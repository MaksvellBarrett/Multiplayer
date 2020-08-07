using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotonSendStreamManager : MonoBehaviour, IPunObservable
{
    public OVRCameraRig OVRMainCamera;

	public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
	{
		if (stream.IsWriting)
		{
			stream.SendNext(OVRMainCamera.rightControllerAnchor.localPosition);
			stream.SendNext(OVRMainCamera.rightControllerAnchor.localRotation);
			stream.SendNext(OVRMainCamera.leftControllerAnchor.localPosition);
			stream.SendNext(OVRMainCamera.leftControllerAnchor.localRotation);
			stream.SendNext(OVRMainCamera.centerEyeAnchor.localPosition);
			stream.SendNext(OVRMainCamera.centerEyeAnchor.localRotation);
		}
		else
		{
			OVRMainCamera.rightControllerAnchor.localPosition = (Vector3)stream.ReceiveNext();
			OVRMainCamera.rightControllerAnchor.localRotation = (Quaternion)stream.ReceiveNext();
			OVRMainCamera.leftControllerAnchor.localPosition = (Vector3)stream.ReceiveNext();
			OVRMainCamera.leftControllerAnchor.localRotation = (Quaternion)stream.ReceiveNext();
			OVRMainCamera.centerEyeAnchor.localPosition = (Vector3)stream.ReceiveNext();
			OVRMainCamera.centerEyeAnchor.localRotation = (Quaternion)stream.ReceiveNext();
		}
	}
}
