using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instrucciones : MonoBehaviour
{
    public GameObject canvas1;
    public GameObject canvas2;

    private float counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        canvas1.SetActive(false);
        canvas2.SetActive(false);
    }

    public void buttonSetInactive()
    {
        gameObject.SetActive(false);
        canvas1.SetActive(true);
        canvas2.SetActive(true);
    }

    private void Update()
    {
        counter += Time.deltaTime;

        if (counter > 12f)
        {
            buttonSetInactive();
        }
    }
}
