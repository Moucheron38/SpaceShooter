using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] private int life;

    [SerializeField]

    private bool isGameOn;

    [SerializeField]

    private GameObject GameOverGO;

    void Start()

    {
        isGameOn = true;
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
        instance.isGameOn = false;
        instance.GameOverGO.SetActive(true);

        //Stopthegame
        Debug.Log("GameOver");
    }

    public static void launchRestart()
    {
        instance.isGameOn = true;
        instance.GameOverGO.SetActive(false);
        instance.GetComponent<PlayerControler>().enabled = true;

        //Restart
        Debug.Log("Restart");
    }

    public void OnRestart()
    {
        launchRestart();
    }


}
