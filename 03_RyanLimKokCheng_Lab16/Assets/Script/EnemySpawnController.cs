using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnController : MonoBehaviour
{
    public GameObject EnemyPrefab;
    public float TimeIntervals;

    public float MinX;
    public float MinZ;

    public float MaxX;
    public float MaxZ;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitAndSpawn(TimeIntervals));
    }   

    // Update is called once per frame
    void Update()
    {

    }

    private IEnumerator WaitAndSpawn(float Waittime)
    {
        while (true)
        {
            yield return new WaitForSeconds(Waittime);

            Vector3 spawnposition = new Vector3(Random.Range(MinX, MaxX), 0.55f, Random.Range(MinZ, MaxZ));

            Instantiate(EnemyPrefab, spawnposition, Quaternion.identity);
        }
    }
}
