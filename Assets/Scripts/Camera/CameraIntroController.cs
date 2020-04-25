using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;

public class CameraIntroController : MonoBehaviour
{
    public GameObject TintImageGameObject;
    public float TintAlphaDelineSpeed = 0.01f;

    void Start()
    {
        Assert.IsNotNull(TintImageGameObject, "Tint Image Game Object must be set in editor");
    }

    void Update()
    {
        Image i = TintImageGameObject.GetComponent<Image>();
        Color imageColor = i.color;
        imageColor.a -= TintAlphaDelineSpeed * Time.deltaTime;
        i.color = imageColor;
        if (imageColor.a < 0.01f)
        {
            Destroy(gameObject);
        }
    }
}
