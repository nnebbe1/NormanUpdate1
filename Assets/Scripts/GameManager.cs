using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    public TMP_Text health;
    public TMP_Text ingrediences;
    private int[] foundObjects = { 4, 5, 6, 7 };
    public TMP_Text ketchup_splash;
    public TMP_Text press_e_interact;
    public TMP_Text onion_prompt;

    [SerializeField]
    private PersonScript player;

    [SerializeField]
    private GameObject garlic;

    [SerializeField]
    private GameObject tomato;

    [SerializeField]
    private GameObject mushroom;

    [SerializeField]
    private GameObject yogurt;

    [SerializeField]
    private GameObject umbrella;

    private bool hasAllIngredience = false; 
    private bool hasUmbrella = false;

    private GameManager instance;

    void start(){

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

    public void pickup_item(string item)
    {

        if (item == "tomato")
        {
            foundObjects[0] = 0;
            Destroy(tomato);
            hide_press_e_prompt();
        }else if (item == "garlic")
        {
            foundObjects[1] = 1;
            Destroy(garlic);
            hide_press_e_prompt();
        }else if (item == "mushroom")
        {
            foundObjects[2] = 2;
            Destroy(mushroom);
            hide_press_e_prompt();
        }else if (item == "yogurt")
        {
            foundObjects[3] = 3;
            Destroy(yogurt);
            hide_press_e_prompt();
        }else if (item == "umbrella"){
            hasUmbrella = true;
            umbrella.transform.position = player.transform.position;
            umbrella.transform.parent = player.transform;
            hide_press_e_prompt();
        }

        ingrediences.text = ("<sprite=" + foundObjects[0] + "><sprite=" + foundObjects[1] + "><sprite=" + foundObjects[2] + "><sprite=" + foundObjects[3] + ">");

        if ((foundObjects[0] == 0) && (foundObjects[1] == 1) && (foundObjects[2] == 2) && (foundObjects[3] == 3))
        {
            hasAllIngredience = true;
        }
    }


    public IEnumerator k_splash()
    {
        Debug.Log("k_splash");
        ketchup_splash.text = "<sprite=0>";
        yield return new WaitForSeconds(5);
        ketchup_splash.text = "";
    }

    public void show_onion_prompt()
    {
        onion_prompt.text = "Press 'E' to talk to the onion";
    }

    public void hide_onion_prompt()
    {
        onion_prompt.text = "";
    }


    public void show_press_e_prompt()
    {
        press_e_interact.text = "Press 'E' to interact";
    }
    public void hide_press_e_prompt()
    {
        press_e_interact.text = "";
    }
}