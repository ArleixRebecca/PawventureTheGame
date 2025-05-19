using UnityEngine;
using TMPro;
public class ScrapUI : MonoBehaviour
{
    private TextMeshProUGUI scrapText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scrapText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateScrapText(PlayerScrapCollection playerScrapCollection)
    {
        scrapText.text = playerScrapCollection.NumberOfScraps.ToString();
    }
}
