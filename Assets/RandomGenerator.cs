using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RandomGenerator : MonoBehaviour
{
    public GameObject Dove;
    public GameObject Hawk;
    public GameObject Food;
    private Vector3 Min;
    private Vector3 Max;
    private float _xAxis;
    private float _yAxis;
    private float _zAxis;
    private Vector3 _randomPosition;
    public bool _canInstantiate;

    public TextMeshProUGUI Hawks;
    public TextMeshProUGUI HawksPH;

    int NoHawks = 4;

    // Start is called before the first frame update
    void Start()
    {
        
        SetRange();
        for (int i = 0; i < 100; i++)
        {
            GenerateRandom();
            Instantiate(Dove, _randomPosition, Quaternion.identity);
        }

        for (int i = 0; i < NoHawks; i++)
        {
            GenerateRandom();
            Instantiate(Hawk, _randomPosition, Quaternion.identity);
        }

        for (int i = 0; i < 100; i++)
        {
            GenerateRandom();
            Instantiate(Food, _randomPosition, Quaternion.identity);
        }
        
       
        if (_canInstantiate)
        {
            //Instantiate(gameObject, _randomPosition, Quaternion.identity);
        }
    }

    private void SetRange() 
    {
        Min = new Vector3(-640, -495, 0);
        Max = new Vector3(640, 495, 0);
    }

    private void GenerateRandom()
    {
        _xAxis = UnityEngine.Random.Range(Min.x, Max.x);
        _yAxis = UnityEngine.Random.Range(Min.y, Max.y);
        _zAxis = UnityEngine.Random.Range(Min.z, Max.z);
        _randomPosition = new Vector3(_xAxis, _yAxis, _zAxis);

    }
    // Update is called once per frame
    void Update()
    {

       
    }
}
