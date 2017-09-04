using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


//Create an array of WayPoints and do target for NavMeshAgent
public class BoatAIAgent : MonoBehaviour {

    //private NavMeshAgent agent;
    [HideInInspector] public Transform target;
    //Transform WayPointRandom;
    //public Transform player;

    GameObject WPoint;
    GameObject[] objectList;


    void Start () {
       
        
        // player = GameObject.FindWithTag("Player").transform;  // folowing player
        
        //array of all created WayPoints 
        objectList = GameObject.FindGameObjectsWithTag("WayPoint");
       
      // Debug.Log("objectList is  " + objectList.Length);

        //first WaiPoint target
        WPoint = objectList[Random.Range(0, objectList.Length)];
      //  print("set WPoint list ");
         target = WPoint.transform;

       // Debug.Log("targe is  " + target);

    }
	
	
	void Update () {
        
        StartCoroutine(WPIsRiched());
       
    }
    
    // change WayPoint when it riched
    void WayPointIsRiched ()
    {
         if (Vector3.Distance(transform.position, target.transform.position) < 10)
         {
            WPoint = objectList[Random.Range(0, objectList.Length)];
            target = WPoint.transform;
        }
    }

    IEnumerator WPIsRiched()
    {
        WayPointIsRiched();
        yield return new WaitForSeconds(1f);
    }

}
