using DuckGame;

namespace DuckNukem.src {
    [EditorGroup("Duck Nukem")]

    class DNChaingun : SMG {
        public DNChaingun(float xval, float yval) : base(xval, yval) {
            this._ammoType = new AT9mm();
            this._barrelOffsetTL = new Vec2(17f, 3f);
            this._bio = "This rapid fire chaingun is a good weapon for dispersing several enemies at once.";
            this._editorName = "Ripper Chaingun";
            this._fireSound = GetPath("sounds/chaingun.wav");
            this._fullAuto = true;
            //this._fireWait = 1f;
            this.graphic = new Sprite(GetPath("sprites/ChaingunSprite.png"), 32, 8);
            this.ammo = 50;
            this.center = new Vec2(10f, 4f);
            this.collisionOffset = new Vec2(-9f, -6f);
            this.collisionSize = new Vec2(16f, 11f);
        }
    }
}