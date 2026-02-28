using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUi : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    public void StartGame()
    {
        gameManager.Startgame();
    }

    public void QuitGame()
    {
        Application.Quit();
    }  
    
    public void ContinueGame()
    {
        gameManager.ResumeGame();
    } 
    
    public void MainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }    
}
