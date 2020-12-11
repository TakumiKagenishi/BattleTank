using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    private int score = 0;
    private Text scoreLabel;
    // Start is called before the first frame update
    void Start()
    {
        scoreLabel = GetComponent<Text>();
        scoreLabel.text = "SCORE : " + score;
    }

    public void AddScore(int amount)
    {
        score += amount;
        scoreLabel.text = "SCORE : " + score;
    }

    // Update is called once per frame
    void Update()
    {
        if(score == 30)
        {
            Invoke("GoToGameClear", 1.5f);
        }
    }
    void GoToGameClear()
    {
        SceneManager.LoadScene("GameClear");
    }
}
