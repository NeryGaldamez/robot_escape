using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class codEscenaCreditos : MonoBehaviour
{

    public GameObject canvasInfo;


    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void IrMenu()
    {
        SceneManager.LoadScene(0);
    }
}
