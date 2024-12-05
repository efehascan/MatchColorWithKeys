using UnityEngine;
using System.Collections;

public class BallSpawner : MonoBehaviour
{
    public GameObject[] ball;

    private float sabitX = 0f;
    private float sabitY = 0f;
    private float sabitZ = 0f;
    
    public float SpawnSuresi = 1.0f;
    
    void Start()
    {
        StartCoroutine(SpawnFruits());
    }

    void Update()
    {
        
    }
    
    IEnumerator SpawnFruits()
    {
        while(true)
        {
            int randomFruit = Random.Range(0, ball.Length);
            Vector3 spawnPos = new Vector3(sabitX, sabitY, sabitZ);
            
            Instantiate(ball[randomFruit], spawnPos, Quaternion.identity);
            
            yield return new WaitForSeconds(SpawnSuresi);
        }
    }
}
