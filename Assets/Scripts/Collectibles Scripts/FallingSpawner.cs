using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingSpawner : MonoBehaviour
{
    [SerializeField] private float MinSpawnPositionX;
    [SerializeField] private float MaxSpawnPositionX;
    [SerializeField] private int SpawnRate;
    [SerializeField] private FallingCollectable FallingCollectable;
    private bool Life = true;

    private void Start()
    {
        StartCoroutine(SpawnObject());
    }

    private IEnumerator SpawnObject()
    {
        while (true)
        {
            float YPosition = 5.5f;
            float RandomXPosition = Random.Range(MinSpawnPositionX, MaxSpawnPositionX);
            Vector2 SpawnPosition = new Vector2(RandomXPosition, YPosition);

            yield return new WaitForSeconds(SpawnRate);
            Instantiate(FallingCollectable, SpawnPosition, Quaternion.identity);
        }
    }
}