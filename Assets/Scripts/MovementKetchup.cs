using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; 


public class MovementKetchup : MonoBehaviour
{
    public NavMeshAgent agent;
    public float radius_of_sphere;

    // Centre of the area the ketchup wants to move around in
    // Get set as the transform of the ketchup so the ketchup moves around his starting point
    public Transform centrePoint; 

    // Get the NavMeshAgent and the assigned center point
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        centrePoint = GetComponent<Transform>();
    }

    
    void Update()
    {
        // Checks if done with current path
        if(agent.remainingDistance <= agent.stoppingDistance) 
        {
            Vector3 point;
            // Pass in our centre point and radius of area
            // If a valid point is gotten out, set this as new destination of the NavMeshAgent
            if (RandomPoint(centrePoint.position, radius_of_sphere, out point)) 
            {
                agent.SetDestination(point);
            }
        }

    }



    // Gets a random point in the determined walking sphere if possible
    // Needs the center point, the radius and a result vector to give out
    bool RandomPoint(Vector3 center, float radius_of_sphere, out Vector3 result)
    {
        Vector3 randomPoint = center + Random.insideUnitSphere * radius_of_sphere; 
        NavMeshHit hit;
        if (NavMesh.SamplePosition(randomPoint, out hit, 50f, NavMesh.AllAreas))
        { 
            result = hit.position;
            return true;
        }

        result = Vector3.zero;
        return false;
    }

    
}