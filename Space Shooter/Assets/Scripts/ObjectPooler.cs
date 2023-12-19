using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    public static ObjectPooler instance;
   
    public Dictionary<GameObject, List<GameObject>> dico;

    
    void Awake()
    {
        dico = new Dictionary<GameObject, List<GameObject>>();
        instance = this;
    }

  

    private List<GameObject> GetInstanceList(GameObject Prefab)
    {
        List<GameObject> TempList;
        dico.TryGetValue(Prefab, out TempList);

        return TempList;
    }

    public static GameObject GetInstance(GameObject Prefab)
    {
        List<GameObject> TempList = instance.GetInstanceList(Prefab);

        if (TempList == null)
        {
           TempList = new List<GameObject>();
            instance.dico.Add(Prefab, TempList);
        }

        GameObject GOinst = instance.TryGetInstance(Prefab);

        if (GOinst == null)
        {
            GOinst = Instantiate(Prefab);
            GOinst.SetActive(false);
            TempList.Add(GOinst);
        }

     

        GOinst.SetActive(true);
        return GOinst;
    }

    private GameObject TryGetInstance(GameObject Prefab)
    {
        List<GameObject> TempList;
        dico.TryGetValue(Prefab, out TempList);
        foreach(var GO in TempList)
        {
            if (GO.activeSelf) continue;

            return GO;
            
        }
        return null;
    }
}
