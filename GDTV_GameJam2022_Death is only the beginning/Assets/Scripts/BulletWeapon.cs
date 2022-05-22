using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletWeapon : MonoBehaviour
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

    public void Fire()
    {
        for (int i = 0; i < firePointArray.Length; i++)
        {
            Instantiate(bulletPrefab, firePointArray[i].transform.position, Quaternion.identity);
        }
    }

}
