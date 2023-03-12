using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableGobj : MonoBehaviour
{
   public GameObject obj;
    void Start()
    {
        obj.SetActive(false);
    }
}
