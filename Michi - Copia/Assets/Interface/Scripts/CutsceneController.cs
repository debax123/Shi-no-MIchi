using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class CutsceneController : MonoBehaviour
{   
    public float TransitionTime;
    public Image[] cutscenes;
    int currentCutscene;

    void Start()
    {
        currentCutscene = 0;
        /*for (int i = 0; i < cutscenes.Length; i++)
        {
            ChangeAlpha(cutscenes[i].gameObject, 0, 0);
        }*/
        StartCoroutine(NextCutscene(TransitionTime));
    }


  
    void ChangeAlpha(GameObject canvasGroupObj, float alphaValue, float duration, bool blockRayCast = true)
    {
        canvasGroupObj.GetComponent<CanvasGroup>().DOFade(alphaValue, duration);
        canvasGroupObj.GetComponent<CanvasGroup>().blocksRaycasts = blockRayCast;

    }

    IEnumerator NextCutscene(float transitionTime)
    {
        //yield return new WaitForSeconds(transitionTime);
        //ChangeAlpha(cutscenes[0].gameObject, 1, transitionTime);

        //yield return new WaitForSeconds(transitionTime);
        //ChangeAlpha(cutscenes[1].gameObject, 1, transitionTime);

        //yield return new WaitForSeconds(transitionTime);
        //ChangeAlpha(cutscenes[2].gameObject, 1, transitionTime);

        //yield return new WaitForSeconds(transitionTime);
        //ChangeAlpha(cutscenes[3].gameObject, 1, transitionTime);

        //yield return new WaitForSeconds(transitionTime);
        //ChangeAlpha(cutscenes[4].gameObject, 1, transitionTime);

        //yield return new WaitForSeconds(transitionTime);
        //ChangeAlpha(cutscenes[5].gameObject, 1, transitionTime);

        //yield return new WaitForSeconds(transitionTime);
        //ChangeAlpha(cutscenes[6].gameObject, 1, transitionTime);

        //yield return new WaitForSeconds(transitionTime);
        //ChangeAlpha(cutscenes[8].gameObject, 1, transitionTime);

        //yield return new WaitForSeconds(transitionTime);
        //ChangeAlpha(cutscenes[9].gameObject, 1, transitionTime);

        //yield return new WaitForSeconds(transitionTime);
        //ChangeAlpha(cutscenes[10].gameObject, 1, transitionTime);

        //yield return new WaitForSeconds(transitionTime);
        //ChangeAlpha(cutscenes[11].gameObject, 1, transitionTime);

        //yield return new WaitForSeconds(transitionTime);
        //ChangeAlpha(cutscenes[12].gameObject, 1, transitionTime);

        //yield return new WaitForSeconds(transitionTime);
        //ChangeAlpha(cutscenes[13].gameObject, 1, transitionTime);

        //StartCoroutine(ChangeScene("Main Level"));


        while (currentCutscene < cutscenes.Length)
        {
            //ChangeAlpha(cutscenes[currentCutscene].gameObject, 0, transitionTime);
            currentCutscene++;
            yield return new WaitForSeconds(transitionTime);

            if (currentCutscene < cutscenes.Length)
            {

                ChangeAlpha(cutscenes[currentCutscene].gameObject, 1, transitionTime);
            }
            else
            {
            }
        }
        StartCoroutine(ChangeScene("Main Level"));

    }

    IEnumerator ChangeScene(string sceneName)
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(sceneName);

    }

}
