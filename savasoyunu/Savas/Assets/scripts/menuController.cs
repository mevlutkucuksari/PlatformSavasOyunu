using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuController : MonoBehaviour
{
    public void baslangicekrani() 
    {
        SceneManager.LoadScene(0); 
        Time.timeScale = 1;
    }
    public void level1() 
    {
        SceneManager.LoadScene(1); 
        Time.timeScale = 1;
    }
    public void level2()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1;
    }
    public void level3()
    {
        SceneManager.LoadScene(3);
        Time.timeScale = 1;
    }
    public void level4()
    {
        SceneManager.LoadScene(4); 
        Time.timeScale = 1;
    }
    public void level5() 
    {
        SceneManager.LoadScene(5); 
        Time.timeScale = 1;
    }
    public void level6() 
    {
        SceneManager.LoadScene(6);
        Time.timeScale = 1;
    }
    public void level7()
    {
        SceneManager.LoadScene(7);
        Time.timeScale = 1;
    }
    public void level8()
    {
        SceneManager.LoadScene(8);
        Time.timeScale = 1;
    }
    public void level9()
    {
        SceneManager.LoadScene(9);
        Time.timeScale = 1;
    }
    public void level10()
    {
        SceneManager.LoadScene(10);
        Time.timeScale = 1;
    }
    public void levelson()
    {
        SceneManager.LoadScene(11);
        Time.timeScale = 1;
    }
    public void quit() 
    {
        Application.Quit();
    }

}
