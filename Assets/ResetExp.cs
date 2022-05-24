using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ResetExp : MonoBehaviour
{
    private BallMovement ballMovement;

    void Awake ()
    {
        ballMovement = GameObject.Find("ball").GetComponent<BallMovement>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update () {
      if (Input.GetMouseButtonDown (0)) {    
             var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
             RaycastHit hit;
 
             if (Physics.Raycast(ray, out hit, 100)) {
                 // whatever tag you are looking for on your game object
                 if(hit.collider.tag == "resetbtn") {                         
                     Debug.Log(ballMovement);
                     ballMovement.resetBall();                 
                 }
             }    
         }
     }

 

}
