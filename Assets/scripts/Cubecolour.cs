using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubecolour : MonoBehaviour
{

    public GameObject cubeplayer;
    private int x = 0;
    private Renderer cubeRenderer;


    //Create a new cube primitive to set the color on
    //GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
    private void Start()
    {
        cubeRenderer = cubeplayer.GetComponent<Renderer>();
        StartCoroutine("colorchanger");
    }
    IEnumerator colorchanger()
    {

        x = Random.Range(0, 8);
        if (x == 0)
        {
            cubeRenderer.material.SetColor("_Color", Color.red);
        }
        if (x == 1)
        {
            cubeRenderer.material.SetColor("_Color", Color.white);
        }
        if (x == 2)
        {
            cubeRenderer.material.SetColor("_Color", Color.green);

        }
        if (x == 3)
        {
            cubeRenderer.material.SetColor("_Color", Color.yellow);
        }
        if (x == 4)
        {
            cubeRenderer.material.SetColor("_Color", Color.blue);

        }
        if (x == 5)
        {
            cubeRenderer.material.SetColor("_Color", Color.black);
        }
        if (x == 6)
        {
            cubeRenderer.material.SetColor("_Color", Color.magenta);

        }
        if (x == 7)
        {
            cubeRenderer.material.SetColor("_Color", Color.cyan);

        }


        yield return new WaitForSeconds(2);
        StartCoroutine("colorchanger");
    }

}