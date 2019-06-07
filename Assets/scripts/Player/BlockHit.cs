using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockHit : MonoBehaviour
{
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "block" && col.gameObject.transform.parent.GetComponent<Total>().coins > 0)
        {
            Instantiate(Resources.Load("prefabs/Coin"), new Vector3(col.transform.position.x, col.transform.position.y + 1, col.transform.position.z), Quaternion.identity, col.transform);
            col.gameObject.transform.parent.GetComponent<Total>().coins--;
        }
            
        
        
    }
}
