using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(EnemyScript))]
public class EditorEnemyScript : Editor
{
    [DrawGizmo(GizmoType.Selected | GizmoType.NonSelected)]
    static void DrawGizmoSelected(EnemyScript enemy, GizmoType gizmotype)
    {
        Gizmos.DrawWireSphere(enemy.transform.position, enemy.range);
    }

    //void OnSceneGUI()
    //{
    //    EnemyScript comp_enemy = (EnemyScript)target;
    //    comp_enemy.range = Handles.RadiusHandle(comp_enemy.transform.rotation, comp_enemy.transform.position, comp_enemy.range);
    //}

    public override void OnInspectorGUI()
    {
        // Im changing the script UI
        DrawDefaultInspector();

        EditorGUILayout.HelpBox("this is a test", MessageType.Info);
        if(GUILayout.Button("Do something"))
        {
            Debug.Log("doing something");
        }
    }
}
