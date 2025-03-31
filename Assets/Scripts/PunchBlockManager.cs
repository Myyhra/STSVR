using System;
using System.Collections;
using TMPro;
using Unity.Mathematics;
using UnityEngine;


public class PunchBlockManager : MonoBehaviour
{
    public static PunchBlockManager Instance;
    [SerializeField] Transform leftPunchSpawner;
    [SerializeField] Transform rightPunchSpawner;
    public GameObject leftBlock;
    public GameObject rightBlock;
    public float spawnInterval = 1f;
    public bool isPlaying;
    public bool isSpawning;

    [SerializeField] TextMeshProUGUI textScore;
    public int score;
    void Awake()
    {
        if(Instance !=null && Instance!=this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }
    void Start()
    {
        score = 0;
        isPlaying = false;
        isSpawning = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(isPlaying)
        {
            if (!isSpawning)
                StartCoroutine(SpawnBlock());
        }
        textScore.text = "Score: " + score;
    }

    public void StartGame()
    {
        score = 0;
        isPlaying = true;
        
    }
    public void EndGame()
    {
        isPlaying = false;
        isSpawning = false;
        GameObject[] obs = GameObject.FindGameObjectsWithTag("PunchBlock");
        foreach(GameObject obsObj in obs)
        {
            Destroy(obsObj);
        }
    }

    IEnumerator SpawnBlock()
    {
        isSpawning = true;
        yield return new WaitForSeconds(spawnInterval);
        if (isPlaying)
        {
        int random = 0;
        random = UnityEngine.Random.Range(1,3);
        if (random == 1)
        {
            
            Instantiate(leftBlock,leftPunchSpawner.position,Quaternion.identity);
        }
        else
        {
            
            Instantiate(rightBlock,rightPunchSpawner.position, Quaternion.identity);
        }

        }
        isSpawning = false;
    }

}
