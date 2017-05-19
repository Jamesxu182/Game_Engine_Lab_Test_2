using UnityEngine;
using System.Collections;

public class BeeGenerator : MonoBehaviour {

    public GameObject beePrefab;

    public GameObject bees;

    public GameObject flowers;

    public int numPollen = 10;

    public float numPerSecond = 0.5f;

	// Use this for initialization
	void Start () {
        StartCoroutine(generateBees());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    System.Collections.IEnumerator generateBees()
    {
        yield return new WaitForSeconds(0.5f);
        while(true)
        {
            if(bees && beePrefab)
            {
                if(bees.transform.childCount < 10 && numPollen >= 5)
                {
                    GameObject newBee = GameObject.Instantiate(beePrefab);
                    newBee.transform.parent = bees.transform;

                    if(flowers)
                    {
                        newBee.GetComponent<ArriveBehaviour>().target = flowers.transform.GetChild(Random.Range(0, flowers.transform.childCount)).position;
                    }


                    numPollen -= 5;
                }
            }

            yield return new WaitForSeconds(1.0f / numPerSecond);
        }
    }
}
