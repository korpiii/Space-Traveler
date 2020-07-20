using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
	public GameObject[] cannons;
	string input;
	public Rigidbody2D laser;
	public GameObject soundManager;

	void Start()
	{

	}
	// Update is called once per frame
	void Update()
	{

		input = Input.inputString;

		if (!string.IsNullOrEmpty(input))
		{
			
			switch (input)
			{
				case "i":
					Instantiate(laser, cannons[0].transform.position, Quaternion.Euler(new Vector3(0, 0, 90)));
					soundManager.GetComponent<AudioManager>().Shooting();
					break;
				case "l":
					Instantiate(laser, cannons[1].transform.position, Quaternion.Euler(new Vector3(0, 0, 0)));
					soundManager.GetComponent<AudioManager>().Shooting();
					break;
				case "k":
					Instantiate(laser, cannons[2].transform.position, Quaternion.Euler(new Vector3(0, 0, -90)));
					soundManager.GetComponent<AudioManager>().Shooting();
					break;
				case "j":
					Instantiate(laser, cannons[3].transform.position, Quaternion.Euler(new Vector3(0, 0, -180)));
					soundManager.GetComponent<AudioManager>().Shooting();
					break;
				default:
					break;
			}
		}
	}
}




