using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Miner : MonoBehaviour, Job
{
    public Image progressBar;

    GameManager GM;

    public Animator rockAnim;

    public void Work()
    {
        Vector2 pos = transform.position;
        GameObject fText = GM.MI_M.mineTextPool.GetObj_With_SetPos(pos);

        rockAnim.SetTrigger("Shake");

        Gem rndGem = (Gem)Random.Range(0, 3);
        int gemCnt = Random.Range(1, 4);

        GM.IT_M.AddGem(rndGem, gemCnt, fText);
    }

    void Start()
    {
        GM = GameManager.GetInstance();
    }

    void Update()
    {
        
    }
}
