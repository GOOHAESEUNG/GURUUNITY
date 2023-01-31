using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P_GameManager : MonoBehaviour
{
    public static P_GameManager gm;

    //private WaterDie script;

    private void Awake()
    {
        if (gm == null)
        {
            gm = this;
        }
    }

    public enum GameState
    {
        P_GameOver
    }

    public GameState gState;

    public GameObject gameLabel;

    Text gameText;




    // Start is called before the first frame update
    void Start()
    {
        gameText = gameLabel.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        gameLabel.SetActive(true);
        gameText.text = "실패";
        gameText.text = "고민하지 말고 얼른 와!";
        //gameText.color = new Color(255, 0, 0, 255);
        gState = GameState.P_GameOver;


    }
    /*public void GameOver()
    {
        gameLabel.SetActive(true);
        gameText.text = "Game Over";
        gameText.color = new Color(255, 0, 0, 255);
        gState = GameState.P_GameOver;
    }*/
}