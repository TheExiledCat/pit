using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat : MonoBehaviour
{
    
    public GameObject c;
    
    public GameObject playerSpawn;
    public GameObject enemySpawn;
    void Start()
    {
       
    }
    public void StartBattle()
    {
        
        Instantiate(Resources.Load<GameObject>("prefabs/PlayerCombat"), playerSpawn.transform.position, Quaternion.identity,playerSpawn.transform);
        var enemy=Instantiate(Resources.Load<GameObject>("prefabs/shrooblet combat"), enemySpawn.transform.position, transform.rotation);
        enemy.transform.rotation = new Quaternion(0, 180, 0, enemy.transform.rotation.w);
        c.SetActive(true);
        Camera.main.gameObject.SetActive(false);
    }
}
