using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winLosePanel : MonoBehaviour
{
    public GameObject FailPanel;
    public GameObject completePanale;
    bool PlayerTrigger, EnemyTrigger;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && !EnemyTrigger)
        {
          completePanale.gameObject.SetActive(true);
           PlayerTrigger = true;
          // Time.timeScale = 0.0f;
        }
        if (other.gameObject.tag == "enemy" && !PlayerTrigger)
        {
          FailPanel.gameObject.SetActive(true);
            
            EnemyTrigger = true;
          // Time.timeScale = 0.0f;
        }
    }
}
