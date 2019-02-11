using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTriggers : MonoBehaviour
{
    public GameObject[] Wave1;
    public GameObject[] Wave2;
    public GameObject[] Wave3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            for (int i = 0; i < Wave1.Length; i++)
            {
                Wave1[i].SetActive(true);
            }
            for (int i = 0; i < Wave2.Length; i++)
            {
                Wave2[i].SetActive(false);
            }
            for (int i = 0; i < Wave3.Length; i++)
            {
                Wave3[i].SetActive(false);
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            for (int i = 0; i < Wave1.Length; i++)
            {
                Wave1[i].SetActive(false);
            }
            for (int i = 0; i < Wave2.Length; i++)
            {
                Wave2[i].SetActive(true);
            }
            for (int i = 0; i < Wave3.Length; i++)
            {
                Wave3[i].SetActive(false);
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            for (int i = 0; i < Wave1.Length; i++)
            {
                Wave1[i].SetActive(false);
            }
            for (int i = 0; i < Wave2.Length; i++)
            {
                Wave2[i].SetActive(false);
            }
            for (int i = 0; i < Wave3.Length; i++)
            {
                Wave3[i].SetActive(true);
            }
        }
    }
}
