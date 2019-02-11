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

                go.SetActive(false);
                cameraArray[0].SetActive(true);
            }
        }

        if (other.gameObject.tag == "trig2")
        {

            foreach (GameObject go in cameraArray)
            {

                go.SetActive(false);
                cameraArray[1].SetActive(true);
            }
        }

        if (other.gameObject.tag == "trig3")
        {

            foreach (GameObject go in cameraArray)
            {

                go.SetActive(false);
                cameraArray[2].SetActive(true);
            }
        }

        if (other.gameObject.tag == "trig4")
        {

            foreach (GameObject go in cameraArray)
            {

                go.SetActive(false);
                cameraArray[3].SetActive(true);
            }
        }

        if (other.gameObject.tag == "trig5")
        {

            foreach (GameObject go in cameraArray)
            {

                go.SetActive(false);
                cameraArray[4].SetActive(true);
            }
        }

        if (other.gameObject.tag == "trig6")
        {

            foreach (GameObject go in cameraArray)
            {

                go.SetActive(false);
                cameraArray[5].SetActive(true);
            }
        }

        if (other.gameObject.tag == "trig7")
        {

            foreach (GameObject go in cameraArray)
            {

                go.SetActive(false);
                cameraArray[6].SetActive(true);
            }
        }

        if (other.gameObject.tag == "trig8")
        {

            foreach (GameObject go in cameraArray)
            {

                go.SetActive(false);
                cameraArray[7].SetActive(true);
            }
        }

        if (other.gameObject.tag == "trig9")
        {

            foreach (GameObject go in cameraArray)
            {

                go.SetActive(false);
                cameraArray[8].SetActive(true);
            }
        }

        if (other.gameObject.tag == "trig10")
        {

            foreach (GameObject go in cameraArray)
            {

                go.SetActive(false);
                cameraArray[9].SetActive(true);
            }
        }

        if (other.gameObject.tag == "trig11")
        {

            foreach (GameObject go in cameraArray)
            {

                go.SetActive(false);
                cameraArray[10].SetActive(true);
            }
        }

        if (other.gameObject.tag == "trig12")
        {

            foreach (GameObject go in cameraArray)
            {

                go.SetActive(false);
                cameraArray[11].SetActive(true);
            }
        }
    }
}
