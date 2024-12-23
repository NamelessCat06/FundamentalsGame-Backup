using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cars : MonoBehaviour
{
    public GameObject[] car1, car2, car3;
    public Vector3 carspawn1;
    public Vector3 carspawn2;
    public Vector3 carspawn3;
    // Start is called before the first frame update
    void Start()
    {
        carspawn1 = transform.position;
        carspawn2 = transform.position;
        carspawn3 = transform.position;
        StartCoroutine(SpawnCar());
    }

    // Update is called once per frame
    void Update()
    {

    }

    private IEnumerator SpawnCar()
    {
        while(true)
        {
            yield return new WaitForSeconds(1);
            Instantiate(car1[Random.Range(0, car1.Length)],carspawn1,Quaternion.identity);
            Instantiate(car2[Random.Range(0, car2.Length)],carspawn2,Quaternion.identity);
            Instantiate(car3[Random.Range(0, car3.Length)],carspawn3,Quaternion.identity);
        }
    }
}
