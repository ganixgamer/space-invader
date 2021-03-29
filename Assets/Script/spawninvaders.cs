using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawninvaders : MonoBehaviour
{
    [SerializeField]
    GameObject InvaderA;

    [SerializeField]
    GameObject InvaderB;

    [SerializeField]
    GameObject InvaderC;

    [SerializeField]
    int nInvadors = 7;

    [SerializeField]
    float Xmin = -3f;

    void Awake()
    {

        float x1 = Xmin;
        for(int i=1; i <=nInvadors; i++)
        {
            GameObject newInvader = Instantiate(InvaderA, transform);
            newInvader.transform.position = new Vector3(x1, -0.80f, 0f);
            x1 += 1f;
        }

        float x2 = Xmin;
        for (int i = 1; i <= nInvadors; i++)
        {
            GameObject newInvader = Instantiate(InvaderA, transform);
            newInvader.transform.position = new Vector3(x2, -0.1f, 0f);
            x2 += 1f;
        }
        
        float x = Xmin;
        for (int i = 1; i <= nInvadors; i++)
        {
            GameObject newInvader = Instantiate(InvaderB, transform);
            newInvader.transform.position = new Vector3(x, 1.3f, 0f);
            x += 1f;
        }

        float x22 = Xmin;
        for (int i = 1; i <= nInvadors; i++)
        {
            GameObject newInvader = Instantiate(InvaderB, transform);
            newInvader.transform.position = new Vector3(x22, 0.60f, 0f);
            x22 += 1f;
        }
        
        float x3 = Xmin;
        for (int i = 1; i <= nInvadors; i++)
        {
            GameObject newInvader = Instantiate(InvaderC, transform);
            newInvader.transform.position = new Vector3(x3, 2f, 0f);
            x3 += 1f;
        }

    }







}
