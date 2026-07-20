using UnityEngine;
using UnityEngine.SceneManagement; 

public class EndingController : MonoBehaviour
{
    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void PlayAgain()
    {
    SceneManager.LoadScene("Coding test");
    }
}
