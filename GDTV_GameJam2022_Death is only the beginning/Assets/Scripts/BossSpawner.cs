using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BossSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] bossPrefab;
    [SerializeField] GameObject textComponent;
    [SerializeField] GameObject introDialogue;

    Dialogue dialogue;
    GameObject boss;
    public int bossWaveCount = 0;
    public bool bossIsActive;


    // Start is called before the first frame update
    void Start()
    {
        dialogue = FindObjectOfType<Dialogue>();
        SpawnBoss(bossWaveCount);
    }

    // Update is called once per frame
    void Update()
    {
        if (boss == null)
        {
            bossIsActive = false;
            dialogue.dialogueEnded = false;
            introDialogue.gameObject.SetActive(false);
            textComponent.gameObject.SetActive(true);
        }

        //if (bossWaveCount <= bossPrefab.Length && boss == null)
        //{
        //    SpawnBoss(bossWaveCount);
        //}
    }

    public void SpawnBoss(int index)
    {
        boss = Instantiate(bossPrefab[bossWaveCount], new Vector2(0, 11f), Quaternion.identity);
        bossIsActive = true;
    }



}
