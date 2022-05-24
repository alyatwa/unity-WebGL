using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    public static GameManager instance = null;

    float currentTime;
    bool stopwatchActive = false;
    
    public Text timeText;
    Camera cam;

    void Awake() {
        if (instance == null) {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
        //timeText.transform.position = GameObject.Find("timerx").transform.position;
    }

    // Start is called before the first frame update
    void Start()
    {
        timeText = GameObject.Find("timer").GetComponent<Text>();
        //timeText.transform.position = GameObject.Find("timerx").transform.position;
        //timeText.transform.localScale = GameObject.Find("timerx").transform.localScale;
        //cam = Camera.main;
        //cam.transform.localEulerAngles = new Vector3(3.3f, 107.7f, 0);

        currentTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(cam.transform.localEulerAngles);
        if (stopwatchActive == true){
            currentTime = currentTime + Time.deltaTime;
        }
        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        timeText.text = "0." + time.ToString(@"fff")+" Sec";

    }
    public void StartStopwatch() {
        stopwatchActive = true;
        Debug.Log("start");
    }
    public void StopStopwatch() {
        stopwatchActive = false;
        
        Debug.Log(currentTime);
    }
    public void ResetStopwatch() {
        stopwatchActive = false;
        
        currentTime = 0;
        Debug.Log("reset");
    }
}
