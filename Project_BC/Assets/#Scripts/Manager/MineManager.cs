using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineManager : MonoBehaviour
{
    GameManager GM;

    public readonly int maxMineTouch = 3;

    public ObjPool mineTextPool;

    void Start()
    {
        GM = GameManager.GetInstance();
    }

    void Update()
    {
        if(Input.touchCount > 0)
        {
            Touch[] touch = Input.touches;

            int maxTouch = touch.Length > maxMineTouch ? maxMineTouch : touch.Length;

            for(int i=0; i< maxTouch; i++)
            {
                if(touch[i].phase == TouchPhase.Began)
                {
                    Vector2 realPos = Camera.main.ScreenToWorldPoint(touch[i].position);
                    GameObject fText = mineTextPool.GetObj_With_SetPos(realPos);

                    Gem rndGem = (Gem) Random.Range(0, 3);
                    int gemCnt = Random.Range(1, 4);

                    GM.IT_M.AddGem(rndGem, gemCnt, fText);
                }
            }
        }
    }
}
