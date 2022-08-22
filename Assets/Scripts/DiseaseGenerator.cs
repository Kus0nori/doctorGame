using System;
using System.Collections.Generic;
using System.Globalization;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;
public class DiseaseGenerator : MonoBehaviour
{
    private int _diseaseID;
    public TextMeshProUGUI diseaseName;
    public TextMeshProUGUI temperature;
    public TextMeshProUGUI head;
    public TextMeshProUGUI throat;
    public TextMeshProUGUI lungs;
    public TextMeshProUGUI pressure;
    public List<Illness> illness;
    private Illness _currentDisease;
    private float _rawTemperature;
    private void Start()
    {
        SetDisease();
    }

    private void SetDisease()
    {
        _diseaseID = Random.Range(0, 7);
        _currentDisease = illness[_diseaseID];
        diseaseName.text = _currentDisease.illnessName;
        _rawTemperature = Random.Range(_currentDisease.minTemperature, _currentDisease.maxTemperature);
        temperature.text = Math.Round(_rawTemperature, 1).ToString();
        head.text = _currentDisease.headAche == true ? "болит" : "в порядке";
        lungs.text = _currentDisease.lungAche == true ? "проблемы" : "в порядке";
        throat.text = _currentDisease.throatAche == true ? "болит" : "в порядке";
        pressure.text = _currentDisease.pressure == true ? "высокое" : "в порядке";
    }
}
 