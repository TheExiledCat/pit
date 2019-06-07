using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ShowText : MonoBehaviour
{
    TextMeshProUGUI text;
    TextMeshProUGUI text1;
    void Start()
    {
        text = transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();
        text1 = transform.GetChild(1).gameObject.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Coins: " + GameObject.Find("Player").GetComponent<MyScore>().coins.ToString("000");
        text1.text = "Score: " + GameObject.Find("Player").GetComponent<MyScore>().score.ToString("000000");
    }
}
