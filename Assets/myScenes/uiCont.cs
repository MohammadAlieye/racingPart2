using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class uiCont : MonoBehaviour
{
    public string scenenames;
    public GameObject Panel;

    public void LoadScenes()
    {   
        SceneManager.LoadScene(scenenames);
    }
    public void ExitPanel()
    {
         Panel.SetActive(false);
    }
    public void ShowPanel()
    {
         Panel.SetActive(true);
    }
    public void GameExit()
             
         {
             Application.Quit();
         }
}
