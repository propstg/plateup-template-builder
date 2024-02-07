using KitchenData;
using KitchenLib.References;
using KitchenLib.Utils;

namespace KitchenMyMod {

    public class Refs {

        public static Item Potato => (Item)GDOUtils.GetExistingGDO(ItemReferences.Potato);
    }
}
