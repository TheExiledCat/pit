using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        source.PlayOneShot(Resources.Load<AudioClip>("music/Near"));
    }
    

    // Update is called once per frame
    void Update()
    {
           
    }
}
