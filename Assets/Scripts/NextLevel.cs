using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{

    // Function to be called when the button is clicked
    public void OpenScene(string scenename)
    {
        // Load the scene by its name
        SceneManager.LoadScene(scenename);
    }
}