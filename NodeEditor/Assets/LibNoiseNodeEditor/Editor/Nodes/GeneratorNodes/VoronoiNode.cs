﻿
using UnityEditor;
using LibNoise.Generator;

public class VoronoiNode : EditorNode
{
    private Voronoi _noise = new Voronoi();

    public VoronoiNode()
    {
        name = "Voronoi";

        var noiseIn = AddInput();
        noiseIn.name = "Input";

        var mask = AddInput();
        mask.name = "Mask";

        var noiseOut = AddOutput();
        noiseOut.name = "Output";

        FitKnobs();

        bodyRect.height += 60f;
        bodyRect.width = 150f;
    }

    public override void OnBodyGUI()
    {
        _noise.Frequency = EditorGUILayout.DoubleField("Frequency", _noise.Frequency);
        _noise.Displacement = EditorGUILayout.DoubleField("Displacement", _noise.Displacement);
        _noise.UseDistance = EditorGUILayout.Toggle("Use Distance", _noise.UseDistance);
    }
}