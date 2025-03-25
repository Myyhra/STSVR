using System;
using System.Collections;
using Unity.Mathematics;
using UnityEngine;


public class PunchBlockManager : MonoBehaviour
{
    [SerializeField] Transform leftPunchSpawner;
    [SerializeField] Transform rightPunchSpawner;
    public GameObject leftBlock;
    public GameObject rightBlock;
    public float spawnInterval = 1f;
    public bool isPlaying;
    public bool isSpawning;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isPlaying = false;
        isSpawning = false;
    }

    // Update is called once per frame
    void Update()
    {
        while(isPlaying)
        {
            StartGame();
        }
    }

    public void StartGame()
    {
        if(!isSpawning)
        StartCoroutine(SpawnBlock());
    }

    IEnumerator SpawnBlock()
    {
        isSpawning = true;
        yield return new WaitForSeconds(spawnInterval);
        int random = 0;
        random = UnityEngine.Random.Range(1,2);
        if (random == 1)
        {
            Instantiate(leftBlock,leftPunchSpawner.position,Quaternion.identity);
        }
        else if(random == 2)
        {
            Instantiate(rightBlock,rightPunchSpawner.position, Quaternion.identity);
        }
        isSpawning = false;

        
    }

}
