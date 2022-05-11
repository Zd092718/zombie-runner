using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathHandler : MonoBehaviour
{
    [SerializeField] GameObject gameOverCanvas;

    private void Start()
    {
        gameOverCanvas = GameObject.FindGameObjectWithTag("GameOverUI");
        gameOverCanvas.GetComponent<Canvas>().enabled = false;
    }

    public void HandleDeath()
    {
        gameOverCanvas.GetComponent<Canvas>().enabled = true;
        Time.timeScale = 0;
        FindObjectOfType<WeaponSwitcher>().enabled = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
