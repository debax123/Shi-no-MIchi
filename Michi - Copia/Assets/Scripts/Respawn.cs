using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Respawn : MonoBehaviour
{
    public CharacterController charac;
    public Image fade;
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;


    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player")) 
        {
            StartCoroutine(RespawnRoutine());
        }
    }

    private IEnumerator RespawnRoutine()
    {
        yield return new WaitForSeconds(0.2f);
        charac.enabled = false;
        Color cor = fade.color;

        yield return new WaitForSeconds(1);

        while (cor.a < 1)
        {
            cor.a += Time.deltaTime;
            fade.color = cor;
            yield return null;
        }

        player.transform.position = respawnPoint.transform.position;
        Physics.SyncTransforms();

        yield return new WaitForSeconds(1);

        while (cor.a > 0)
        {
            cor.a -= Time.deltaTime;
            fade.color = cor;
            yield return null;
        }

        charac.enabled = true;
    }
}
