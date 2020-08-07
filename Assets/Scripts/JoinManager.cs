using Photon.Pun;
using Photon.Pun.Demo.Cockpit;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JoinManager : MonoBehaviourPunCallbacks
{
	public InputField MenuInputField;
	public Text TextFieldForFails;
	public GameObject Keyboard;

	private bool IsCreateRoom;

	void Start()
	{
		StartBaseProperty();
	}

	private void StartBaseProperty() 
	{
		PhotonNetwork.NickName = "Player" + Random.Range(100, 999);
		PhotonNetwork.AutomaticallySyncScene = true;
		PhotonNetwork.GameVersion = "1";
		PhotonNetwork.ConnectUsingSettings();
	}

	public void CreateRoom()
	{
		Keyboard.SetActive(true);
		IsCreateRoom = true;
	}

	public void Enter()
	{
		if (IsCreateRoom)
		{
			PhotonNetwork.CreateRoom(MenuInputField.text, new Photon.Realtime.RoomOptions { MaxPlayers = 2 });
		}
		else
		{
			PhotonNetwork.JoinRoom(MenuInputField.text);
		}
	}

	public override void OnConnectedToMaster()
	{
		AddMessage("Conected to Master");
	}

	public override void OnCreatedRoom()
	{
		AddMessage("CreateRoom");
	}

	public override void OnCreateRoomFailed(short returnCode, string message)
	{
		AddMessage(message);
	}

	public void LoadRoom()
	{
		IsCreateRoom = false;
		Keyboard.SetActive(true);
	}

	public override void OnJoinedLobby()
	{
		AddMessage("JoinRoom");
	}

	public void JoinRandom()
	{
		PhotonNetwork.JoinRandomRoom();
	}

	public override void OnJoinRandomFailed(short returnCode, string message)
	{
		AddMessage(message);
	}

	public override void OnJoinedRoom()
	{
		PhotonNetwork.LoadLevel("Game");
	}

	public override void OnJoinRoomFailed(short returnCode, string message)
	{
		AddMessage(message);
	}

	private void AddMessage(string message)
	{
		TextFieldForFails.text += message;
		TextFieldForFails.text += "\n\r";
	}
}
