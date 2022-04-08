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
    
    private int scoreCount;

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
