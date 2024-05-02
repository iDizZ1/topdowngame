using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuBtn : MonoBehaviour
{

    public void OpenGame()
    {
        SceneManager.LoadScene("NameInput");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}

