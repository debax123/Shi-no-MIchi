using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;
using UnityEngine.EventSystems;

public class MenuController : MonoBehaviour
{
    public GameObject controls;
    public GameObject config;
    public GameObject credits;
    public GameObject visual;
    public GameObject popup;
    public GameObject logoGameObj;
    public GameObject buttons;
    public AudioSource menuAudioSource;
    public Slider generalSoundSlider;
    public Slider menuSoundSlider;
    public Slider soundEffectsSlider;

    public GameObject soulsParticleSystem;

    public AudioSource buttonSoundAudioSource;
    

    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

        //menuSoundSlider.value = menuAudioSource.volume;

        //generalSoundSlider.value = menuAudioSource.volume;
        //soundEffectsSlider.value = menuAudioSource.volume;

    }

    public void StartGame()
    {
        StartCoroutine(ChangeScene("Cutscene Inicial"));
    }

    public void Controls()
    {
        ChangeAlpha(controls, 1, 0.7f);
        ChangeAlpha(credits, 0, 0.2f, false);
        ChangeAlpha(config, 0, 0.2f, false);
        ChangeAlpha(logoGameObj, 0, 0.2f, false);
        ChangeAlpha(buttons, 0, 0.2f, false);
        ChangePosition(popup, 0, 0.7f);
        ChangePosition(visual, -10, 0.7f);

        StartCoroutine(soulsParticleOFF());
    }

    public void BackCtrlMenu()
    {
        ChangeAlpha(controls, 0, 0.2f);
        ChangeAlpha(logoGameObj, 1, 0.5f);
        ChangeAlpha(buttons, 1, 0.5f);
        ChangePosition(popup, -1920, 0.5f);
        ChangePosition(visual, -1920, 0.5f);

        StartCoroutine(soulsParticleON());
    }

    public void Config()
    {
        ChangeAlpha(config, 1, 0.7f);
        ChangeAlpha(controls, 0, 0.2f, false);
        ChangeAlpha(credits, 0, 0.2f, false);
        ChangeAlpha(logoGameObj, 0, 0.2f, false);
        ChangeAlpha(buttons, 0, 0.2f, false);
        ChangePosition(popup, 0, 0.7f);
        ChangePosition(visual, -10, 0.7f);

        StartCoroutine(soulsParticleOFF());

    }

    public void BackConfigMenu()
    {
        ChangeAlpha(config, 0, 0.2f);
        ChangeAlpha(logoGameObj, 1, 0.5f);
        ChangeAlpha(buttons, 1, 0.5f);
        ChangePosition(popup, -1920, 0.5f);
        ChangePosition(visual, -1920, 0.5f);;

        StartCoroutine(soulsParticleON());

    }

    public void Credits()
    {
        ChangeAlpha(credits, 1, 0.7f);
        ChangeAlpha(controls, 0, 0.2f, false);
        ChangeAlpha(config, 0, 0.2f, false);
        ChangeAlpha(logoGameObj, 0, 0.2f, false);
        ChangeAlpha(buttons, 0, 0.2f, false);
        ChangePosition(popup, 0, 0.7f);
        ChangePosition(visual, -10, 0.7f);

        StartCoroutine(soulsParticleOFF());

    }

    public void BackCredMenu()
    {
        ChangeAlpha(credits, 0, 0.2f);
        ChangeAlpha(logoGameObj, 1, 0.5f);
        ChangeAlpha(buttons, 1, 0.5f);
        ChangePosition(popup, -1920, 0.5f);
        ChangePosition(visual, -1920, 0.5f);

        StartCoroutine(soulsParticleON());

    }

    public void Exit()
    {
        Application.Quit();
    }

    void ChangeAlpha(GameObject canvasGroupObj, float alphaValue, float duration, bool blockRayCast = true)
    {
        canvasGroupObj.GetComponent<CanvasGroup>().DOFade(alphaValue, duration);
        canvasGroupObj.GetComponent<CanvasGroup>().blocksRaycasts = blockRayCast;

    }

    void ChangePosition(GameObject rectTransformObj, float newPositionX, float duration)
    {
        rectTransformObj.GetComponent<RectTransform>().DOAnchorPosX(newPositionX, duration);
    }

    public void ChangeGeneralSoundVOL(float volume)
    {

    }

    public void ChangeEffectsSoundsVOL(float volume)
    {

    }

    public void ChangeMenuSoundVOL(float volume)
    {
        menuAudioSource.volume = volume;
    }

    public static IEnumerator ChangeScene(string sceneName)
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(sceneName);
    }

    public void PlayButtonClickSound()
    {
        buttonSoundAudioSource.PlayOneShot(buttonSoundAudioSource.clip);
    }

    IEnumerator soulsParticleON()
    {
        yield return new WaitForSeconds(0.5f);
        soulsParticleSystem.gameObject.SetActive(true);
    }

    IEnumerator soulsParticleOFF()
    {
        yield return new WaitForSeconds(0.2f);
        soulsParticleSystem.gameObject.SetActive(false);
    }
}
