using DuckGame;

namespace DuckNukem.src {
    [EditorGroup("Duck Nukem")]

    class DNChaingun : SMG {
        public DNChaingun(float xval, float yval) : base(xval, yval) {
            this._type = "gun";
            this._editorName = "Ripper Chaingun";
            this._bio = "This rapid fire chaingun is a good weapon for dispersing several enemies at once.";
            this._fireSound = GetPath("sounds/DNChaingun.wav");
            this.graphic = new Sprite(GetPath("sprites/DNChaingun.png"));
            this._ammoType = new AT9mm();
            this.ammo = 50;
            this._fullAuto = true;
            this._fireWait = 0.85f;
            this._kickForce = 2f;
            this.loseAccuracy = 0.05f;
            this.maxAccuracyLost = 0.2f;
            this.center = new Vec2(this.graphic.width / 2, this.graphic.height / 2);
            this.collisionOffset = -1 * this.center;
            this.collisionSize = new Vec2(this.graphic.width, this.graphic.height);
            this.handOffset = new Vec2(0f, 1f);
            this._holdOffset = new Vec2(6f, 4f);
            this._barrelOffsetTL = new Vec2(this.graphic.width, this.graphic.height / 2 + 1);
        }
    }
}