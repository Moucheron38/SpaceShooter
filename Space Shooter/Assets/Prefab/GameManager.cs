using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] private int life;


    [SerializeField]

    private GameObject GameOverGO;

    [SerializeField]

    private GameObject WinPanel;



    void Start()

    {
        
        GameOverGO.SetActive(false);
    }

    public static int LIFE
    {
        get
        {
            return instance.life;
        }
        set
        {
            instance.life = value;
            if (instance.life < 0)
            {
                instance.life = 0;
            }
            LifeHUD.UpdateHUD();
        }
    }

    private void Awake()
    {
        instance = this;
    }
    public void TakeDamage(int _damage)
    {
        life -= _damage;
        
    }

    public static void launchGameOver()
    {
        Time.timeScale = 0f;
        instance.GameOverGO.SetActive(true);

       
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");

    }

    public void LoadRestart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Jeu");

    }



    private void Update()
    {
        GameObject[] enemy = GameObject.FindGameObjectsWithTag("Enemy");
        if (enemy == null || enemy.Length == 0)
        {
            WinPanel.SetActive(true);
            

        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }





}
