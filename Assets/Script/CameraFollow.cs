using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    public float xoffset = 1f;

    void Start()
    {

    }

    void Update()
    {
        transform.position = new Vector3(player.transform.position.x + xoffset, this.transform.position.y, this.transform.position.z);
        if(this.transform.position.x < 0)
        {
            transform.position = new Vector3(0, this.transform.position.y, this.transform.position.z);
        }
    }
}
