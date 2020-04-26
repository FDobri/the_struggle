using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attributes : MonoBehaviour
{
	public int maximumHealth = 100;
	public int currentHealth;

	public int damage = 40;
	
    void Start()
    {
		currentHealth = maximumHealth;
    }

	public void TakeDamage(int amount)
	{
		currentHealth -= amount;
		if (currentHealth <= 0f)
		{
			//death anim or whatever
			Destroy(gameObject);
			Debug.Log("You have died window appeared!");
		}
	}
}
