using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transition_Cam : MonoBehaviour
{

    [SerializeField]  GameObject[] cameraArray;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "trig1")
        {

            foreach (GameObject go in cameraArray)
            {
                Debug.Log("Hello");
                go.SetActive(false);
                cameraArray[0].SetActive(true);
            }
        }

        if (other.gameObject.tag == "trig2")
        {

            foreach (GameObject go in cameraArray)
            {
                Debug.Log("Hello45154");
                go.SetActive(false);
                cameraArray[1].SetActive(true);
            }
        }
    }
}
