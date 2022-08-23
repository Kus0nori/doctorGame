using System;
using System.Collections.Generic;
using System.Globalization;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using Random = UnityEngine.Random;
public class DiseaseGenerator : MonoBehaviour
{
    public int currDiseaseID;
    public TextMeshProUGUI diseaseName;
    public TextMeshProUGUI temperature;
    public TextMeshProUGUI head;
    public TextMeshProUGUI throat;
    public TextMeshProUGUI lungs;
    public TextMeshProUGUI pressure;
    public List<Illness> illness;
    public Illness currentDisease;
    private float _rawTemperature;
    
    private void Awake()
    {
        SetDisease();
    }

    private void SetDisease()
    {
        currDiseaseID = Random.Range(0, 7);
        currentDisease = illness[currDiseaseID];
        diseaseName.text = currentDisease.illnessName;
        _rawTemperature = Random.Range(currentDisease.minTemperature, currentDisease.maxTemperature);
        temperature.text = Math.Round(_rawTemperature, 1).ToString();
        head.text = currentDisease.headAche == true ? "болит" : "в порядке";
        lungs.text = currentDisease.lungAche == true ? "проблемы" : "в порядке";
        throat.text = currentDisease.throatAche == true ? "болит" : "в порядке";
        pressure.text = currentDisease.pressure == true ? "высокое" : "в порядке";
    }
}
 