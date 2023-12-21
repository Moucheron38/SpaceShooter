using System.Collections;
using System.Collections.Generic;
using System.Drawing;
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

    public static GameObject GetInstance(GameObject prefab)
    {
        List<GameObject> tempList = instance.GetInstanceList(prefab);

        GameObject GOinst = instance.GetUseablePrefabInstance(prefab, tempList);

        GOinst.SetActive(true);

        return GOinst;
    }


    private List<GameObject> GetInstanceList(GameObject prefab)
    {
        List<GameObject> _tempList;
        dico.TryGetValue(prefab, out _tempList);

        if (_tempList == null)
        {
            _tempList = new List<GameObject>();
            instance.dico.Add(prefab, _tempList);
        }

        return _tempList;
    }


    private GameObject GetUseablePrefabInstance(GameObject prefab, List<GameObject> _instancesList)
    {
        foreach (var GO in _instancesList)
        {
            if (GO.activeSelf) continue;

            return GO;
        }


        GameObject GOinst = Instantiate(prefab);
        _instancesList.Add(GOinst);
        GOinst.SetActive(false);

        return GOinst;
    }
}
