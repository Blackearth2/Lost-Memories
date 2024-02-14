
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
public class NetworkManager : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        Connect();
    }
    public void Connect()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    public void Multijoueur() => PhotonNetwork.JoinRandomRoom();

    public override  void OnJoinRandomFailed(short returnCode, string message)
    {
        Debug.Log("Tried to join a room and failed");
        PhotonNetwork.CreateRoom(null, new RoomOptions { MaxPlayers = 4});
    }


    public override void OnJoinedRoom()
    {
        Debug.Log("joined a rom");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
