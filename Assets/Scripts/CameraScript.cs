using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Camera movement
public class CameraScript : MonoBehaviour
{
    // IDEA - Camera should follow the player which is our target here
    [SerializeField]
    // we only need the Transform for our purposes and not the entrie player
    private Transform target;


    public Vector3 offset;

    [SerializeField]
    private Space offsetPositionSpace = Space.Self;

    [SerializeField]
    private bool lookAt = true;

    // Start is called before the first frame update
    void Start()
    {
        // initiate first position
        offset = transform.position - target.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //Nullcheck
        if (target == null)
        {
            Debug.LogWarning("Missing target ref !", this);

            return;
        }

        if(offsetPositionSpace == Space.Self)
        {
            transform.position = target.TransformPoint(offset);
        }
        else
        {
            // ADD OFFSET - to our position in order to depict the player properly 
            transform.position = target.transform.position + offset;
        }

        // compute rotation
        if (lookAt)
        {
            transform.LookAt(target);
        }
        else
        {
            transform.rotation = target.rotation;
        }

    }
}
