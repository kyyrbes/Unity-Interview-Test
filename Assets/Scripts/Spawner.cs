using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public SpriteRenderer Square;

    public void SpawnSquare()
    {
        var spawnedObj = Instantiate(Square);
        spawnedObj.transform.position = new Vector3(Random.Range(-10f, 10f), Random.Range(-5f, 5f), 0f);
    }
}
