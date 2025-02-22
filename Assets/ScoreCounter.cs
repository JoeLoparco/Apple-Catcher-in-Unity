using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreCounter : MonoBehaviour 
{
    [Header("Dynamic")]
    public int score = 0;
    public int applesMissed = 0;
    [SerializeField] private TextMeshProUGUI uiText;
    private int previousMissedCount = 0;  // Track previous missed count to detect new misses
    private GameObject[] baskets;  // Store basket references

    void Start() 
    {
        if (uiText == null)
        {
            uiText = GetComponentInChildren<TextMeshProUGUI>();
            
            if (uiText == null)
            {
                Debug.LogError("Could not find TextMeshProUGUI component! Please assign it in the Inspector.");
                enabled = false;
                return;
            }
        }
    }

    void Update() 
    {
        if (uiText != null)
        {
            uiText.text = "High Score:" + score.ToString("#,0");
        }

        if (applesMissed > previousMissedCount)
        {
            baskets = GameObject.FindGameObjectsWithTag("Basket");
            
            if (baskets != null && baskets.Length > 0)
            {
                Destroy(baskets[baskets.Length - 1]);
            }
            
            previousMissedCount = applesMissed;
        }

        if (applesMissed == 3)
        {
            SceneManager.LoadScene(2);
        }
    }
}