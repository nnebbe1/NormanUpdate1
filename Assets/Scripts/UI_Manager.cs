using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_Manager : MonoBehaviour
{
    [SerializeField]
    public TMP_Text health;
    public TMP_Text ingrediences;
    private int[] foundObjects = { 4, 5, 6, 7 };
    public TMP_Text ketchup_splash;
    public TMP_Text press_e_tmp;

    void Awake()
    {
        Debug.Log("awake");
        StartCoroutine(k_splash());
        show_press_e();

    }

    public void looseHealth()
    {
        if (health.text == "<sprite=0><sprite=1><sprite=2>")
        {
            health.text = "<sprite=0><sprite=1>";
        }
        else if (health.text == "<sprite=0><sprite=1>")
        {
            health.text = "<sprite=0>";
        }
    }

    public bool ingredienceUI(string ingredience)
    {
        if (ingredience == "tomato")
        {
            foundObjects[0] = 0;
        }
        if (ingredience == "garlic")
        {
            foundObjects[1] = 1;
        }
        if (ingredience == "mushroom")
        {
            foundObjects[2] = 2;
        }
        if (ingredience == "yogurt")
        {
            foundObjects[3] = 3;
        }

        ingrediences.text = ("<sprite=" + foundObjects[0] + "><sprite=" + foundObjects[1] + "><sprite=" + foundObjects[2] + "><sprite=" + foundObjects[3] + ">");

        if ((foundObjects[0] == 0) && (foundObjects[1] == 1) && (foundObjects[2] == 2) && (foundObjects[3] == 3))
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    private IEnumerator k_splash()
    {
        Debug.Log("k_splash");
        ketchup_splash.text = "<sprite=0>";
        yield return new WaitForSeconds(5);
        ketchup_splash.text = "";
    }

    private void show_onion_prompt()
    {
        onion_prompt.text = "Press 'E' to talk to the onion";
    }

    private void hide_onion_prompt()
    {
        onion_prompt.text = "";
    }


    private void show_press_e_prompt()
    {
        Debug.Log("show_press_E");
        press_e_tmp.text = "Press 'E' to interact";
    }
    private void hide_press_e_prompt()
    {
        Debug.Log("hide_press_E");
        press_e_tmp.text = "";
    }
}