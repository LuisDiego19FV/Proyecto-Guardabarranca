using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Obstacle : MonoBehaviour
{
	public float velocity = 4f;
	public float range = 4.5f;

    private float timer = 0;
    private bool locker = false;

	// Use this for initialization
	void Start()
	{
        velocity += PlayerPrefs.GetInt("MiniGame1", 0) / 120f;
        transform.position = new Vector3(transform.position.x, transform.position.y - range * Random.value, transform.position.z);
    }

    private void Update()
    {
        timer += Time.deltaTime;
        transform.Translate(new Vector3(velocity, 0, 0), Space.Self);

        if (timer > 2.5f && !locker)
        {
            PlayerPrefs.SetInt("MiniGame1", PlayerPrefs.GetInt("MiniGame1", 0) + 1);
            locker = true;
            Destroy(gameObject);
        }
    }
}