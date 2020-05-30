using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseController : MonoBehaviour
{
    public GameObject botoes;
    public GameObject pause;

    public AudioSource menuAudioSource;
    public Slider generalSoundSlider;
    public Slider soundEffectsSlider;

    public GameObject popupCtrl;
    public GameObject popupConfig;

    public Button Resume;
    GameManager gameManager;

    public AudioSource buttonSoundAudioSource;

    void Start()
    {
        Resume.onClick.AddListener(Voltar);
        gameManager = GameObject.FindObjectOfType<GameManager>();
    }

    public void Voltar()
    {
        gameManager.Resume();
    }

    public void Controles()
    {
        botoes.SetActive(false);
        pause.SetActive(false);
        popupCtrl.SetActive(true);
    }

    public void BackControles()
    {
        popupCtrl.SetActive(false);
        botoes.SetActive(true);
        pause.SetActive(true);
    }

    public void Configuracoes()
    {
        botoes.SetActive(false);
        pause.SetActive(false);
        popupConfig.SetActive(true);
    }


    public void BackConfiguracoes()
    {
        popupConfig.SetActive(false);
        botoes.SetActive(true);
        pause.SetActive(true);
    }

    public void Sair()
    {
        gameManager.Resume();
        SceneManager.LoadScene("Menu");
    }

    public void ChangeGeneralSoundVOL(float volume)
    {

    }

    public void ChangeEffectsSoundsVOL(float volume)
    {

    }

    public void PlayButtonClickSound()
    {
        buttonSoundAudioSource.PlayOneShot(buttonSoundAudioSource.clip);
    }
 
}
