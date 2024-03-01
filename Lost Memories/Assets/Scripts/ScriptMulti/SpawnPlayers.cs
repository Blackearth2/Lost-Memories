using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayers : MonoBehaviour
{
    public GameObject PlayerPrefab;
    
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    private void Start()
    {
        //Vector3 randomPosition = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), -1);
        Vector3 randomPosition = new Vector3(10, 1, 10);
        Vector3 randomPosition2 = new Vector3(15, 1, 10);
        PhotonNetwork.Instantiate(PlayerPrefab.name, randomPosition, Quaternion.identity);
    }
}
