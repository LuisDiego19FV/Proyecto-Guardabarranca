using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
	// The force which is added when the player jumps
	// This can be changed in the Inspector window
	public Vector3 jumpForce = new Vector3(0, 300, 0);
    public GameObject panel;
    public float maximo;

    private void Start()
    {
        PlayerPrefs.SetInt("MiniGame1", 0);
    }

    // Update is called once per frame
    void Update()
	{
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);

		// Jump
		if (Input.GetKeyUp("space"))
		{
            if (screenPosition.y <= Screen.height-1000)
            {
              jump();  
            }
            
		}

		// Die by being off screen
		
		if (screenPosition.y > Screen.height || screenPosition.y < 0)
		{
			Die();
		}
	}

    public void jump()
    {
        GetComponent<Rigidbody>().velocity = Vector3.zero;
        GetComponent<Rigidbody>().AddForce(jumpForce);
    }

	// Die by collision
	void OnCollisionEnter(Collision other)
	{
        gameObject.SetActive(false);
        panel.SetActive(true);
        Time.timeScale = 0;
	}

	public void Die()
	{
        Time.timeScale = 1;
        Application.LoadLevel(Application.loadedLevel);
	}

    public void toMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    private void OnTriggerEnter(Collider other)
    {
        Die();
    }
}