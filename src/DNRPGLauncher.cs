using DuckGame;

namespace DuckNukem.src {
    [EditorGroup("Duck Nukem")]

    class DNRPGLauncher : SMG {
        public DNRPGLauncher(float xval, float yval) : base(xval, yval) {
            this._type = "gun";
            this._editorName = "RPG";
            this._bio = "The rocket launched weapon is great for dealing with enemies from a distance.";
            this._fireSound = GetPath("sounds/DNRPGLauncher.wav");
            this.graphic = new Sprite(GetPath("sprites/DNRPGLauncher.png"));
            this._ammoType = new ATMissile();
            this.ammo = 5;
            this._fullAuto = false;
            this._fireWait = 5f;
            this._kickForce = 5f;
            this.loseAccuracy = 0.5f;
            this.maxAccuracyLost = 2f;
            this.center = new Vec2(this.graphic.width / 2, this.graphic.height / 2);
            this.collisionOffset = -1 * this.center;
            this.collisionSize = new Vec2(this.graphic.width, this.graphic.height);
            this._holdOffset = new Vec2(2f, 1f);
            this._barrelOffsetTL = new Vec2(this.graphic.width, this.graphic.height / 2 + 1);
        }
    }
}