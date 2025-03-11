using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonCounter : MonoBehaviour
{
    public TextMeshProUGUI counterText; // Reference to the text UI element
    private int count = 0; // Button press count

    void Start()
    {
        // Initialize the text
        counterText.text = "Reps: " + count;

        // Get the Button component and add a listener
        GetComponent<Button>().onClick.AddListener(IncrementCount);
    }

    void IncrementCount()
    {
        count++; // Increase count
        counterText.text = "Reps: " + count; // Update UI
    }
}
