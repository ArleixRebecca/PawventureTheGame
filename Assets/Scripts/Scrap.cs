using UnityEngine;

public class Scrap : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerScrapCollection playerScrapCollection = other.GetComponent<PlayerScrapCollection>();

        if (playerScrapCollection != null)
        {
            playerScrapCollection.ScrapCollected();
            gameObject.SetActive(false);
        }
    }
}
