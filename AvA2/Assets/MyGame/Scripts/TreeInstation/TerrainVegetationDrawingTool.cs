//using UnityEngine;
//using UnityEditor;

//[CustomEditor(typeof(ForestInstantiation))]
//public class ForestInstantiationEditor : Editor
//{
//    private ForestInstantiation forestInstantiation;
//    private float brushSize = 0.1f;
//    private float density = 10;

//    private void OnSceneGUI()
//    {
//        forestInstantiation = (ForestInstantiation)target;
//        Event e = Event.current;
//        if (e.type == EventType.MouseDown && e.button == 0)
//        {
//            Vector3 mousePos = HandleUtility.GUIPointToWorldRay(e.mousePosition).origin;
//            if (forestInstantiation.terrain.GetComponent<Collider>().bounds.Contains(mousePos))
//            {
//                InstantiateTrees(mousePos);
//            }
//        }
//        Handles.color = Color.red;
//        Handles.DrawWireDisc(forestInstantiation.transform.position, Vector3.up, brushSize);
//    }

//    private void InstantiateTrees(Vector3 center)
//    {
//        float maxTrees = brushSize * brushSize * density;
//        int treeCount = 0;
//        for (int i = 0; i < maxTrees; i++)
//        {
//            Vector3 randomPos = center + new Vector3(Random.Range(-brushSize, brushSize), 0, Random.Range(-brushSize, brushSize));
//            float yPos = forestInstantiation.terrain.SampleHeight(randomPos);
//            randomPos.y = yPos;
//            if (randomPos.y > 0)
//            {
//                GameObject prefab = forestInstantiation.prefabs[Random.Range(0, forestInstantiation.prefabs.Length)];
//                GameObject tree = Instantiate(prefab, randomPos, Quaternion.Euler(0, Random.Range(0, 360), 0));
//                tree.transform.localScale += new Vector3(Random.Range(-forestInstantiation.scaleVariance.x, forestInstantiation.scaleVariance.x), Random.Range(-forestInstantiation.scaleVariance.y, forestInstantiation.scaleVariance.y), Random.Range(-forestInstantiation.scaleVariance.z, forestInstantiation.scaleVariance.z));
//                tree.transform.Rotate(Random.Range(-forestInstantiation.rotationVariance.x, forestInstantiation.rotationVariance.x), Random.Range(-forestInstantiation.rotationVariance.y, forestInstantiation.rotationVariance.y), Random.Range(-forestInstantiation.rotationVariance.z, forestInstantiation.rotationVariance.z));
//                treeCount++;
//                if (treeCount >= maxTrees)
//                {
//                    break;
//                }
//            }
//        }
//    }
//}