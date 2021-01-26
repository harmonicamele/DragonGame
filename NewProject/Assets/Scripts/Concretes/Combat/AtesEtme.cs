using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtesEtme : MonoBehaviour
{
    [SerializeField] FireballController prjectileprefab;
    [SerializeField] Transform atesPoziyonu;
    [SerializeField] float delayates = 1f;
    public void atesAction()
    {
        Instantiate(prjectileprefab,atesPoziyonu.position ,atesPoziyonu .rotation); 
    }

}
