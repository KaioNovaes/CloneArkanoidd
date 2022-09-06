using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int blocosNaFase;
    public AudioSource somDoBloco;

    void Update()
    { 
        if(Input.GetKeyDown(KeyCode.R))
        {
            ReiniciarPartida();
        }
    }    

    public void AdicionarBloco()
    {
        blocosNaFase += 1;
    }
    public void DescontarBloco()
    {
        blocosNaFase -= 1;
        somDoBloco.Play();
    }
    public void PassarDeFase()
    {
        if(SceneManager.GetActiveScene().buildIndex + 1 < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            SceneManager.LoadScene(0);
        }
    }

    private void ReiniciarPartida()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
