using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform player;
    public float speed = 4.0f;
    public float yoff;
    public float xoff;
    Vector3 offset;
    void Start()
    {
        offset = new Vector3(player.position.x, player.position.y * yoff, player.position.z * xoff);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        
        offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") *speed, Vector3.up) * offset;
        transform.position = player.position + offset;
        
        transform.LookAt(player.position);
        
    }
}
