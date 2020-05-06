using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARMgr : MonoBehaviour
{
    [SerializeField]
    GameObject coronaFull;
    [SerializeField]
    GameObject coronaDetail;

    [SerializeField]
    GameObject buttonFull;
    [SerializeField]
    GameObject buttonDetail;

    bool isFull = true;

    // Start is called before the first frame update
    void Start()
    {
        isFull = true;
        coronaFull.SetActive(isFull);
        buttonFull.SetActive(!isFull);

        coronaDetail.SetActive(!isFull);
        buttonDetail.SetActive(isFull);
    }

    public void SwitchFullDetail()
    {
        if (!isFull)
        {
            coronaFull.SetActive(true);
            buttonFull.SetActive(false);

            coronaDetail.SetActive(false);
            buttonDetail.SetActive(true);

            isFull = true;
            return;

        }
        else
        {
            coronaFull.SetActive(false);
            buttonFull.SetActive(true);

            coronaDetail.SetActive(true);
            buttonDetail.SetActive(false);

            isFull = false;
            return;
        }
    }

    
}
