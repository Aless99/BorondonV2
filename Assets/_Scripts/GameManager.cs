using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;
    [SerializeField]

    public GameObject grimorio;

    private bool grimorioActive;

    public bool GrimorioActive { get => grimorioActive; set => grimorioActive = value; }

    void Update()
    {

        if (!GameObject.Find("CanvasAgenda(Clone)") && grimorioActive == true)
        {
            if (Input.GetKeyDown(KeyCode.G))
            {
                Debug.Log("Grimorio");
                Instantiate(grimorio);
            }

        }

        if (GameObject.Find("CanvasAgenda(Clone)") && grimorioActive==true)
        {
            if (Input.GetKey(KeyCode.Escape))
            {

                Debug.Log("Grimorio Dell");

                Destroy(GameObject.FindWithTag("Grimorio"));


            }

        }


    }
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void InGame()
    {
        SceneManager.LoadScene("Game");
    }


    public void GameOver()
    {
        SceneManager.LoadScene("Dead");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

}