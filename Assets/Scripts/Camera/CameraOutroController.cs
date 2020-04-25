using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;

public class CameraOutroController : MonoBehaviour
{
    public GameObject TintImageGameObject;
    public float TintAlphaIncreaseSpeed = 1f;

    void Start()
    {
        TintImageGameObject.SetActive(true);
    }

    void Update()
    {
        Image i = TintImageGameObject.GetComponent<Image>();
        Color imageColor = i.color;
        imageColor.a += TintAlphaIncreaseSpeed * Time.deltaTime;
        i.color = imageColor;
        if (imageColor.a > 1f)
        {
            //Destroy(gameObject);
        }
    }
}
