using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Total : MonoBehaviour
{
    public int coins;
    private void Start()
    {
        coins = Random.Range(1, 10);
    }
    private void Update()
    {
        if (coins == 0)
        {
            gameObject.GetComponent<MeshRenderer>().material.color = new Color32(139, 69, 19,0);
        }
    }
}
