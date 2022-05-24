using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public class cam : MonoBehaviour
{

    public Camera cameraObj;
    public GameObject myGameObj;
    public float speed = 2f;

         public float minFOV;
     public float maxFOV;
     public float sensitivity;
     public float FOV;

    private void Awake()
    {
        if (cameraObj == null)
        {
            cameraObj = Camera.main;
        }

        
    }
    // Start is called before the first frame update
    void Start()
    { 

    }
    private void LateUpdate()
     {

   
     }
      public void OnGUI()
 {
    float ScrollWheelChange = Event.current.delta.y;
     if(Event.current.type == EventType.ScrollWheel)
         {
         FOV = Camera.main.fieldOfView;
         FOV += (ScrollWheelChange * sensitivity) * -1;
         FOV= Mathf.Clamp(FOV, minFOV, maxFOV);
         Camera.main.fieldOfView = FOV;
         }
 }
    // Update is called once per frame
    void Update()
    {

         FOV = Camera.main.fieldOfView;
         FOV += (Input.GetAxis("Mouse ScrollWheel") * sensitivity) * -1;
         FOV= Mathf.Clamp(FOV, minFOV, maxFOV);
         Camera.main.fieldOfView = FOV;

        if(Input.GetMouseButton(0))
    {
     cameraObj.transform.RotateAround(myGameObj.transform.position, 
                                     cameraObj.transform.up,
                                     -Input.GetAxis("Mouse X")*speed);

     cameraObj.transform.RotateAround(myGameObj.transform.position, 
                                     cameraObj.transform.right,
                                     -Input.GetAxis("Mouse Y")*speed);
    }

    }

}