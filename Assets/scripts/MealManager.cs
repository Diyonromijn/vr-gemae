using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MealManager : MonoBehaviour
{
    public Socket[] sockets; // Array of all the sockets in the scene
    public float score = 0; // The player's current score
    public float addedScore = 100; // Points to add for each completed meal
    public TextMeshPro scoreText; // Reference to the UI element displaying the score

    public void CheckMealCompletion()
    {
        // Check if all sockets have their correct items
        foreach (Socket socket in sockets)
        {
            if (!socket.IsItemPlaced())
            {
                return; // Exit early if any socket is incomplete
            }
        }

        Debug.Log("Meal complete!");

        // Add score and update the UI
        AddScore();

        // Reset the meal for the next round
        ResetMeal();
    }

    private void AddScore()
    {
        // Increment the score
        score += addedScore;

        // Update the score display
        if (scoreText != null)
        {
            scoreText.text = $"Score: {score}";
        }

        Debug.Log($"Score updated: {score}");
    }

    private void ResetMeal()
    {
        // Reset all sockets
        foreach (Socket socket in sockets)
        {
            socket.ResetSocket();
        }

        Debug.Log("Meal reset. Ready for the next one!");
    }
    private void Update()
    {
        if (score == 20) 
        {
            SceneManager.LoadScene("menuScene");
        }
    }


}