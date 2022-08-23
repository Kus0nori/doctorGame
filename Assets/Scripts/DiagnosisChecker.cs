using TMPro;
using UnityEngine;

public class DiagnosisChecker : MonoBehaviour
{
    private DiseaseGenerator _diseaseGenerator;
    private Illness _currDisease;
    public TMP_InputField diagnosisInputField;
    private string _diagnosisText;
    private void Start()
    {
        _diagnosisText = "ничего";
        _diseaseGenerator = GetComponent<DiseaseGenerator>();
        _currDisease = _diseaseGenerator.currentDisease;
        
    }

    public void CheckDiagnosis()
    {
        _diagnosisText = diagnosisInputField.text;
        Debug.Log(_diagnosisText == _currDisease.illnessName ? "Правильный диагноз!" : "Неверный диагноз...");
    }
}
