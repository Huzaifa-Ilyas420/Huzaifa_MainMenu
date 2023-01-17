using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Script_2 : MonoBehaviour
{
    public Text Show;

    public GameObject okay;

    // Instance code ===================================
    public static Script_2 Instance;

    public void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        else
        {
            Destroy(this.gameObject);
        }
    }
    // Instance code ===================================

    public void Start()
    {
        Show.text = "Huzaifa";

        Debug.Log(Show.text);
    }


    public void _Function_()
    {
        
    }
}
