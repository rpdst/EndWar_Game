using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FloatText : MonoBehaviour
{
    ObjPool pool;
    SpriteRenderer spr;
    TextMeshPro text;

    float alpha = 1f;
    public float alphaTimeDiv = 0.1f;

    void Start()
    {
        spr = GetComponentInChildren<SpriteRenderer>();
        text = GetComponentInChildren<TextMeshPro>();
    }

    public void SetPool(ObjPool pool) => this.pool = pool;

    private void OnEnable()
    {
        alpha = 1f;
    }

    void Update()
    {
        alpha -= Time.deltaTime * alphaTimeDiv;
        spr.color = new Color(spr.color.r, spr.color.g, spr.color.b, alpha);
        text.color = new Color(text.color.r, text.color.g, text.color.b, alpha);

        if (alpha <= 0f)
            gameObject.SetActive(false);
    }

    private void OnDisable()
    {
        pool.RestoreObj(gameObject);
    }
}
