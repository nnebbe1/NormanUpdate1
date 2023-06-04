using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private void Awake()
    {
        instance = this;

    }

    // Ressources

    //public int[] ingrediences_collected = [0,0,0,0];

    public bool has_umbrella = false;

    // References
    //public Player player;
    public UI_Manager ui_manager;
    public SoundManager sound_manager;

}

