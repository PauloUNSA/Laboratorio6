using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Cosmic_Retro_Station_Props_1_FREE");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}