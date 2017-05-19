using UnityEngine;
using System.Collections;

public class FlowerGeneator : MonoBehaviour {

    public GameObject flowerPerfab;

    public int numOfFlowers = 20;

	// Use this for initialization
	void Start () {
        generateFlower();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void generateFlower()
    {
        if(flowerPerfab)
        {
            for(int i = 0; i < numOfFlowers; i++)
            {
                GameObject newFlower = GameObject.Instantiate(flowerPerfab);
                newFlower.transform.parent = this.transform;
                newFlower.transform.position = Vector3.Scale((Random.insideUnitSphere * 15.0f), new Vector3(1.0f, 0.0f, 1.0f));
                newFlower.transform.position += (newFlower.transform.position - transform.position).normalized * 5.0f;
            }
        }
    }
}
