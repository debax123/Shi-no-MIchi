using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TransportToCemitery : MonoBehaviour
{
    public Transform Area1;
    public Transform Area2;
    public Transform Area3;
    public CharacterController charac;
    public Image fade;
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            player.transform.position = Area1.transform.position;
            Physics.SyncTransforms();
        }
        if (Input.GetKeyDown(KeyCode.F2))
        {
            player.transform.position = Area2.transform.position;
            Physics.SyncTransforms();
        }
        if (Input.GetKeyDown(KeyCode.F3))
        {
            player.transform.position = Area3.transform.position;
            Physics.SyncTransforms();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(Transport());
        }
    }

    private IEnumerator Transport()
    {
        yield return new WaitForSeconds(0.1f);
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
