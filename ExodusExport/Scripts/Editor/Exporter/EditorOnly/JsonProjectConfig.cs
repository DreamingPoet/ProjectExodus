using UnityEngine;
using System.Collections.Generic;

namespace SceneExport{
	[System.Serializable]
	public class JsonProjectConfig: JsonValueObject{
		public bool excludeSkinnedMeshes = false;
		public override void writeJsonObjectFields(FastJsonWriter writer){
			writer.writeKeyVal("excludeSkinnedMeshes", excludeSkinnedMeshes);
		}
	}
}
