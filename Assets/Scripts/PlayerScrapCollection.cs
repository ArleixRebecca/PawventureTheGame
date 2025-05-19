using UnityEngine;
using UnityEngine.Events;
public class PlayerScrapCollection : MonoBehaviour
{
    public int NumberOfScraps { get; private set; }

    public UnityEvent<PlayerScrapCollection> OnScrapCollected;

    public void ScrapCollected()
    {
        NumberOfScraps++;
        OnScrapCollected.Invoke(this);
    }
}
