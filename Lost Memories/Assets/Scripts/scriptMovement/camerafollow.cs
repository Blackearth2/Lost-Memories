using UnityEngine;
using System.Collections;
using Mirror;
using UnityEngine.SceneManagement;
public class CameraMovement : NetworkBehaviour
{
    public Vector3 offset;
    public GameObject cameraHolder;

    public override void OnStartAuthority()
    {
        cameraHolder.SetActive(true);
    }


    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "Game")
        {
            cameraHolder.transform.position = transform.position + offset;
            cameraHolder.transform.rotation = Quaternion.Euler(new Vector3(35, 0, 0));
        }
    }
}
