﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ResetControl : MonoBehaviour {

    bool gameOver = false;

	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Fire1") && gameOver)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    void GameOver()
    {
        gameOver = true;
    }
}
