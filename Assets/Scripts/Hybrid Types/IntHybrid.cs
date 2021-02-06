using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HybridTypes
{
    [CreateAssetMenu(fileName = CreateMenus.intHybridFileName, menuName = CreateMenus.intHybridMenu, order = CreateMenus.intHybridOrder)]
    public class IntHybrid : BaseHybrid<int>
    {
    }
}