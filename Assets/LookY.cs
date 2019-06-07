using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookY : MonoBehaviour
{
    float lookS = 5;
    private void Update()
    {
        var rotY = transform.rotation;

        transform.Rotate(lookS * -Input.GetAxis("Mouse Y") * Time.deltaTime, 0, 0);

        rotY.x = Mathf.Clamp(rotY.x, -80, 80f);

        //cam.transform.rotation = new Quaternion(-rotY.x,0 , 0,cam.transform.rotation.w);

        //transform.Rotate(0, lookX * lookS * Time.deltaTime, 0);
    }
}
