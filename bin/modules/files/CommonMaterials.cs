using KitchenLib.Utils;
using UnityEngine;

namespace KitchenMyMod {

    public class CommonMaterials {

        public static Material[] metalShiny => wrap(MaterialUtils.GetExistingMaterial("Metal- Shiny"));
 
        private static Material[] wrap(Material material) => new Material[] { material };
    }
}
