﻿using System;
using UnityEngine.UI;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

using System.Runtime.InteropServices;

public class hunter : MonoBehaviour {

	public float heading;
	public float x;
	public float y;
	private double delta_t_s; // delta t in seconds

	// Use this for initialization
	void Start () {

		delta_t_s = .05;

	}

	public void Restart()
	{
		transform.position = new Vector3 (-10.0f, 0.0f, 0.0f);
		transform.rotation = Quaternion.AngleAxis (0, Vector3.forward);
		heading = 0;

		x = transform.position.x;
		y = transform.position.y;

	}
		
	// turning in radians
	public void Move(float turning, float distance)
	{

		//set distance to its min and max limits
		if (distance > (1.5*delta_t_s)) 
		{
			distance = (float)(1.5*delta_t_s);
		} else if (distance < 0) 
		{
			distance = 0f;
		}
			
		transform.Rotate(0, 0, (float)(turning*(180/Math.PI)));
		heading += (float)(turning);

		//Vector3 movement = new Vector3 (speed/60 * Mathf.Cos (angle), speed/60 * Mathf.Sin (angle), 0);
		Vector3 movement = transform.right*((float)(distance));
		transform.position = transform.position + movement;

		x = transform.position.x;
		y = transform.position.y;
	}

}
