using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class U_StartMenu : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene("U_Game");
    }
    public void HowToPlayButton()
    {
        SceneManager.LoadScene("U_HowToPlay");
    }
    /*public void QuitGame()
    {
        Application.Quit();
    }*/
    /*public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }*/
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
