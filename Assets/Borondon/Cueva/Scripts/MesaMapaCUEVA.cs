using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MesaMapaCUEVA : MonoBehaviour
{

    public GameObject player;
    public GameObject panelMensaje;
    public GameObject canvasMapa;
    public GameObject cinemachine;

    public string textoDeAccion;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            Debug.Log("Entrada");



            panelMensaje.SetActive(true);

            GameObject.Find("TextMensaje").GetComponent<Text>().text = textoDeAccion;

           

        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject == player)
        {
            if (Input.GetKey(KeyCode.F)&&!GameObject.Find("CanvasMapa(Clone)"))
            {
                Debug.Log("F");


                canvasMapa.SetActive(true);
                cinemachine.SetActive(false);

            }

        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
        {
            Debug.Log("Salida");

            panelMensaje.SetActive(false);

            if (canvasMapa.activeSelf)
            {
                cinemachine.SetActive(true);

                canvasMapa.SetActive(false);

            }


        }
    }
}
