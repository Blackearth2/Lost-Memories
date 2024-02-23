using UnityEngine;
using System.Collections;
        
public class camerafollow : MonoBehaviour
{
[SerializeField] private GameObject Player;

private void Start()
{
    
}

private void Update()
{
    transform.position = new Vector3(Player.transform.position.x, 30.0f,Player.transform.position.z - 5f);
}
}
