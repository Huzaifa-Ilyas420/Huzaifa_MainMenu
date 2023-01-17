using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Script_1 : MonoBehaviour
{
    //public Script_2 ref_script_2;


    public Text show;

    // Instance code ===================================
    public static Script_1 Instance;
    public void Awake()
    {
         if(Instance == null)
        {
            Instance = this;
        }

         else
        {
            Destroy(this.gameObject);
        }
    }
    // Instance code ===================================

    public void _Button_Clicked()
    {
        // Approach 1
        //ref_script_2.Show.text = "Hamza";
        //Debug.Log(ref_script_2.Show.text);
        show.text = "Hamza";



        // Approach 2
        // GameObject.Find("change ").GetComponent<Script_2>().Show.text = "Hamza";


        // Approach 3
        Script_2.Instance.Show.text = "Hamza";
        Script_2.Instance._Function_();
    }

}
