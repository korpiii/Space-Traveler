using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObjectSpawner : MonoBehaviour
{
	public GameObject[] listOfObjects;
	public int objectVariety;
	GameObject singleObject;
	public float spawnDistance = 0.05f;

	float objectRate = 5;
	public float nextObject = 1.5f;

	void Start()
	{

	}
	// Update is called once per frame
	void Update()
	{
		nextObject -= Time.deltaTime;

		if (nextObject <= 0)
		{
			singleObject = listOfObjects[Random.Range(0, objectVariety)];
			nextObject = objectRate;
			objectRate *= 0.9f;
			if (objectRate < 2)
				objectRate = 2;

			Vector3 offset = Random.onUnitSphere;

			offset.z = 0;

			offset = offset.normalized * spawnDistance;

			Instantiate(singleObject, transform.position + offset, Quaternion.identity);
		}
	}
}