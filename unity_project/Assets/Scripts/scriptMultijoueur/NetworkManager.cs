
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
public class NetworkManager : MonoBehaviourPunCallbacks
{
    public bool isWaitingForCallbacks = false;
    // Start is called before the first frame update
    void Start()
    {
        Connect();
    }
    public void Connect()
    {
        PhotonNetwork.Disconnect(); // Disconnect before attempting to connect again
        PhotonNetwork.ConnectUsingSettings();
        isWaitingForCallbacks = true;
    }

    public void Multijoueur()
    {
        Debug.Log("button Clicked, trying to join a random room");
        PhotonNetwork.JoinRandomRoom();
        
        
    }

    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        Debug.Log("Tried to join a room and failed");
        string roomName = "Room" + Random.Range(1000, 10000); // Generate a unique room name
        PhotonNetwork.CreateRoom(roomName, new RoomOptions { MaxPlayers = 4 });
    }


    void Update()
    {
    
    }
}
