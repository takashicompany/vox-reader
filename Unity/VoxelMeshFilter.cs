namespace TakashiCompany.Unity.VoxReader
{
	using System.Collections;
	using System.Collections.Generic;
	using System.Linq;
	using UnityEngine;

	public class VoxelMeshFilter : MonoBehaviour
	{
		[SerializeField]
		private VoxelMeshGenerator<SimpleVoxel> _vertexGenerator;

		[SerializeField]
		private MeshFilter _meshFilter;

		[ContextMenu("generate")]
		private void Generate()
		{
			_vertexGenerator.GenerateVoxel(true);
			var mesh = _vertexGenerator.GenerateMesh();

			_meshFilter.sharedMesh = mesh;
		}

	}
}