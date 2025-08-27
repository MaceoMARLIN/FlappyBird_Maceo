using System;
using System.Security.Claims;
using Unity.Mathematics;
using UnityEngine;

public class SpawnerUpBehaviourScript : MonoBehaviour
{
    public GameObject columnPrefab;
    public float spawnRate = 3f;
    private float timer = 0f;
    public float heightOffset = 1f;
    public float vectorX = 10f;
    public float vectorY = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnRate)
        {
            float x = UnityEngine.Random.Range(-heightOffset, heightOffset);
            Instantiate(columnPrefab, new Vector3(vectorX, vectorY + x, -1.3f), Quaternion.Euler(0, 0, 180));
            timer = 0f;
        }
    }
}
