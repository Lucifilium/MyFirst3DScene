using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject player;

    //Position of camera
    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        //Where the player move the camera in the scene
        offset = transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
