using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static Score instance;
    public GameObject GameoverPanel;
	[HideInInspector]public int score;
	[HideInInspector]public int HighScore;
    public Text ScoreOnScreen;


	void Awake(){
		if(instance == null){
			instance = this;
		}


	}


	// Use this for initialization
	public void RestScore ()
     {
		score = 0;
        PlayerPrefs.SetInt("score",score);
        ScoreOnScreen.text = score.ToString();
	}
	
	// Update is called once per frame
	void Update () 
    {
		
	}
		

	public void incrementScore()
    {
		score += 1;
        ScoreOnScreen.text = score.ToString();
    }

	public void StopScore()
    {
		PlayerPrefs.SetInt("score",score);

		if (PlayerPrefs.HasKey("HighScore"))
        {
			if( score > PlayerPrefs.GetInt("HighScore"))
            {
				PlayerPrefs.SetInt("HighScore",score);
			}
		}
		else  
        {
			PlayerPrefs.SetInt("HighScore",score);
		}

	}


    public void ActiveEverything()
    {
        GameoverPanel.SetActive(true);
    }
    public void DeActiveEverything()
    {
        GameoverPanel.SetActive(false);
    }
}
