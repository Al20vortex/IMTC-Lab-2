using UnityEngine;
using UnityEngine.UI; 

public class GameScript : MonoBehaviour
{
    public GameObject youWinText; // Reference to the UI element (Text or Image)

    // Update is called once per frame
    void Update()
    {
        // Check the rotation of the can
        // If the Z-axis is more than 90 degrees, consider it flipped
        if (Vector3.Dot(transform.up, Vector3.up) < 0.5f)
        {
            // Show the UI element when the can is flipped
            youWinText.SetActive(true);
        }
        else
        {
            // Hide the UI element when the can is upright
            youWinText.SetActive(false);
        }
    }
}
