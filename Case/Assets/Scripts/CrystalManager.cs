using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class CrystalManager : MonoBehaviour
{

    [SerializeField] CrystalSpawner cs;

    public int totalCrystal;

    [SerializeField] TMP_Text crystalText;

    void Start()
    {
        
    }


    void Update()
    {
        crystalText.text = "Crystal:"+ totalCrystal.ToString();
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Crystal")
        {
            cs.currentCrystalInMap--;
            cs.SpawnNewCrystal();
            totalCrystal += 10;
            other.gameObject.SetActive(false);
            if(totalCrystal >= 100)
            {
                SceneManager.LoadScene(2);
            }
        }
    }
}
