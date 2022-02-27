using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour
{
    public int currentLevel = 1;

    public float playerPoints = 0;
    public float maxLevelPoints = 200;
    public float playerLives = 3;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if(playerLives <= 0)
        {
            SceneManager.LoadScene("LoseScene");
        }

        if(playerPoints >= maxLevelPoints)
        {
            SceneManager.LoadScene("WinScene");
        }


        if (Input.GetKeyDown(KeyCode.H))
        {
            SceneManager.LoadScene("OpenScene");
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {
            SceneManager.LoadScene("LoseScene");
        }
        else if (Input.GetKeyDown(KeyCode.Y))
        {
            SceneManager.LoadScene("WinScene");
        }
        else if (Input.GetKeyDown(KeyCode.N))
        {
            currentLevel = currentLevel + 1;
        }

    }
}
