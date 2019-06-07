using UnityEngine;

public class MoveToPlayer : MonoBehaviour
{
    float ms =2;
    GameObject player;
    bool bFollow = false;
    void Start()
    {
        
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (bFollow)
        {
        transform.LookAt(player.transform);
                transform.rotation = new Quaternion(0, transform.rotation.y, 0, transform.rotation.w);
        }
        if (Vector3.Distance(gameObject.transform.position, player.transform.position)<=7)
        {
            bFollow = true;
        }
        
    }
    private void FixedUpdate()
    {
        if (bFollow) 
        transform.position += transform.forward * ms*Time.deltaTime;
    }
    
}
