// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System;
using osu.Framework.Allocation;
using osu.Framework.Graphics.Sprites;
using osu.Framework.Graphics.Textures;

namespace osu.Game.Skinning
{
    /// <summary>
    /// A skinnable element which uses a stable sprite and can therefore share implementation logic.
    /// </summary>
    public class SkinnableSprite : SkinnableDrawable<Sprite>
    {
        protected override bool ApplySizeRestrictionsToDefault => true;

        [Resolved]
        private TextureStore textures { get; set; }

        public SkinnableSprite(string name, Func<ISkinSource, bool> allowFallback = null, bool restrictSize = true)
            : base(name, allowFallback, restrictSize)
        {
        }

        protected override Sprite CreateDefault(string name) => new Sprite { Texture = textures.Get(name) };
    }
}
