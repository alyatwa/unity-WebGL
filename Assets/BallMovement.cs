using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{

    Rigidbody m_Rigidbody;
    Vector3 originalPos;
    public bool ballReleased = false;
 
    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        originalPos = m_Rigidbody.transform.position;
        
        m_Rigidbody.constraints = RigidbodyConstraints.FreezePositionY;
        
    }

    // Update is called once per frame
    void Update()
    {

        
    }
    public void releaseBall() {
        ballReleased = true;
        m_Rigidbody.constraints = RigidbodyConstraints.None;
        GameManager.instance.StartStopwatch();
    }
    
    public void resetBall() {
        ballReleased = false;
        m_Rigidbody.transform.position = originalPos;
        m_Rigidbody.constraints = RigidbodyConstraints.FreezePositionY;
        GameManager.instance.ResetStopwatch();
    }

    void OnCollisionEnter (Collision collision)
     {
        if (collision.gameObject.name == "collider")
        {
            //stop timer
            GameManager.instance.StopStopwatch();
            ballReleased = true;

        }

 }
}
