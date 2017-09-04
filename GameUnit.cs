using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUnit : MonoBehaviour {

    int idGroup = 0;   //Player, Animy, Team itc..
    float unitHealth = 1f;
    Transform unitPosition;
    int unitScore = 0;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}



    void UnitHealthCheck()
    {
        if (unitHealth == 0)
            DestroyGameObject();
    }


    void DestroyGameObject()
    {
        Destroy(gameObject);
    }

}
