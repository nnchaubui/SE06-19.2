using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
	public static SpawnManager Instance;

	SpawnPoint[] spawnpoints;

	void Awake()
	{
		Instance = this;
		spawnpoints = GetComponentsInChildren<SpawnPoint>();
	}

	public Transform GetSpawnpoint()
	{
		Debug.Log("Number of spawn points: " + spawnpoints.Length);
		return spawnpoints[Random.Range(0, spawnpoints.Length)].transform;
	}
}