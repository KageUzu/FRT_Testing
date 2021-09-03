using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenChange : MonoBehaviour
{
    private void Start()
    {
        Time.timeScale = 1;
    }
    public void Test()
    {
        SceneManager.LoadScene("FRTTestLevel");
    }
    public void GameOver()
    {
        SceneManager.LoadScene("GameOverScreen");
    }

    public void Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void exitgame()
    {
        Debug.Log("exitgame");
        Application.Quit();
    }
}
