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
    [SerializeField] private Text textScore;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateScoreUI();
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

    //Playing Scene
    public void TouchHomeOnPlay()
    {
        SceneManager.LoadScene(sceneBuildIndex: 0);
    }

    private void UpdateScoreUI()
    {
        int scoreCount = GameManager.instance.score;
        textScore.text = ""+ scoreCount;
    }
}
