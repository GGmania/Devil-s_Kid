using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_menu : MonoBehaviour
{
    public GameObject x;
    public GameObject y;
    
    public void Activate()
    {
        x.SetActive(false);
        y.SetActive(true);
    }
}
