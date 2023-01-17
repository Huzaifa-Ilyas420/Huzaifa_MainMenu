using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject MainMenu_Screen;
    public GameObject Setting_Screen;
    public GameObject DailyBonus_Screen;
    public GameObject Earn_Screen;

    public static MainMenu Instace;
    private void Awake()
    {
          if(Instace == null)
        {
            Instace = this;
        }

          else
        {
            Destroy(this.gameObject);
        }
    }

    public void Start()
    {
        MainMenu_Screen.SetActive(true);
        Setting_Screen.SetActive(false);
        DailyBonus_Screen.SetActive(false);
        Earn_Screen.SetActive(false);
    }


   public void _Setting_Active()
    {
        
        Setting_Screen.SetActive(true);
        DailyBonus_Screen.SetActive(false);
        Earn_Screen.SetActive(false);
    }
    public void _Earn_Active()
    {
        
        Setting_Screen.SetActive(false);
        DailyBonus_Screen.SetActive(false);
        Earn_Screen.SetActive(true);
    }

    public void _DailyBonus_Active()
    {
   
        Setting_Screen.SetActive(false);
        DailyBonus_Screen.SetActive(true);
        Earn_Screen.SetActive(false);
    }



}
