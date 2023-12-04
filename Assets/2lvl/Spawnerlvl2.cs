using System.Collections.Generic;
using System;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine;
using System.Collections;
using System.Linq;
using UnityEditor;
using JetBrains.Annotations;

public class Spawnerlvl2 : MonoBehaviour
{
    [SerializeField]
    GameObject theEnemy;

    [SerializeField]
    GameObject finish;

    [SerializeField]
    GameObject coin;

    [SerializeField]
    int lvl1;

    public float xPos;
    public float zPos;
    public float aPos;
    public float qPos;
    public float cPos;
    public float oPos;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemyDrop());
    }

    public List<int> coiny = new List<int>();
    int i = 10;
    int pocetcyklu = 0;

    IEnumerator EnemyDrop()
    {

        while (lvl1 < i)
        {
            xPos = UnityEngine.Random.Range(-12.8f, 12.8f);
            zPos = UnityEngine.Random.Range(-12.2f, 1.72f);
            aPos = UnityEngine.Random.Range(-12.8f, 12.8f);
            qPos = UnityEngine.Random.Range(-12.2f, 1.72f);
            cPos = UnityEngine.Random.Range(-12.8f, 12.8f);
            oPos = UnityEngine.Random.Range(-12.2f, 1.72f);


            if (pocetcyklu < 5)
            {
                Instantiate(theEnemy, new Vector3(xPos, 1, zPos), Quaternion.identity);
                yield return new WaitForSeconds(0.1f);
            }
            if (pocetcyklu < 2)
            {
                Instantiate(finish, new Vector3(aPos, 1, qPos), Quaternion.identity);
                yield return new WaitForSeconds(0.1f);
            }

            if (pocetcyklu < 1)
            {
                Instantiate(coin, new Vector3(cPos, 1, oPos), Quaternion.identity);
                yield return new WaitForSeconds(0.1f);
            }
            for (int i = 0; i < 1; i++)
            {
                pocetcyklu++;
            }

            lvl1 += 3;
        }

    }
}
