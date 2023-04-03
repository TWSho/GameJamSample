using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Extreal.Core.StageNavigation;

namespace GameJam
{
    // Class that holds the stage config
    [CreateAssetMenu(
        menuName = "Config/" + nameof(StageConfig),
        fileName = nameof(StageConfig))]
    public class StageConfig : StageConfigBase<StageName, SceneName>
    {
    }
}
