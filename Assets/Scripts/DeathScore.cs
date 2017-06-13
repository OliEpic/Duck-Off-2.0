using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathScore : MonoBehaviour {

    public GameObject text;

	// Use this for initialization
	void Start () {

        text.GetComponent<Text>().text = "Your score was: " + Duck.distance + "M";

    }
	
	// Update is called once per frame
	void Update () {

        for (int i = 0; i < Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
                Application.LoadLevel("Game");
        }

    }
}
