using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdBehaviour : MonoBehaviour
{
    //Variables
    [SerializeField]
    private float _speed = 5f;
    private float _jumpingSpeed = 10f;

    [SerializeField]
    private Rigidbody RB;

    // -- time delay --
    private float _coolDownTime = 2f;
    private float _nextJumpTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        //START POSITION
        transform.position = new Vector3(-5f, 22f, 163f);

    }

    // Update is called once per frame
    void Update()
    {

        //MOVEMENT 
        float horizontalInput = Input.GetAxis("Horizontal");
        Debug.Log(horizontalInput);
        // time.delta time adjusts your speed to the frame rate - makes it move more smoothly
        transform.Translate(Vector3.right * Time.deltaTime * _speed * horizontalInput*100);

        // JUMPING 
        if (Input.GetKeyDown("space") && _nextJumpTime < Time.time)
        {
            RB.velocity += new Vector3(0f, _jumpingSpeed, 0f);
            _nextJumpTime = Time.time + _coolDownTime;
        }

        //Teleport -if player is leaving map teleport them back to center 
        if (transform.position.x < -40 || transform.position.x > 40)
        {
            transform.position = new Vector3(-5f, 22f, 163f);
        }

    }
}

//updated direction vector

//Vector3 movementRotated = Quaternion.AngleAxis(Camera.main.transform.eulerAngles.y, Vector3.up) * movement;
