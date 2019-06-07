using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Buttons : MonoBehaviour
{
    AsyncOperation load;
    public GameObject sp;
    private void Awake()
    {
        
    }
    public void Play()
    {
        gameObject.SetActive(false);
        sp.SetActive(false);
       load = SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);
       
    }
    public void Options()
    {
        Debug.Log("Options not here yet");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
