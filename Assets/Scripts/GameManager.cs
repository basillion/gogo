using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text gameOver;
    bool isGameEnded = false;
    public float restartDelay = 4f;
    public GameObject completeLevelUI;
    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }
    public void EndGame()
    {

        if (isGameEnded == false)
        {
            isGameEnded = true;
            Debug.Log("GAME OVER");

            //FindObjectOfType<Score>().scoreText.enabled = false;
            gameOver.enabled = true;
            //Restart();
            Invoke("Restart", restartDelay);

        }
    }

    void Restart()
    {

        //if (Input.anyKeyDown)
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        FindObjectOfType<Score>().scoreText.enabled = true;
        gameOver.enabled = false;
    }

}
