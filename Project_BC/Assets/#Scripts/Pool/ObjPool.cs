using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjPool : MonoBehaviour
{
    public GameObject prefab;
    Queue<GameObject> pool;

    void Start()
    {
        pool = new Queue<GameObject>();    
    }

    public GameObject GetObj()
    {
        GameObject obj = null;

        if (pool.Count > 0)
        {
            obj = pool.Dequeue();
            obj.SetActive(true);
        }
        else
        {
            obj = Instantiate(prefab);
            obj.GetComponent<FloatText>().SetPool(this);
        }

        return obj;
    }

    public GameObject GetObj_With_SetPos(Vector2 pos)
    {
        GameObject obj = GetObj();

        obj.transform.position = pos;

        return obj;
    }

    public void RestoreObj(GameObject obj)
    {
        obj.SetActive(false);
        pool.Enqueue(obj);
    }
}
