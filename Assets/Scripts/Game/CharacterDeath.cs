using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterDeath : MonoBehaviour
{
    public GameObject playerAttributes;
    public GameObject playerDeathScreen;

    private float _playerHealth;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerAttributes.GetComponent<Attributes>().currentHealth <= 0)
        {
            if (playerDeathScreen.activeInHierarchy == true)
            {
                return;
            }
            playerDeathScreen.SetActive(true);
        }
    }
}
