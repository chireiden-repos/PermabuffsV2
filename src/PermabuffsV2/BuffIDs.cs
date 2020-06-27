using System.Collections.Generic;
using Terraria.ID;

namespace Permabuffs_V2
{
    public static class BuffIDs
    {
        private static List<int> NonPermanentBuffs = new List<int>
        {
            BuffID.ShadowOrb,
            BuffID.FairyBlue,
            BuffID.PetBunny,
            BuffID.BabyPenguin,
            BuffID.PetTurtle,
            BuffID.BabyEater,
            BuffID.Pygmies,
            BuffID.BabySkeletronHead,
            BuffID.BabyHornet,
            BuffID.TikiSpirit,
            BuffID.PetLizard,
            BuffID.PetParrot,
            BuffID.BabyTruffle,
            BuffID.PetSapling,
            BuffID.Wisp,
            BuffID.BabyDinosaur,
            BuffID.BabySlime,
            BuffID.EyeballSpring,
            BuffID.BabySnowman,
            BuffID.PetSpider,
            BuffID.Squashling,
            BuffID.BlackCat,
            BuffID.CursedSapling,
            BuffID.Rudolph,
            BuffID.Puppy,
            BuffID.BabyGrinch,
            BuffID.FairyRed,
            BuffID.FairyGreen,
            BuffID.ZephyrFish,
            BuffID.BunnyMount,
            BuffID.PigronMount,
            BuffID.SlimeMount,
            BuffID.TurtleMount,
            BuffID.BeeMount,
            BuffID.MiniMinotaur,
            BuffID.UFOMount,
            BuffID.DrillMount,
            BuffID.ScutlixMount,
            BuffID.MagicLantern,
            BuffID.BabyFaceMonster,
            BuffID.CrimsonHeart,
            BuffID.UnicornMount,
            BuffID.CuteFishronMount,
            BuffID.SuspiciousTentacle,
            BuffID.CompanionCube,
            BuffID.BasiliskMount,
            BuffID.PetDD2Gato,
            BuffID.PetDD2Ghost,
            BuffID.PetDD2Dragon
        };
        public static bool IsPermanent(this int buffID)
        {
            return !NonPermanentBuffs.Contains(buffID);
        }
    }
}