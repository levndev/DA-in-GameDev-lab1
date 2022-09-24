using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeSpawner : MonoBehaviour
{
    public GameObject SpawnedObject;
    public Button SpawnButton;
    public TMPro.TMP_InputField AmountInputField;
    public float SpawnInterval = 1;
    private float TimeAccumulator;
    private int SpawnAmount = 0;
    // Start is called before the first frame update
    void Start()
    {
        SpawnButton.onClick.AddListener(SpawnButtonClick);
    }

    // Update is called once per frame
    void Update()
    {
        TimeAccumulator += Time.deltaTime;
        if (SpawnAmount > 0 && TimeAccumulator > SpawnInterval)
        {
            TimeAccumulator = 0;
            var obj = Instantiate(SpawnedObject);
            obj.transform.position = transform.position;
            SpawnAmount -= 1;
        }
    }

    public void SpawnButtonClick()
    {
        SpawnAmount = int.Parse(AmountInputField.text);
    }
}
