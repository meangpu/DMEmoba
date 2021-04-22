using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public int ScoreMin;
    public int ScoreMax;


    [SerializeField] private Vector3 Min;
    [SerializeField] private  Vector3 Max;
    private float _xAxis;
    private float _yAxis;
    private float _zAxis;
    private Vector3 _randomPosition;
    public float scaleFactor = 5;

    public float waitTime;

    private void Start() 
    {
        StartCoroutine(SpawnEnemy());
    }

    private void RandomPos()
    {
        _xAxis = UnityEngine.Random.Range(Min.x, Max.x);
        _yAxis = UnityEngine.Random.Range(Min.y, Max.y);
        _zAxis = UnityEngine.Random.Range(Min.z, Max.z);
        _randomPosition = new Vector3(_xAxis, transform.position.y, _zAxis);
        // print(_randomPosition);
    }

    public IEnumerator SpawnEnemy()
    {
        RandomPos();
        int randomScore = UnityEngine.Random.Range(ScoreMin, ScoreMax);
        enemy.GetComponent<creep>().score = randomScore;
        // print(randomScore);

        enemy.transform.localScale = new Vector3(1 + (randomScore/scaleFactor), 1 + (randomScore/scaleFactor), 1 + (randomScore/scaleFactor));

        Instantiate(enemy, transform.position + _randomPosition , Quaternion.identity, transform);
        yield return new WaitForSeconds(waitTime);
        StartCoroutine(SpawnEnemy());
    }


}
