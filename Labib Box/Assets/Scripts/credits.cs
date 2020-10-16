using UnityEngine;
using UnityEngine.SceneManagement;

public class credits : MonoBehaviour
{
  
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    // Update is called once per frame
    public void Quit()
    {
        Application.Quit();
    }
}
