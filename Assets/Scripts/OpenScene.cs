using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class OpenScene : MonoBehaviour
{
    public string scenename;
    public void LoadScene()
    {
        SceneManager.LoadScene(scenename);
    }
}
