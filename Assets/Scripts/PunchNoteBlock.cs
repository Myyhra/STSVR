using System.Collections;
using UnityEngine;
using System.Threading.Tasks;
public class PunchNoteBlock : MonoBehaviour
{
    public float xSpeed;
    public float ySpeed;
    [SerializeField] private ParticleSystem ps;
    [SerializeField] private MeshRenderer rend;
    [SerializeField] private Collider col;
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
        StartCoroutine(WaitAndDestroy());
    }
    
    IEnumerator WaitAndDestroy()
    {
        ps.Play();
        rend.enabled = false;
        col.enabled = false;
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }

    
}
