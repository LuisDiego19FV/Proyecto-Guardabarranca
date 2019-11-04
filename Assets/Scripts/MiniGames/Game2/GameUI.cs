using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameUI : MonoBehaviour
{
    private TextMeshProUGUI points;
    private int counter = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        points = transform.GetChild(0).GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (counter != PlayerPrefs.GetInt("MiniGame1", 0))
        {
            counter++;
            points.text = counter.ToString();
        }
    }
}
