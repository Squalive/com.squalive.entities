using System;
using Unity.Collections;
using Unity.Entities;

namespace Unity.Scenes
{
    public struct BuildManifest
    {
        internal const int ManifestCurrentVersion = 1;

        public string RootPath => Path.Value;

        public string EntityScenePath => $"{RootPath}\\EntityScenes";

        [NonSerialized] public FixedString512Bytes Path;

        public BlobArray<Hash128> Scenes;
    }
}