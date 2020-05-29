using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishPickups : MonoBehaviour
{
    public int value;
    public GameObject burst;
    public AudioSource source;
    public AudioClip collected;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            source.clip = collected;
            source.Play();
            FindObjectOfType<GameManager>().AddFish(value);
            Destroy(gameObject);
            Instantiate(burst, new Vector3(transform.position.x, transform.position.y +0.5f, transform.position.z), transform.rotation);
        }
    }

}
