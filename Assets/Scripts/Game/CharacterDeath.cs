using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterDeath : MonoBehaviour
{
    private Attributes playerAttributes;
    public GameObject playerDeathScreen;

    private float _playerHealth;
    // Start is called before the first frame update
    void Start()
    {
        playerAttributes = GameObject.FindGameObjectWithTag("Player").GetComponent<Attributes>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerAttributes == null)
        {
            if (playerDeathScreen.activeInHierarchy == true)
            {
                return;
            }
            playerDeathScreen.SetActive(true);
        }
    }
}
