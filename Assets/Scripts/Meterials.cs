using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Meterials : MonoBehaviour
{
    public GameObject Barter;
    public GameObject Label;
    public string nameOfBarter;

    private void writeNametoLabel()
    {
        Label.GetComponent<Text>().text = nameOfBarter;
    }

    private void Start()
    {
        nameOfBarter = Barter.name;
        writeNametoLabel();
    }


}
