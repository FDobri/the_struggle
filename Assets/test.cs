using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public GameObject sex;
    public float tajm = 10;
    int plejo;
    Animator sexa;

    // Start is called before the first frame update
    void Start()
    {
        sexa = sex.GetComponent<Animator>();            
    }

    public void krenipremameni()
    {
        sexa.SetTrigger("hjao");
        print("hjao");
    }

    // Update is called once per frame
    void Update()
    {
        tajm -= Time.deltaTime;
        if (tajm <= 0)
        {
            krenipremameni();
            print("krenuo");
        }
    }
}
