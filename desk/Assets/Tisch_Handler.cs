using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Tisch_Handler : MonoBehaviour
{
    public Material material;
    public GameObject[] tischplatten;
    public TMP_Dropdown[] dropdowns;

    public Transform[] tischbeine;
    private Vector3 beinpositionen;

    public double Preis;
    public double[] preis_variante;
    public double[] preis_groesse;
    public double[] preis_farbe;

    private int index_variante;
    private int index_groesse;
    private int index_farbe;

    public TMP_Text Preisausgabe; 



    // Start is called before the first frame update
    void Start()
    {
        Dropdown_Variante();
        Dropdown_Groesse();
        Dropdown_Farbe();
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void Dropdown_Variante()
    {
        switch (dropdowns[0].value)
        {
            case 0:
                tischplatten[0].SetActive(true);
                tischplatten[1].SetActive(false);
                break;
            case 1:
                tischplatten[0].SetActive(false);
                tischplatten[1].SetActive(true);
                break;
        }
        index_variante = dropdowns[0].value;
        Preisberechnung();
    }
    public void Dropdown_Groesse()
    {
        switch (dropdowns[1].value)
        {
            case 0:
                tischplatten[0].transform.localScale = new Vector3(1,1,1);
                tischplatten[1].transform.localScale = new Vector3(1,1,1);

                tischbeine[0].localPosition = new Vector3(0,0,0);
                tischbeine[1].localPosition = new Vector3(0,0,0);
                tischbeine[2].localPosition = new Vector3(0,0,0);
                tischbeine[3].localPosition = new Vector3(0,0,0);

                break;
            case 1:
                tischplatten[0].transform.localScale = new Vector3(2, 1, 1);
                tischplatten[1].transform.localScale = new Vector3(2, 1, 1);

                tischbeine[0].localPosition = new Vector3(1, 0, 0);
                tischbeine[1].localPosition = new Vector3(-1, 0, 0);
                tischbeine[2].localPosition = new Vector3(1, 0, 0);
                tischbeine[3].localPosition = new Vector3(-1, 0, 0);
                break;
            case 2:
                tischplatten[0].transform.localScale = new Vector3(2, 2, 1);
                tischplatten[1].transform.localScale = new Vector3(2, 2, 1);

                tischbeine[0].localPosition = new Vector3(1, 0, 1);
                tischbeine[1].localPosition = new Vector3(-1, 0, 1);
                tischbeine[2].localPosition = new Vector3(1, 0, -1);
                tischbeine[3].localPosition = new Vector3(-1, 0, -1);
                break;
        }
        index_groesse = dropdowns[1].value;
        Preisberechnung();
    }
    public void Dropdown_Farbe()
    {
        switch (dropdowns[2].value)
        {
            case 0:
                material.color = Color.black;
                break;
            case 1:
                material.color = Color.white;
                break;
            case 2:
                material.color = Color.gray;
                break;
        }
        index_farbe = dropdowns[2].value;
        Preisberechnung();
    }
    public void Preisberechnung()
    {
        Preis = 100 +  
            preis_variante[index_variante] +
            preis_groesse[index_groesse]+
            preis_farbe[index_farbe];
        Preisausgabe.text = $"Preis: {Preis}";
    }
}

