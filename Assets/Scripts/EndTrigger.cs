using UnityEngine;

public class EndTrigger : MonoBehaviour
{

    public GameManager gameManager;

    void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            gameManager.CompleteLevel();
        }
        
    }

}
