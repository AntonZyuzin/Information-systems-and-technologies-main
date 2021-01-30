namespace Implementation6
{
    public class Costume : Сlothing
    {
        public Costume(int length, int heigth, int weight)
        {
            this.Length = length;
            this.Height = heigth;
            this.Weight = weight;
        }

        public override void ChangeTexture(string texture)
        {
            this.Texture = texture;
        }

        public override void CutToChangeLength(int length)
        {
            this.Length = length;
        }

        public override void CutToChangeHeigth(int heigth)
        {
            this.Height = heigth;
        }

        public override void CutToChangeWeight(int weight)
        {
            this.Weight = weight;
        }
    }
}
