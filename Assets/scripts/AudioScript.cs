using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    public AudioClip effectssource;

    public AudioSource musicsource;


    // Start is called before the first frame update
    void Start()
    {
        musicsource.clip = effectssource;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&&GetComponent<PlayerMovement>().bIsGrounded)
            musicsource.Play();
    }
}
