using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreScript : MonoBehaviour
{
    public static int scoreValue = 0;
    Text score;

    //bool gameHasEnded = false;
    //public float nextLevelDelay = 2f;

    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Rocks collected: " + scoreValue + "/10";
    }

    //public void EndGame()
    //{
    //    if (gameHasEnded == false)
    //    {
    //        gameHasEnded = true;
    //        Debug.Log("GAME OVER");
    //        Invoke("nextLevel", nextLevelDelay);
    //    }
    //}
    //void nextLevel()
    //{
    //    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    //}
}
