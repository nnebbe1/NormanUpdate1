using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;

public class enemyScript : MonoBehaviour
{
    [SerializeField]
    private GameManager _gameManager;

    private void OnTriggerEnter(Collider other)
    {

        //UnityEngine.Debug.Log(other.tag);
        if (other.CompareTag("Player"))
        {
            UnityEngine.Debug.Log("player-rain-collision");
            Destroy(this.gameObject);
            other.GetComponent<PersonScript>().Damage(0);

        }

        //if (other.CompareTag("Player"))
        //{
        //    Destroy(this.gameObject);
        //    other.GetComponent<NewBehaviourScript>().Damage();
        //}
    }
}
