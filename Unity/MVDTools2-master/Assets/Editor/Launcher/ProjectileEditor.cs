using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEditor;

[CustomEditor(typeof(Projectile))]
public class ProjectileEditor : Editor
{
    // When our gameobject is selected, everything within this method will be drawn.
    [DrawGizmo(GizmoType.Selected | GizmoType.NonSelected)]
    static void DrawGizmosSelected(Projectile projectile, GizmoType gizmoType)
    {
        Gizmos.DrawWireSphere(projectile.transform.position, projectile.damageRadius);
    }

    // Method that is always drawn on scene viewport
    void OnSceneGUI()
    {
        Projectile projectile = (Projectile)target;
        Transform transform = projectile.transform;
        projectile.damageRadius = Handles.RadiusHandle(transform.rotation, transform.position, projectile.damageRadius);
    }
}