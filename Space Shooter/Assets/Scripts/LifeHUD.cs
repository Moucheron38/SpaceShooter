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

    private void Update()
    {
        
    }

    public static void UpdateHUD()
    {
        int life = GameManager.LIFE;
        instance.transform.DetachChildren();
        instance.CreateIcons();

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
