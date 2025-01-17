using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[TrackColor(0.9454092f, 0.9779412f, 0.3883002f)]
[TrackClipType(typeof(MultichoiceClip))]
[TrackBindingType(typeof(BaseChoiceManager))]
public class MultichoiceTrack : TrackAsset
{
    public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
    {
        return ScriptPlayable<MultichoiceMixerBehaviour>.Create (graph, inputCount);
    }

    public override void GatherProperties(PlayableDirector director, IPropertyCollector driver)
    {
#if UNITY_EDITOR
        //BaseChoiceManager.GatherProperties(this, director, driver);
#endif
        base.GatherProperties(director, driver);
    }
}
