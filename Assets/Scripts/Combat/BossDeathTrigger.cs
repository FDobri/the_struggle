using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossDeathTrigger : MonoBehaviour
{
    public GameObject BossObject;
    public GameObject portal;

    private bool isBossDead = false;
    
    void Start()
    {

    }
    
    void Update()
    {
        if (!isBossDead)
        {
            if (BossObject == null)
            {
                isBossDead = true;
                portal.SetActive(true);
            }
        }
    }
}
