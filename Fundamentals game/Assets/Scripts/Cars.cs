using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cars : MonoBehaviour
{
    public GameObject[] car1, car2, car3;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnCar());
    }

    private IEnumerator SpawnCar()
    {
        while(true){
            yield return new WaitForSeconds(1);
            Instantiate(car1[Random.Range(0, car1.Length)],transform.position,Quaternion.identity);
            Instantiate(car2[Random.Range(0, car2.Length)],transform.position,Quaternion.identity);
            Instantiate(car3[Random.Range(0, car3.Length)],transform.position,Quaternion.identity);
        }
    }
}
