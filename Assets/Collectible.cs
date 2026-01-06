using UnityEngine;

public class Collectible : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

         public float roationSpeed;

          public GameObject onCollectEffect;


    // Update is called once per frame
    void Update()
    {

        transform.Rotate(0, roationSpeed, 0);
        
    }

    private void OnTriggerEnter(Collider other) {

        if (other.CompareTag("Player"))s{
            //Destroy the collectilbe
            Destroy(gameObject);

            // instantiate the particle effect
            Instantiate(onCollectEffect, transform.position, transform.rotation);

        }

    }

    }
