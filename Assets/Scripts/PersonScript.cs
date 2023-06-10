using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonScript : MonoBehaviour
{
    // First thing we need is a reference to our character controller
    //[SerializeField]
    //private CharacterController _controller;

    [SerializeField]
    private float _speed = 600f;
    [SerializeField]
    private float _jumpingSpeed;
    [SerializeField]
    private float _extraGravity;

    [SerializeField]
    private SoundManager soundManager;

    [SerializeField]
    private UI_Manager uiManager;


    // -- time delay --
    private float _coolDownTime = 2f;
    private float _nextJumpTime = 0f;

    //Making turns smoother 
    [SerializeField]
    private float turnSmoothTime = 0.1f;

    [SerializeField]
    private Camera cam;

    [SerializeField]
    private Transform position_Cam;

    [SerializeField]
    private Transform position_Player;

    private Vector3 direction = new Vector3(-257.9f, 43.7f, -13.2f);
    private Rigidbody player_rigidbody;

    private bool hasUmbrella; 


    void Start()
    {
        
        //START POSITION
        transform.position = direction;
        player_rigidbody = GetComponent<Rigidbody>();
        hasUmbrella = false;
    }

    void FixedUpdate()
    {

        Vector3 movement = (position_Player.position - position_Cam.position) / 30;
        movement.y = 0;
        Vector3 movement_right = new Vector3(-movement.z, 0f, movement.x);
        Vector3 movement_left = new Vector3(movement.z, 0f, -movement.x);

        float targetAngel = Mathf.Atan2(movement.x, movement.z) * Mathf.Rad2Deg;
        player_rigidbody.AddForce(0,-_extraGravity,0);
        

        //updated direction vector
        //Vector3 movementRotated = Quaternion.AngleAxis(cam.transform.eulerAngles.y, Vector3.up) * movement;

        //adjust rotation of player
        if (Input.GetAxisRaw("Vertical") > 0)
        {
            //transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movementRotated.normalized), 0.1f);
            player_rigidbody.AddForce((movement * _speed * Time.deltaTime)*50);
            transform.rotation = Quaternion.Euler(0f, targetAngel, 0f);
        }
        
        if (Input.GetAxisRaw("Vertical") < 0)
        {
            //transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movementRotated.normalized), 0.1f);
            player_rigidbody.AddForce((-1)*(movement * _speed * Time.deltaTime)*50);
        }

        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            Debug.Log("horizontal <0");
            //transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movementRotated.normalized), 0.1f);
            player_rigidbody.AddForce((movement_right * _speed * Time.deltaTime)*50);
        }

        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            Debug.Log("horizontal >0");
            //transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movementRotated.normalized), 0.1f);
            player_rigidbody.AddForce((movement_left * _speed * Time.deltaTime)*50);

        }
        if (Input.GetKey("space") && _nextJumpTime < Time.time)
        {
            Debug.Log("space");
            player_rigidbody.velocity = new Vector3(0f, _jumpingSpeed, 0f);
            Debug.Log(player_rigidbody.velocity);
            _nextJumpTime = Time.time + _coolDownTime;
        }

        

        // this code simulates air resistance: slowing down when no input is pressed
        var direction = -player_rigidbody.velocity.normalized;
        var forceAmount = (player_rigidbody.velocity.magnitude);
        var air_resistance = new Vector3(direction.x * forceAmount, 0f, direction.z * forceAmount);
        player_rigidbody.AddForce(air_resistance);
        }

     private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("onion"))
        {
            uiManager.show_onion_prompt();

        }

        if (other.CompareTag("Rain"))
        {
            uiManager.looseHealth();
            soundManager.playSound("rain");

        }

        if (other.CompareTag("Ketchup"))
        {
            uiManager.looseHealth();
            uiManager.k_splash();
            soundManager.playSound("damage");

            //SoundManager damage sound
        }

        if (other.CompareTag("garlic"))
        {
            uiManager.show_press_e_prompt();
        }

        if (other.CompareTag("mushroom"))
        {
            uiManager.show_press_e_prompt();
        }

        if (other.CompareTag("yogurt"))
        {
            uiManager.show_press_e_prompt();
        }

        if (other.CompareTag("tomato"))
        {
            uiManager.show_press_e_prompt();
        }

        if (other.CompareTag("pot"))
        {
            uiManager.show_press_e_prompt();
        }

        if (other.CompareTag("umbrella"))
        {
            uiManager.show_press_e_prompt();
        }

    }

    private void OnTriggerStay(Collider other){
        
        if (other.CompareTag("onion"))
        {
            if (Input.GetKey(KeyCode.E)){
                soundManager.playSound("onion");
            }

        }
         if (other.CompareTag("garlic"))
        {
            if (Input.GetKey(KeyCode.E)){
                uiManager.ingredienceUI(other.tag);
                soundManager.playSound("collect");
            }
        }

        if (other.CompareTag("mushroom"))
        {
           if (Input.GetKey(KeyCode.E)){
                uiManager.ingredienceUI(other.tag);
                soundManager.playSound("collect");
            } 
        }

        if (other.CompareTag("yogurt"))
        {
           if (Input.GetKey(KeyCode.E)){
                uiManager.ingredienceUI(other.tag);
                soundManager.playSound("collect");
            } 
        }

        if (other.CompareTag("tomato"))
        {
            if (Input.GetKey(KeyCode.E)){
                uiManager.ingredienceUI(other.tag);
                soundManager.playSound("collect");
            }
        }

        if (other.CompareTag("umbrella"))
        {
            if (Input.GetKey(KeyCode.E)){
                soundManager.playSound("collect");
                hasUmbrella = true;
            }
        }

        if (other.CompareTag("pot"))
        {
           if (Input.GetKey(KeyCode.E)){
                // if all ingredience collected...
            } 
        }


    }

    private void OnTriggerExit(Collider other){

        if (other.CompareTag("onion"))
        {
            uiManager.hide_onion_prompt();
        }else if (other.CompareTag("tomate") || other.CompareTag("garlic") || other.CompareTag("mushroom") || other.CompareTag("yogurt") || other.CompareTag("pot"))
        {
            uiManager.hide_press_e_prompt();
        }else if (other.CompareTag("rain")){
            soundManager.playSound("background");

        }

    }
}
