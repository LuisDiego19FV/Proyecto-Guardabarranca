﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate : MonoBehaviour
{
	public GameObject tree;

	// Use this for initialization
	void Start()
	{
		InvokeRepeating("CreateObstacle", 1f, 3.5f);
	}

	void CreateObstacle()
	{
		GameObject go = Instantiate(tree);
        go.SetActive(true);
	}
}