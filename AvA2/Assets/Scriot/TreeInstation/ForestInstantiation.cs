using UnityEngine;
using System.Collections;

public class ForestInstantiation : MonoBehaviour
{
    public GameObject[] prefabs;
    public Terrain terrain;
    public int maxTrees;
    public Vector3 scaleVariance;
    public Vector3 rotationVariance;

    private GameObject[] instantiatedTrees;

    private void OnValidate()
    {
        if (maxTrees < 0)
        {
            maxTrees = 0;
        }

        if (instantiatedTrees != null)
        {
            foreach (GameObject tree in instantiatedTrees)
            {
                Destroy(tree);
            }
        }

        instantiatedTrees = new GameObject[maxTrees];
        for (int i = 0; i < maxTrees; i++)
        {
            Vector3 randomPos = new Vector3(Random.Range(terrain.transform.position.x, terrain.transform.position.x + terrain.terrainData.size.x), 0, Random.Range(terrain.transform.position.z, terrain.transform.position.z + terrain.terrainData.size.z));
            float yPos = terrain.SampleHeight(randomPos);
            randomPos.y = yPos;
            GameObject prefab = prefabs[Random.Range(0, prefabs.Length)];
            GameObject tree = Instantiate(prefab, randomPos, Quaternion.Euler(0, Random.Range(0, 360), 0));
            tree.transform.localScale += new Vector3(Random.Range(-scaleVariance.x, scaleVariance.x), Random.Range(-scaleVariance.y, scaleVariance.y), Random.Range(-scaleVariance.z, scaleVariance.z));
            tree.transform.Rotate(Random.Range(-rotationVariance.x, rotationVariance.x), Random.Range(-rotationVariance.y, rotationVariance.y), Random.Range(-rotationVariance.z, rotationVariance.z));
            instantiatedTrees[i] = tree;
        }
    }
}