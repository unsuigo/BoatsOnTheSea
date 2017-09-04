using UnityEngine;
using System.Collections;


// for triggers of WayPoints
public class Waypoint : MonoBehaviour
{

 
    public bool GotThePoint;
    BoxCollider collider;

    // Use this for initialization
    void Awake()
    {
        collider = GetComponent<BoxCollider>();
    }

    public Vector3 WayPoint
    {
        get
        {

            Vector3 pos = transform.position;
           
            return pos;
        }
    }


   
}