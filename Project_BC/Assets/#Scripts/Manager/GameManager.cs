using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager GM;
    public static GameManager GetInstance()
    {
        return GM;
    }

    //매니저들
    public CharacterManager CH_M;
    public ItemManager IT_M;
    public MineManager MI_M;

    void Awake()
    {
        GM = this;
    }

    void Update()
    {
        
    }
}
