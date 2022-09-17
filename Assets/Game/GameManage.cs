using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManage : Photon.Pun.MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	public void Leave()
	{
		PhotonNetwork.LeaveRoom();
	}
	
	public override void OnLeftRoom()
	{
		//when realtime player leave the room
		SceneManager.LoadScene("Menu");
	}
	public override void OnPlayerEnteredRoom(Player newPlayer)
	{
		Debug.LogFormat("Player {0} entered room", newPlayer.NickName);
	}
	public override void OnPlayerLeftRoom(Player otherPlayer)
	{
		Debug.LogFormat("Player {0} left room", otherPlayer.NickName);
	}
	
}
