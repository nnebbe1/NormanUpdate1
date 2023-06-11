using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    public TMP_Text health;
    public TMP_Text ingrediences;
    private int[] _foundObjects = { 4, 5, 6, 7 };
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

    private bool _hasAllIngrediences = false; 
    private bool _hasUmbrella = false;

    private GameManager instance;

    [SerializeField]
    private SoundManager _soundManager;

    private Animator _animator;

    void Start(){

        _animator = GetComponent<Animator>();

    }

    public IEnumerator looseHealth(int lives)
    {
        if(lives == 2)
        {
            Debug.Log("two lives left");
            health.text = "<sprite=0><sprite=1>";
        }else if (lives == 1)
        {
            health.text = "<sprite=0>";
        }else if (lives == 0)
        {
            health.text = "!!Game Over!!";
            yield return new WaitForSeconds(5);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }

    }

    public IEnumerator winGame(){

        press_e_interact.text = "The world is safed!";
        _soundManager.playSound("winning");
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1); 
    }

public void pickup_item(string item)
    {

        if (item == "tomato")
        {
            _foundObjects[0] = 0;
            Destroy(tomato);
            hide_press_e_prompt();
        }else if (item == "garlic")
        {
            _foundObjects[1] = 1;
            Destroy(garlic);
            hide_press_e_prompt();
        }else if (item == "mushroom")
        {
            _foundObjects[2] = 2;
            Destroy(mushroom);
            hide_press_e_prompt();
        }else if (item == "yogurt")
        {
            _foundObjects[3] = 3;
            Destroy(yogurt);
            hide_press_e_prompt();
        }else if (item == "umbrella"){
            _hasUmbrella = true;
            umbrella.transform.position = player.transform.position;
            umbrella.transform.parent = player.transform;
            hide_press_e_prompt();
        }

        ingrediences.text = ("<sprite=" + _foundObjects[0] + "><sprite=" + _foundObjects[1] + "><sprite=" + _foundObjects[2] + "><sprite=" + _foundObjects[3] + ">");

        Debug.Log(_foundObjects[0]);
        Debug.Log(_foundObjects[1]);
        Debug.Log(_foundObjects[2]);
        Debug.Log(_foundObjects[3]);
        if ((_foundObjects[0] == 0) && (_foundObjects[1] == 1) && (_foundObjects[2] == 2) && (_foundObjects[3] == 3))
        {
            _hasAllIngrediences = true;
        }
    }

    public IEnumerator k_splash()
    {
        Debug.Log("k_splash");
        ketchup_splash.text = "<sprite=0>";
        yield return new WaitForSeconds(3);
        ketchup_splash.text = "";
    }

    public void show_onion_prompt()
    {
        onion_prompt.text = "Press 'E' to talk to the onion";
    }

    public void onionTalk(){
       onion_prompt.text = "Onions can't talk you dummy!"; 
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

    public void not_finished_prompt()
    {
        press_e_interact.text = "You don't have all the ingredients for Siracha sauce yet, keep searching!";
    }

    public bool GetIngrediants()
    {
        if(_hasAllIngrediences == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}