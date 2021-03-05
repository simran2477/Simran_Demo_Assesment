using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{


	public Transform[] spawnPoints;
	public GameObject[] monsters;
	int randomSpawnPoint, randomMonster;
	public static bool SpawnAllowed;

	// Use this for initialization
	void Start()
	{
		SpawnAllowed = true;
		InvokeRepeating("SpawnAMonster", 0f, 1f);
	}

	void SpawnAMonster()
	{
		if (SpawnAllowed)
		{
			randomSpawnPoint = Random.Range(0, spawnPoints.Length);
			randomMonster = Random.Range(0, monsters.Length);
			Instantiate(monsters[randomMonster], spawnPoints[randomSpawnPoint].position,
				Quaternion.identity);
		}
	}


}