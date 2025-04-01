using UnityEngine;

public class PunchNoteBlock : MonoBehaviour
{
    public float xSpeed;
    public float ySpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(xSpeed,0,ySpeed) * Time.deltaTime;
    }

    public void DestroyNote()
    {
        PunchBlockManager.Instance.score++;
        Debug.Log("Score: " + PunchBlockManager.Instance.score);
        Destroy(gameObject);
    }

    
}
