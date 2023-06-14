using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerCoin : MonoBehaviour
{
    public GameObject coinPrefab;

    public int numCoins = 10;

    public float minX = -5f;
    public float maxX = 5f;
    public float minY = 0.5f;
    public float maxY = 3f;
    public float minZ = -5f;
    public float maxZ = 5f;

    // Start is called before the first frame update
    void Start()
    {
        // Spawn the coins
        for (int i = 0; i < numCoins; i++)
        {
            // Choose a random position for the coin
            float x = Random.Range(minX, maxX);
            float y = Random.Range(minY, maxY);
            float z = Random.Range(minZ, maxZ);

            // Create a new coin object at the random position
            GameObject newCoin = Instantiate(coinPrefab, new Vector3(x, y, z), Quaternion.identity);

            // Set the parent of the new coin to this object
            newCoin.transform.parent = transform;
        }
    }
}
