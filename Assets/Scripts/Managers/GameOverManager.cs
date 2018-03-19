﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public PlayerHealth playerHealth;
	public float restartDelay = 5f;

	Animator anim;
	float restartTimer;

    void Awake()
    {
        anim = GetComponent<Animator>();
		restartTimer = 0f;
    }


    void Update()
    {
        if (playerHealth.currentHealth <= 0)
        {
            anim.SetTrigger("GameOver");
			restartTimer += Time.deltaTime;

			if (restartTimer >= restartDelay) {
				SceneManager.LoadScene (0);
			}
		}
    }
}