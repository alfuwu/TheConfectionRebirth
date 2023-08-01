using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.ModLoader;

namespace TheConfectionRebirth.Backgrounds.MenuBackgrounds
{
    public class ConfectionMenuBackgroundNight : ModSurfaceBackgroundStyle
    {
        public override void ModifyFarFades(float[] fades, float transitionSpeed)
        {
            for (int i = 0; i < fades.Length; i++)
            {
                if (i == Slot)
                {
                    fades[i] += transitionSpeed;
                    if (fades[i] > 1f)
                    {
                        fades[i] = 1f;
                    }
                }
                else
                {
                    fades[i] -= transitionSpeed;
                    if (fades[i] < 0f)
                    {
                        fades[i] = 0f;
                    }
                }
            }
        }

        public override int ChooseFarTexture()
        {
            return BackgroundTextureLoader.GetBackgroundSlot("TheConfectionRebirth/Backgrounds/ConfectionSurface2Far");
        }

        public override int ChooseMiddleTexture()
        {
            return BackgroundTextureLoader.GetBackgroundSlot("TheConfectionRebirth/Backgrounds/ConfectionSurface2Mid");
        }

        public override int ChooseCloseTexture(ref float scale, ref double parallax, ref float a, ref float b)
        {
            return BackgroundTextureLoader.GetBackgroundSlot("TheConfectionRebirth/Backgrounds/ConfectionSurface2Close");
        }
    }
}