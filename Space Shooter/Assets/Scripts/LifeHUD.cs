using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeHUD : MonoBehaviour
{
    public static LifeHUD instance;
    [SerializeField] GameObject lifePrefab;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        CreateIcons();
    }

    public static void UpdateHUD()
    {
        int life = GameManager.LIFE;
        Debug.Log("Life ="+life);
    }

    void CreateIcons()
    {
        for(int i = 0; i < GameManager.LIFE; i++)
        {
            GameObject inst = Instantiate(lifePrefab);
            inst.transform.SetParent(this.transform);
        }
    }
}
