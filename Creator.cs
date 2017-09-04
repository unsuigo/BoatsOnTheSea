using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Create boats and random waypoints 
//if get wPoint choose other one
public class Creator : MonoBehaviour {


    //for debug
    int qtyBoats = 0;
    int qtyWPoints = 0;

	// Use this for initialization
	void Start () {
       
        RandomWayPoint();
    }
	
	// Update is called once per frame
	void Update () {
     StartCoroutine( CheckUserInputIE());

    }

   //create a new form with random position
   public void RandomWayPoint()
   {
      Transform WayPointRandom = (Transform)Instantiate(
                              Resources.Load("Prefabs/WayPoint",
                              typeof(Transform)),
                              new Vector3(Random.Range(-90f, 90f), 0f, Random.Range(-90f, 90f)),
                              Quaternion.identity);
        
   }

    public  void CreateBoat()
    {
        Transform BoatAI = (Transform)Instantiate(
                              Resources.Load("Prefabs/ArmyBoatAI",
                              typeof(Transform)),
                              new Vector3(20f, 0f, 20f),
                              Quaternion.identity);
    }


     IEnumerator  CheckUserInputIE()
     {

        CheckUserInput();
         yield return null;
     }


     void CheckUserInput()
     {
     
         if (Input.GetKeyDown(KeyCode.B))
         {
             CreateBoat();
             qtyBoats++;
          //   Debug.Log("qtyBoats  " + qtyBoats);
         }
         else if (Input.GetKeyDown(KeyCode.Space))
         {
             RandomWayPoint();
             qtyWPoints++;
           //  Debug.Log("qtyWPoints  " + qtyWPoints);
         }
     }
      
}
