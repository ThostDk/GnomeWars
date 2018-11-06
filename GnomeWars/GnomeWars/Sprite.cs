using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GnomeWars
{
    class Sprite
    {
        public Vector2 Position = new Vector2(0, 0);
        protected Texture2D spriteTexture;

        public void LoadContent(ContentManager theContentManager, string myAssetName)
        {
            spriteTexture = theContentManager.Load<Texture2D>(myAssetName);
        }
    }
}
