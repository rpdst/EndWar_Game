using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public enum Gem
{
    Copper,
    Iron,
    Gold
}

public class ItemManager : MonoBehaviour
{
    private List<int> gems;

    public TextMeshProUGUI[] gemTexts;

    public Sprite[] gemSprs;

    void Start()    //When Starts, be Init
    {
        Init();
    }

    void Init()     //아이템 매니저 초기화
    {
        gems = new List<int>();

        gems.Add(0);
        gems.Add(0);
        gems.Add(0);
    }

    public void AddGem(Gem gem, int cnt, GameObject fText)    //광물 추가, 텍스트 반영
    {
        int gemIdx = (int)gem;
        gems[gemIdx] += cnt;
        gemTexts[gemIdx].text = gems[gemIdx].ToString();
        fText.GetComponentInChildren<SpriteRenderer>().sprite = gemSprs[gemIdx];
        fText.GetComponentInChildren<TextMeshPro>().text = "+ " + cnt;
        string str = string.Format("{0}가 {1}만큼 증가, 총 개수 : {2}", gem.ToString(), cnt, gems[gemIdx]);
        Debug.Log(str);
    }

    void Update()
    {
        
    }
}
