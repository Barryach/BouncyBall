using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Debug.Log("¡Más de un Game Manager en escena!");
        }
    }

    public void PlayerDied()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Reinicia la escena actual
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu"); // Carga la escena del menú principal
    }
}
