using UnityEngine;

public class Socket : MonoBehaviour
{
    public string requiredItemTag; // The tag of the required item (e.g., "Hotdog", "Cup", "Ketchup")
    private bool isItemPlaced = false; // Tracks if the correct item is placed
    private GameObject placedItem; // Reference to the placed item

    public bool IsItemPlaced() => isItemPlaced;

    private void OnTriggerEnter(Collider other)
    {
        // Check if the incoming item matches the required tag
        if (!isItemPlaced && other.CompareTag(requiredItemTag))
        {
            isItemPlaced = true;
            placedItem = other.gameObject;
            Debug.Log($"Correct item {requiredItemTag} placed in socket!");

            // Notify the manager (optional: use an event or find the manager in the scene)
            FindObjectOfType<MealManager>().CheckMealCompletion();
        }
    }

    public void ResetSocket()
    {
        if (placedItem != null)
        {
            Destroy(placedItem); // Or move it back to its original position
        }

        isItemPlaced = false;
        placedItem = null;
    }
}

