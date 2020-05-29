using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Transform player;
    public Transform respawn1;
    public Transform respawn2;

    public static bool isPaused = false;

    public GameObject pauseMenuUI;

    public static int currentFish;
    public static int currentSouls;

    public Text fishText;
    public Text soulsText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            if(isPaused)
            {
                Resume();
            } else
            {
                Pause();
            }
        }
        if(Input.GetKeyDown(KeyCode.F1))
        {
            AddFish(1);
        }
        if (Input.GetKeyDown(KeyCode.F2))
        {
            AddSoul(1);
        }
        if(Input.GetKeyDown(KeyCode.F3))
        {
            player.transform.position = respawn1.transform.position;
        }
        if (Input.GetKeyDown(KeyCode.F4))
        {
            player.transform.position = respawn2.transform.position;
        }
    }

    public void AddFish(int fishToAdd)
    {
        currentFish += fishToAdd;
        fishText.text = "Fishes Collected:" + currentFish;
    }
    public void AddSoul(int soulToAdd)
    {
        currentSouls += soulToAdd;
        soulsText.text = "Souls Saved:" + currentSouls;
    }

    void Resume()
    {
        CameraController.rotateSpeed = 5;
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Pause()
    {
        CameraController.rotateSpeed = 0;
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
        Cursor.lockState = CursorLockMode.None;
    }

}
