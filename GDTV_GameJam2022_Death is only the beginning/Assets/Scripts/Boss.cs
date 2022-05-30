using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    BulletWeapon bulletWeapon;
    BulletWeaponBurst bulletWeaponBurst;
    GuidedMissileWeapon guidedMissileWeapon;
    Dialogue dialogue;

    private void Start()
    {
        bulletWeapon = FindObjectOfType<BulletWeapon>();
        bulletWeaponBurst = FindObjectOfType<BulletWeaponBurst>();
        guidedMissileWeapon = FindObjectOfType<GuidedMissileWeapon>();
        dialogue = FindObjectOfType<Dialogue>();
    }

    private void Update()
    {
        if (dialogue.dialogueEnded == true)
        {
            bulletWeapon.Fire();
            bulletWeaponBurst.Fire();
            guidedMissileWeapon.Fire();

        }

    }


}
