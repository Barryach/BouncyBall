using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void PlayerDied()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
