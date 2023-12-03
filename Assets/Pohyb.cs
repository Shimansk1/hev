using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pohyb : MonoBehaviour
{
    [SerializeField] float moveSpeed;

    [SerializeField] int maxColect;
    public int colected;

    public Vector3 direction = Vector3.forward;


    void Start()
    {
        // Nastavení poèáteèní pozice hráèe
        transform.position = new Vector3(0, 0.4f, -10);
    }


    // Update is called once per frame
    void Update()
    {
        // Pohyb hráèe
        transform.position += direction * moveSpeed * Time.deltaTime;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("wall"))
        {
            if (direction == Vector3.forward)
            {
                direction = Vector3.right;

            }
            else if (direction == Vector3.right)
            {
                direction = Vector3.back;

            }
            else if (direction == Vector3.back)
            {
                direction = Vector3.left;

            }
            else
            {
                direction = Vector3.forward;

            }
        }
    }
}
