using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LobbyManager : Photon.Pun.MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    public Text LogText;
	
	private void Start()
    {
        PhotonNetwork.NickName = "Player " + Random.Range(1000,9999);
		Log("Player's nick is set to " + PhotonNetwork.NickName);
		
		PhotonNetwork.AutomaticallySyncScene = true;
		PhotonNetwork.GameVersion = "0.0.0";
		PhotonNetwork.ConnectUsingSettings();
    }
	
	public override void OnConnectedToMaster()
	{
		Log("Connected to Master");
	}
	
	public void CreateRoom()
	{
		PhotonNetwork.CreateRoom(null, new Photon.Realtime.RoomOptions { MaxPlayers = 3 });
	}
	
	public void JoinRoom()
	{
		PhotonNetwork.JoinRandomRoom();
	}
	
	public override void OnJoinedRoom()
	{
		Log("Joined the Room");
		
		PhotonNetwork.LoadLevel("Game");
	}
	
	private void Log(string message)
	{
		Debug.Log(message);
		LogText.text += "\n";
		LogText.text += message;
	}
	
}
