using UnityEngine;

public class SkinnedMeshSampler : MonoBehaviour
{
    [SerializeField] private SkinnedMeshRenderer _renderer;

    void Start()
    {
    }

    void Update()
    {
        
    }

    private void OnDrawGizmos()
    {
        if (_renderer != null) {
       
            for(int i=0; i<_renderer.sharedMesh.vertexCount; i++)
            {
                var vertex = _renderer.sharedMesh.vertices[i];
                var normal = _renderer.sharedMesh.normals[i];

                Gizmos.DrawLine(vertex, vertex + normal * 0.1f);
            }
        }
    }
}
