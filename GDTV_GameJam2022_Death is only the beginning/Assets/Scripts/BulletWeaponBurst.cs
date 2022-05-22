using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletWeaponBurst : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] GameObject[] firePointArray;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void BurstFire()
    {
        for (int j = 0; j < 3; j++)
        {
            for (int i = 0; i < firePointArray.Length; i++)
            {
                Instantiate(bulletPrefab, firePointArray[i].transform.position, Quaternion.identity);
            }
        }

    }
}
