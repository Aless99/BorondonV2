using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CanvasMapa : MonoBehaviour
{
    private GameObject Camara;
    public GameObject cinemachine;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {

            this.gameObject.SetActive(false);

            cinemachine.SetActive(false);


        }


    }
}
