using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowballController : MonoBehaviour {

    public GameObject snowball;
    List<GameObject> snowballs = new List<GameObject>();

    public float duration;
    float timeLeft;

    void Start() {

        timeLeft = duration;
        snowballs.Add(Instantiate(snowball, new Vector3(Random.Range(-8, 8), 8, -1), Quaternion.identity));

    }


    void Update () {

        timeLeft -= Time.deltaTime;

        if (timeLeft < 0)
        {

            snowballs.Add(Instantiate(snowball, new Vector3(Random.Range(-8, 8), 8, -1), Quaternion.identity));
            //Instantiate(snowball, new Vector3(5, 8, -1), Quaternion.identity);
            timeLeft = duration;

        }
		
	}

}
