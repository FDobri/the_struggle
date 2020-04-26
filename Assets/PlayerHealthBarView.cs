using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthBarView : MonoBehaviour
{
    public Attributes playerAttributes;

    int prevPlayerHP;

    void Start()
    {
        prevPlayerHP = playerAttributes.currentHealth;
        // TODO: get iz scene, kao i kamera
    }

    // Update is called once per frame
    void Update()
    {
        if (prevPlayerHP != playerAttributes.currentHealth)
        {
            prevPlayerHP = playerAttributes.currentHealth;
            Image i = gameObject.GetComponent<Image>();
            float fillAmount = (float)prevPlayerHP / 100.0f;
            i.fillAmount = fillAmount;
        }
    }
}
