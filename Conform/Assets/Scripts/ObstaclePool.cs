using UnityEngine;
using System.Collections;

public class ObstaclePool : MonoBehaviour 
{
	public GameObject obstaclePrefab;                                 
	public int obsPoolSize = 5;
	public float obsMin = -1f;                                   
	public float obsMax = 3.5f;                                  
	public float spawnRate = 3f;

	private GameObject[] obstacles;                                   
	private int currentObstacle = 0;                                  

	private Vector2 objectPoolPosition = new Vector2 (-15,-25);
	private float spawnXPosition = 10f;

	//private float timeSinceLastSpawned;


	void Start()
	{
		//timeSinceLastSpawned = 0f;

		obstacles = new GameObject[obsPoolSize];
		for(int i = 0; i < obsPoolSize; i++)
		{
			obstacles[i] = (GameObject)Instantiate(obstaclePrefab, objectPoolPosition, Quaternion.identity);
		}
	}

	void Update()
	{

		if (GameControl.instance.gameOver == false) 
		{   
			float spawnYPosition = Random.Range(obsMin, obsMax);
			obstacles[currentObstacle].transform.position = new Vector2(spawnXPosition, spawnYPosition);
			currentObstacle ++;
			if (currentObstacle >= obsPoolSize) 
			{
				currentObstacle = 0;
			}
		}
	}
}