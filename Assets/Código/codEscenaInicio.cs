using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class codEscenaInicio : MonoBehaviour
{

    public GameObject canvasMenu;


    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Jugar()
    {
        SceneManager.LoadScene(1);
    }

    public void Info()
    {
        SceneManager.LoadScene(2);
    }

    public void Creditos()
    {
        SceneManager.LoadScene(3);
    }
}
