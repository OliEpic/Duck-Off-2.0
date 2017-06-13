using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Duck : MonoBehaviour {

    public GameObject text;
    static public int distance;
    float timeLeft;

	// Use this for initialization
	void Start () {

        distance = 0;
        timeLeft = 0.5f;
		
	}

    // Update is called once per frame
    void Update()
    {

        Vector3 movement = new Vector3(Input.acceleration.x / 3, 0, 0);
        //Vector3 movement = new Vector3(Input.GetAxis("Horizontal") / 5, 0, 0);

        text.GetComponent<Text>().text = "Distance: " + distance + "M";

        if (movement.x < 0)
        {

            if (transform.position.x > -8)
            {

                transform.Translate(movement);

            }

        }

        if (movement.x > 0)
        {

            if (transform.position.x < 8)
            {

                transform.Translate(movement);

            }

        }

        timeLeft -= Time.deltaTime;

        if (timeLeft < 0)
        {

            distance += 1;

            timeLeft = 0.5f;

        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        Application.LoadLevel("GameOver");

    }

}
