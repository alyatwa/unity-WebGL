using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StartExp : MonoBehaviour
{
    private BallMovement ballMovement;

    void Awake ()
    {
        ballMovement = GameObject.Find("ball").GetComponent<BallMovement>();
    }
    void Update () {
      if (Input.GetMouseButtonDown (0)) {    
             var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
             RaycastHit hit;

             if (Physics.Raycast(ray, out hit, 100)) {
                 if(hit.collider.tag == "startbtn") {                         
                     Debug.Log(ballMovement);
                     if(ballMovement.ballReleased == false) {
                       ballMovement.releaseBall();  
                     }                
                 }
             }    
         }
     }

 

}
