using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySelf : MonoBehaviour
{
    GameObject player;
    int timer = -1;
    void Start()
    {
        player = GameObject.Find("Player");
        timer = 30;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0)
        {
            timer--;
        }
        if (timer == 0)
        {
            player.GetComponent<MyScore>().coins++;
            Destroy(gameObject);
        }
    }
}
