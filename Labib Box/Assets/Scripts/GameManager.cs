using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool GameFin = false;
    public float restardelay = 2f;
    public GameObject CompUI;

    public void Endgame()
    {
        if(GameFin==false)
        {
            GameFin = true;
            Invoke("restart", restardelay);
        }
    }
    public void Complete()
    {
        if (GameFin == false)
        {
            GameFin = true;
            CompUI.SetActive(true);
        }
        
    }

    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
