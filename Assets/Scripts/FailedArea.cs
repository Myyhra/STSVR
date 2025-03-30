using UnityEngine;

public class FailedArea : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("PunchBlock"))
        {
            Debug.Log("Failed");
            PunchBlockManager.Instance.EndGame();
           Destroy(other.gameObject);
        }
    }
}
