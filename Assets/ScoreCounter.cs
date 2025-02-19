using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreCounter : MonoBehaviour 
{
    [Header("Dynamic")]
    public int score = 0;
    public int applesMissed = 0;
    [SerializeField] private TextMeshProUGUI uiText;  // Add SerializeField to assign in Inspector

    void Start() 
    {
        // Only try to get component if it hasn't been assigned in Inspector
        if (uiText == null)
        {
            uiText = GetComponentInChildren<TextMeshProUGUI>();  // Try to find in children
            
            if (uiText == null)
            {
                Debug.LogError("Could not find TextMeshProUGUI component! Please assign it in the Inspector.");
                enabled = false; // Disable the script to prevent null reference in Update
                return;
            }
        }
    }

    void Update() 
    {
        if (applesMissed == 3){
           SceneManager.LoadScene(2); // Load Game Screen
        }
        if (uiText != null)  // Add null check for safety
        {
            uiText.text = "High Score:" +score.ToString("#,0");
        }
    }
}