using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Obstacle : MonoBehaviour
{
	public float velocity = 4f;
	public float range = 4;

    private float timer = 0;

	// Use this for initialization
	void Start()
	{
		transform.position = new Vector3(transform.position.x, transform.position.y - range * Random.value, transform.position.z);
	}

    private void Update()
    {
        timer += Time.deltaTime;
        transform.Translate(new Vector3(velocity, 0, 0), Space.Self);

        if (timer > 5f)
        {
            Destroy(gameObject);
        }
    }
}