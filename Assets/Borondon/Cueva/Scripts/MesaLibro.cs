using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MesaLibro : MonoBehaviour
{

    public GameObject player;
    public GameObject panelMensaje;
    public GameObject libro;
    public GameObject ligthMision;
    public GameObject Charla;
    public GameObject boxCharla;

    public GameObject grimorio;

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

            if (GameObject.Find("libro"))
            {
                GameObject.Find("TextMensaje").GetComponent<Text>().text = textoDeAccion;

            }


           

        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject == player)
        {
            if (Input.GetKey(KeyCode.Alpha0)&&GameObject.Find("libro"))
            {
                Debug.Log("0");

                Destroy(ligthMision);
                Destroy(boxCharla);

                Charla.SetActive(false);

                GameObject.Find("TextMensaje").GetComponent<Text>().text = "“Has obtenido el grimorio! Para abrirlo pulsa G";

                GameObject.Find("GameManager").GetComponent<GameManager>().GrimorioActive=true;

                Destroy(libro);


            }





        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
        {
            Debug.Log("Salida");


            panelMensaje.SetActive(false);


          


        }
    }
}
