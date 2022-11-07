using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HUDManager : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private GameObject panelMenu;
    [SerializeField] private GameObject panelHowToPlay;
    [SerializeField] private GameObject panelAgradecimientos;
    [SerializeField] private Text textScore;
    [SerializeField] private Text highScore;
    
    private int scoreCount;

    void Start()
    {
        highScore.text = PlayerPrefs.GetInt("Record", 0).ToString();
        //scoreCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateScoreUI(); 
        //highScore.text = PlayerPrefs.GetInt("Record", 0).ToString();
        UpdateHighScores();
    }
    //Main Menu Scene
    public void TouchPlay()
    {
        SceneManager.LoadScene(sceneBuildIndex: 1);
    }

    public void TouchHowToPlay()
    {
        panelMenu.SetActive(false);
        panelHowToPlay.SetActive(true);
    }
    public void TouchHome()
    {
        panelMenu.SetActive(true);
        panelHowToPlay.SetActive(false);
    }
    public void TouchHome2()
    {
        panelMenu.SetActive(true);
        panelAgradecimientos.SetActive(false);
    }
    public void TouchAgradecimientos()
    {
        panelMenu.SetActive(false);
        panelAgradecimientos.SetActive(true);
    }

    public void TouchQuit()
    {
        Application.Quit();
    }

    public void UpdateHighScores()
    {
        if (scoreCount > PlayerPrefs.GetInt("Record", 0))
        {
            PlayerPrefs.SetInt("Record", scoreCount);
            highScore.text = scoreCount.ToString();
        }
    }

    //Playing Scene
    public void TouchHomeOnPlay()
    {
        SceneManager.LoadScene(sceneBuildIndex: 0);
    }

    private void UpdateScoreUI()
    {
        scoreCount = GameManager.instance.score;
        textScore.text = ""+ scoreCount;
    }

}
