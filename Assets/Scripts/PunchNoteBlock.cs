using UnityEngine;

public class PunchNoteBlock : MonoBehaviour
{
    public float speed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }

    public void DestroyNote()
    {
        PunchBlockManager.Instance.score++;
        Debug.Log("Score: " + PunchBlockManager.Instance.score);
        Destroy(gameObject);
    }

    
}
